using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections;

namespace Penumbra
{
    class Monitors
    {

#region Consts

        public const uint MC_CAPS_BRIGHTNESS = 0x00000002;

#endregion


#region Structs

        [StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        public struct Monitor
        {
            public IntPtr hMonitor;
            public Brightness brightness;
            public Monitor init()
            {
                brightness = brightness.init();
                return this;
            }
        }
        public struct Brightness
        {
            public uint current;
            public uint min;
            public uint max;

            public Brightness init()
            {
                  current = 0;
                  min = 0;
                  max = 0;
                  return this;
            }
        }

        public struct MonitorResult
        {
            public Boolean success;
            public IntPtr hMonitor;

            public MonitorResult init()
            {
                success = false;
                hMonitor = IntPtr.Zero;
                return this;
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct PHYSICAL_MONITOR
        {
            public IntPtr hPhysicalMonitor;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szPhysicalMonitorDescription;
        }

#endregion


#region Imports
        [DllImport("user32.dll")]
        static extern bool EnumDisplayMonitors(IntPtr hdc, IntPtr lprcClip, MonitorEnumDelegate lpfnEnum, IntPtr dwData);

        delegate bool MonitorEnumDelegate(IntPtr hMonitor, IntPtr hdcMonitor, ref Rect lprcMonitor, IntPtr dwData);

        [DllImport("Dxva2.dll")]
        static extern bool SetMonitorBrightness(IntPtr hMonitor,
                                                int dwNewBrightness);

        [DllImport("Dxva2.dll")]
        static extern bool GetMonitorBrightness([In] IntPtr hMonitor,
                                               ref uint pdwMinimumBrightness,
                                               ref uint pdwCurrentBrightness,
                                               ref uint pdwMaximumBrightness);

        [DllImport("kernel32.dll")]
        public static extern uint GetLastError();

        [DllImport("dxva2.dll", EntryPoint = "GetPhysicalMonitorsFromHMONITOR")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPhysicalMonitorsFromHMONITOR(
            IntPtr hMonitor, uint dwPhysicalMonitorArraySize, [Out] PHYSICAL_MONITOR[] pPhysicalMonitorArray);

        [DllImport("dxva2.dll", EntryPoint = "GetNumberOfPhysicalMonitorsFromHMONITOR", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNumberOfPhysicalMonitorsFromHMONITOR(
            IntPtr hMonitor, ref uint pdwNumberOfPhysicalMonitors);

        [DllImport("dxva2.dll", EntryPoint = "DestroyPhysicalMonitors", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyPhysicalMonitors(
            uint dwPhysicalMonitorArraySize, [Out] PHYSICAL_MONITOR[] pPhysicalMonitorArray);

        [DllImport("dxva2.dll", EntryPoint = "GetMonitorTechnologyType", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMonitorTechnologyType(
            IntPtr hMonitor, ref MC_DISPLAY_TECHNOLOGY_TYPE pdtyDisplayTechnologyType);

        [DllImport("dxva2.dll", EntryPoint = "GetMonitorCapabilities", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMonitorCapabilities(
            IntPtr hMonitor, ref uint pdwMonitorCapabilities, ref uint pdwSupportedColorTemperatures);

#endregion


#region Variables
        
        static ArrayList hMonitorList = new ArrayList();
        
        private static Monitors instance;

#endregion


#region Ctors

        private Monitors()
        {

        }
        public static Monitors Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Monitors();
                }
                return instance;
            }
        }

#endregion

        #region Public Functions

        public void Init()
        {
            GetDisplays();
        }
        public int GetBrightness()
        {
            return Convert.ToInt32(((Monitor)hMonitorList[0]).brightness.current);
        }
        public void SetBrightness(int brightness)
        {
            //todo get the normalized brightness
            foreach (Monitor monitor in hMonitorList)
            {
                bool isIt = SetMonitorBrightness(monitor.hMonitor, brightness);
                int lastWin32Error = Marshal.GetLastWin32Error();
            }
        }

        public Boolean HasBrightnessCapability()
        {
            return hMonitorList.Count > 0;
        }


#endregion


#region Private Functions

        private static void GetDisplays()
        {
            EnumDisplayMonitors(IntPtr.Zero, IntPtr.Zero,
                delegate(IntPtr hMonitor, IntPtr hdcMonitor, ref Rect lprcMonitor, IntPtr dwData)
                {
                    MonitorResult monitorResult = VerifyMonitorCapabilities(hMonitor);

                    if (monitorResult.success)
                    {
                        RecordMonitorBrightness(monitorResult.hMonitor);
                    }

                    return true;
                }, IntPtr.Zero);

        }
        private static bool RecordMonitorBrightness(IntPtr hMonitor)
        {
            Monitor monitor = new Monitor().init();

            bool hasBrightness = GetMonitorBrightness(hMonitor, ref monitor.brightness.min, ref monitor.brightness.current, ref monitor.brightness.max);
            uint error = GetLastError();

            if (hasBrightness)
            {
                monitor.hMonitor = hMonitor;
                hMonitorList.Add(monitor);
            }
            return hasBrightness;
        }

        private static MonitorResult VerifyMonitorCapabilities(IntPtr inMonitor)
        {

            IntPtr hMonitor = inMonitor;
            EnumDisplayMonitors(
                inMonitor,
                inMonitor,
                delegate(IntPtr monitor, IntPtr hdcMonitor, ref Rect lprcMonitor, IntPtr dwData)
                {
                    hMonitor = monitor;
                    return true;
                },
                inMonitor);

            int lastWin32Error = Marshal.GetLastWin32Error();

            uint pdwNumberOfPhysicalMonitors = 0u;
            bool numberOfPhysicalMonitorsFromHmonitor = GetNumberOfPhysicalMonitorsFromHMONITOR(
                hMonitor, ref pdwNumberOfPhysicalMonitors);
            lastWin32Error = Marshal.GetLastWin32Error();

            PHYSICAL_MONITOR[] pPhysicalMonitorArray =
                new PHYSICAL_MONITOR[pdwNumberOfPhysicalMonitors];
            bool physicalMonitorsFromHmonitor = GetPhysicalMonitorsFromHMONITOR(
                hMonitor, pdwNumberOfPhysicalMonitors, pPhysicalMonitorArray);
            lastWin32Error = Marshal.GetLastWin32Error();

            uint pdwMonitorCapabilities = 0u;
            uint pdwSupportedColorTemperatures = 0u;
            var monitorCapabilities = GetMonitorCapabilities(
                pPhysicalMonitorArray[0].hPhysicalMonitor, ref pdwMonitorCapabilities, ref pdwSupportedColorTemperatures);
            lastWin32Error = Marshal.GetLastWin32Error();

            bool hasMonitorCapabilities = (((int)MC_CAPS_BRIGHTNESS & pdwMonitorCapabilities) > 0);

            MonitorResult monitorResult = new MonitorResult();
            monitorResult.success = hasMonitorCapabilities;
            monitorResult.hMonitor = pPhysicalMonitorArray[0].hPhysicalMonitor;
            
            return monitorResult;
        }

#endregion

#region Enum
        public enum MC_DISPLAY_TECHNOLOGY_TYPE
        {
            MC_SHADOW_MASK_CATHODE_RAY_TUBE,
            MC_APERTURE_GRILL_CATHODE_RAY_TUBE,
            MC_THIN_FILM_TRANSISTOR,
            MC_LIQUID_CRYSTAL_ON_SILICON,
            MC_PLASMA,
            MC_ORGANIC_LIGHT_EMITTING_DIODE,
            MC_ELECTROLUMINESCENT,
            MC_MICROELECTROMECHANICAL,
            MC_FIELD_EMISSION_DEVICE,
        }
#endregion


    }
}
