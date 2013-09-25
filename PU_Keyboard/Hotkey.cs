using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Windows.Input;

namespace PU_Keyboard
{

	public class Hotkey : IMessageFilter
	{

#region Consts

		private const uint WM_HOTKEY = 0x312;

		private const uint MOD_ALT = 0x1;
		private const uint MOD_CONTROL = 0x2;
		private const uint MOD_SHIFT = 0x4;
		//private const uint MOD_WIN = 0x8;

		private const uint ERROR_HOTKEY_ALREADY_REGISTERED = 1409;

		private const int MAXIMUM_ID = 0xBFFF;

#endregion

#region Imports
// ReSharper disable InconsistentNaming

		[DllImport("user32.dll", SetLastError = true)]
		private static extern int RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, Keys vk);

		[DllImport("user32.dll", SetLastError=true)]
		private static extern int UnregisterHotKey(IntPtr hWnd, int id);

// ReSharper restore InconsistentNaming
#endregion

#region Variables

		private static int m_CurrentID;

		[XmlIgnore]
		private int m_ID;
		[XmlIgnore]
		private Control m_WindowControl;

		private Window m_HotkeyWindow;

#endregion

#region Events

		public event HandledEventHandler Pressed;

#endregion

#region Properties

		public bool Enabled { get; set; }

		public bool Registered { get; private set; }

		public bool Control { get; private set; }
		public bool Shift { get; private set; }
		public bool Alt { get; private set; }
		public Keys Key { get; private set; }

#endregion

#region Ctors

		public Hotkey(ModifierKeys p_ModifierKeys, Keys p_Key)
		{
			
			// Assign properties
			Control = p_ModifierKeys.HasFlag(ModifierKeys.Control);
			Shift = p_ModifierKeys.HasFlag(ModifierKeys.Shift);
			Alt = p_ModifierKeys.HasFlag(ModifierKeys.Alt);
			Key = p_Key;

			Initialize();

		}

		public Hotkey(bool p_Control, bool p_Shift, bool p_Alt, Keys p_Key)
		{
			
			// Assign properties
			Control = p_Control;
			Shift = p_Shift;
			Alt = p_Alt;
			Key = p_Key;

			Initialize();

		}

		public Hotkey(string p_HotkeyString)
		{

			// CTRL|SHIFT|ALT|Key

			string[] c_HotkeyValues = p_HotkeyString.Split('|');

			// Assign properties
			Control = (c_HotkeyValues[0] == "1");
			Shift = (c_HotkeyValues[1] == "1");
			Alt = (c_HotkeyValues[2] == "1");
			Key = (Keys) Enum.Parse(typeof (Keys), c_HotkeyValues[3]);

			Initialize();

		}

#endregion

#region Dtor

		~Hotkey()
		{

			// Unregister the hotkey if necessary
			if (Registered)
				Unregister();

		}

#endregion

#region Public Functions

		public void Alter(ModifierKeys p_ModifierKeys, Keys p_Key)
		{

			Control c_TempControl = m_WindowControl;

			Unregister();

			Control = p_ModifierKeys.HasFlag(ModifierKeys.Control);
			Shift = p_ModifierKeys.HasFlag(ModifierKeys.Shift);
			Alt = p_ModifierKeys.HasFlag(ModifierKeys.Alt);
			Key = p_Key;

			Register(c_TempControl);

		}

		public void Alter(bool p_Control, bool p_Shift, bool p_Alt, Keys p_Key)
		{

			Control c_TempControl = m_WindowControl;

			Unregister();

			Control = p_Control;
			Shift = p_Shift;
			Alt = p_Alt;
			Key = p_Key;

			Register(c_TempControl);

		}

		public void Alter(string p_HotkeyString)
		{

			// CTRL|SHIFT|ALT|Key

			Control c_TempControl = m_WindowControl;

			Unregister();

			string[] c_HotkeyValues = p_HotkeyString.Split('|');

			// Assign properties
			Control = (c_HotkeyValues[0] == "1");
			Shift = (c_HotkeyValues[1] == "1");
			Alt = (c_HotkeyValues[2] == "1");
			Key = (Keys) Enum.Parse(typeof (Keys), c_HotkeyValues[3]);

			Register(c_TempControl);

		}

		public Hotkey Clone()
		{

			// Clone the whole object
			return new Hotkey(Control, Shift, Alt, Key);

		}

		public bool GetCanRegister(Control p_WindowControl)
		{

			// Handle any exceptions: they mean "no, you can't register" :)
			try
			{

				// Attempt to register
				if (!Register(p_WindowControl))
					return false;

				// Unregister and say we managed it
				Unregister();

				return true;

			}
			catch (Win32Exception)
			{
				
				return false;

			}
			catch (NotSupportedException)
			{
				
				return false;

			}

		}

		public bool Register(Control p_WindowControl = default(Control))
		{

			// Check that we have not registered
			if (Registered)
				throw new NotSupportedException("You cannot register a hotkey that is already registered");

			if (p_WindowControl == default(Control))
				p_WindowControl = m_HotkeyWindow.m_Button;

			// Get an ID for the hotkey and increase current ID
			m_ID = m_CurrentID;
			m_CurrentID = ((m_CurrentID + 1) % MAXIMUM_ID);

			// Translate modifier keys into unmanaged version
			uint c_Modifiers = (Alt ? MOD_ALT : 0) | (Control ? MOD_CONTROL : 0) | (Shift ? MOD_SHIFT : 0) | 0 /* WIN key */;

			// Register the hotkey
			if (RegisterHotKey(p_WindowControl.Handle, m_ID, c_Modifiers, Key) == 0)
			{ 

				// Is the error that the hotkey is registered?
				if (Marshal.GetLastWin32Error() == ERROR_HOTKEY_ALREADY_REGISTERED)
					return false;
				
				throw new Win32Exception();

			}

			// Save the control reference and register state
			Registered = true;
			m_WindowControl = p_WindowControl;

			Debug.WriteLine(ToString() + @" hotkey registered.");

			// We successfully registered
			return true;

		}

		public void Unregister()
		{

			// Check that we have registered
			if (!Registered)
				throw new NotSupportedException("You cannot unregister a hotkey that is not registered.");
		
			// It's possible that the control itself has died: in that case, no need to unregister!
			if (!m_WindowControl.IsDisposed)
			{

				try
				{

					UnregisterHotKey(m_WindowControl.Handle, m_ID);

				}
				catch (Exception c_Exception)
				{

					Debug.WriteLine(c_Exception.Message);

				}

			}

			// Clear the control reference and register state
			Registered = false;
			m_WindowControl = null;

		}

#endregion

#region Private Functions

		private void Initialize()
		{

			Enabled = true;

			m_HotkeyWindow = new Window();

			// Register us as a message filter
			Application.AddMessageFilter(this);

		}

		private bool OnPressed()
		{

			// Fire the event if we can
			HandledEventArgs c_HandledEventArgs = new HandledEventArgs(false);
			if (Pressed != null)
				Pressed(this, c_HandledEventArgs);

			// Return whether we handled the event or not
			return c_HandledEventArgs.Handled;

		}

#endregion

#region Overrides

		public bool PreFilterMessage(ref Message message)
		{

			// Only process WM_HOTKEY messages
			if (message.Msg != WM_HOTKEY)
				return false;

			// Check that the ID is our key and we are registerd
			if (Registered && (message.WParam.ToInt32() == m_ID))
				// Fire the event and pass on the event if our handlers didn't handle it
				return (Enabled && OnPressed());

			return false;

		}

		public override string ToString()
		{

			// Build key name
			string c_KeyName = Enum.GetName(typeof(Keys), Key);

			if (c_KeyName == null)
				return "(none)";

			switch (Key)
			{

				case Keys.D0:
				case Keys.D1:
				case Keys.D2:
				case Keys.D3:
				case Keys.D4:
				case Keys.D5:
				case Keys.D6:
				case Keys.D7:
				case Keys.D8:
				case Keys.D9:
					// Strip the first character
					c_KeyName = c_KeyName.Substring(1);
					break;

			}

			// Build modifiers
			string c_Modifiers = "";

			if (Control)
				c_Modifiers += "Control+";

			if (Shift)
				c_Modifiers += "Shift+";

			if (Alt)
				c_Modifiers += "Alt+";

			// Return result
			return (c_Modifiers + c_KeyName);

		}

#endregion

	}

}