using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PU_Bridge
{
	
	public sealed class Window : NativeWindow, IDisposable
	{

#region Consts

		private const int WM_SYSCOMMAND = 0x0112;
		private const int WM_HOTKEY = 0x0312;

		private const int SC_SCREENSAVE = 0xF140;

		private const int SPI_GETSCREENSAVERRUNNING = 0x0072;

#endregion

#region Imports

		[DllImport("user32.dll", SetLastError = true)]
		static extern bool SystemParametersInfo(int action, int param, ref int retval, int updini);

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

				case WM_SYSCOMMAND:
				{

					if (m.WParam.ToInt32() == SC_SCREENSAVE)
					{
						
						// Screensaver started

						Console.WriteLine("Screen saver off at {0}", DateTime.Now);

					}
					
					break;

				}

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
