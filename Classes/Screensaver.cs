using System;
using System.Runtime.InteropServices;

namespace Penumbra.Classes
{

	public class Screensaver
	{

#region Consts

		private const int WM_SYSCOMMAND = 0x112;
		private const int SC_SCREENSAVE = 0xF140;
		private const int SC_MONITORPOWER = 0xF170;
		private const int MONITOR_ON = -1;
		private const int MONITOR_OFF = 2;
		private const int MONITOR_STANBY = 1;

#endregion

#region Imports
// ReSharper disable InconsistentNaming

		[DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
		private static extern IntPtr GetDesktopWindow();

		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("user32.dll", SetLastError = true)]
		static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

// ReSharper restore InconsistentNaming
#endregion

#region Public Functions

		public static void TurnOn()
		{

			SendMessage(GetDesktopWindow(), WM_SYSCOMMAND, (IntPtr) SC_SCREENSAVE, (IntPtr) 0);

		}

		public static void DisplayToSleep()
		{

			PostMessage((IntPtr) 0xFFFF, WM_SYSCOMMAND, (IntPtr) SC_MONITORPOWER, (IntPtr) MONITOR_OFF);

		}

#endregion

	}

}
