using System;
using System.Windows.Forms;

namespace PU_Keyboard
{

	sealed class Window : NativeWindow, IDisposable
	{

#region Consts

		private const int WM_HOTKEY = 0x0312;

#endregion

#region Variables

		public Button m_Button;

#endregion

#region Ctors

		public Window()
		{
			
			CreateHandle(new CreateParams());

			m_Button = new Button { Tag = "hotkey_control" };

		}

#endregion

#region Public Functions
		
		public void Dispose()
		{
			
			DestroyHandle();

		}

#endregion

#region Overrides

		protected override void WndProc(ref Message m)
		{
			
			base.WndProc(ref m);

			// check if we got a hot key pressed.
			//if (m.Msg != WM_HOTKEY)
			//	return;

			// get the keys.
			//Keys c_Key = (Keys) (((int) m.LParam >> 16) & 0xFFFF);
			//ModifierKeys c_Modifier = (ModifierKeys) ((int) m.LParam & 0xFFFF);

			// invoke the event to notify the parent.
			//if (KeyPressed != null)
			//	KeyPressed(this, new KeyPressedEventArgs(c_Modifier, c_Key));

		}

#endregion

	}

}
