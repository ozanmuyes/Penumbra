using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PU_Bridge
{
	
	public sealed class Window : NativeWindow, IDisposable
	{

#region Consts

		private const int WM_HOTKEY = 0x0312;

#endregion

#region Variables

		public Button m_Hotkey;

#endregion

#region Ctors

		public Window()
		{

			CreateHandle(new CreateParams());

			m_Hotkey = new Button
				           {
							   Name = "bt_Hotkey",
					           Text = "Hotkey Button"
				           }; 

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

			switch (m.Msg)
			{

				case WM_HOTKEY:
				{

					Debug.WriteLine(@"Hotkey message: " + m.HWnd);
					
					break;

				}

			}

		}

#endregion

	}

}
