using System;
using System.Runtime.InteropServices;

namespace Penumbra.Classes
{

	/// <summary>
	/// Class for manipulating the brightness of the screen
	/// </summary>
	public static class Filter
	{

#region Consts

		public const byte MIN_BRIGHTNESS = 10;
		public const byte MAX_BRIGHTNESS = 110;

#endregion

#region Structs

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
// ReSharper disable InconsistentNaming
		public struct RAMP
// ReSharper restore InconsistentNaming
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
			public UInt16[] Red;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
			public UInt16[] Green;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
			public UInt16[] Blue;
		}

#endregion

#region Imports
// ReSharper disable InconsistentNaming

		[DllImport("user32.dll")]
		private static extern IntPtr GetDC(IntPtr hWnd);

		[DllImport("gdi32.dll")]
		static extern bool GetDeviceGammaRamp(IntPtr hdc, ref RAMP lpRamp);

		[DllImport("gdi32.dll")]
		static extern bool SetDeviceGammaRamp(IntPtr hdc, ref RAMP lpRamp);
                
        [DllImport("Dxva2.dll")]
        static extern bool SetMonitorBrightness(IntPtr hMonitor, uint dwNewBrightness );



// ReSharper restore InconsistentNaming
#endregion

#region Variables

// ReSharper disable InconsistentNaming
		private static RAMP m_InitialRAMP;
// ReSharper restore InconsistentNaming

		private static byte m_CurrentBrightness;

#endregion

#region Ctors

		static Filter()
		{
            //IntPtr ptr = IntPtr.Add(IntPtr.Zero, 1);
            GetDeviceGammaRamp(GetDC(IntPtr.Zero), ref m_InitialRAMP);

			m_CurrentBrightness = GetBrightnessFromRAMP(m_InitialRAMP);

		}

#endregion

#region Public Functions

		public static bool SetBrightness(byte p_Brightness)
		{

			if (p_Brightness < MIN_BRIGHTNESS || p_Brightness > MAX_BRIGHTNESS)
				return false;

			m_CurrentBrightness = p_Brightness;

			RAMP c_Ramp = CalculateRAMP(p_Brightness);

            SetDeviceGammaRamp(GetDC(IntPtr.Zero), ref c_Ramp);

			return true;
		}

		public static void ResetBrightness()
		{

			SetDeviceGammaRamp(GetDC(IntPtr.Zero), ref m_InitialRAMP);

		}

		public static byte IncreaseBrightness()
		{

			m_CurrentBrightness += 10;

			if (m_CurrentBrightness > MAX_BRIGHTNESS)
				m_CurrentBrightness = MAX_BRIGHTNESS;

			SetBrightness(m_CurrentBrightness);

			return m_CurrentBrightness;

		}

		public static byte DecreaseBrightness()
		{

			m_CurrentBrightness -= 10;

			if (m_CurrentBrightness < MIN_BRIGHTNESS)
				m_CurrentBrightness = MIN_BRIGHTNESS;

			SetBrightness(m_CurrentBrightness);

			return m_CurrentBrightness;

		}

#pragma warning disable 465
		public static void Finalize()
#pragma warning restore 465
		{

			ResetBrightness();

		}

#endregion

#region Private Functions

// ReSharper disable InconsistentNaming
		private static byte GetBrightnessFromRAMP(RAMP p_Ramp)
// ReSharper restore InconsistentNaming
		{

			return (byte) (p_Ramp.Blue[1] - 128);

		}

// ReSharper disable InconsistentNaming
		private static RAMP CalculateRAMP(byte p_Brightness)
// ReSharper restore InconsistentNaming
		{

			RAMP c_Ramp = new RAMP { Red = new ushort[256], Green = new ushort[256], Blue = new ushort[256] };

			for (int c_Index = 0; c_Index < 256; c_Index++)
			{

				c_Ramp.Red[c_Index] = (ushort) (c_Index * (p_Brightness + 128));
				c_Ramp.Green[c_Index] = (ushort) (c_Index * (p_Brightness + 128));
				c_Ramp.Blue[c_Index] = (ushort) (c_Index * (p_Brightness + 128));

			}

			return c_Ramp;

		}

#endregion

	}

}
