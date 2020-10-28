
namespace iTin.Hardware.Abstractions.Devices
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using MacOS = iTin.Core.Hardware.MacOS.Device.Desktop;
    using Win = iTin.Core.Hardware.Windows.Device.Desktop.Monitor;

    /// <summary>
    /// Define 
    /// </summary>
    public static class Desktop 
    {
        /// <summary>
        /// 
        /// </summary>
        public static class Monitor
        {
            /// <summary>
            /// 
            /// </summary>
            /// <returns>
            /// </returns>
            public static IEnumerable<byte[]> GetEdidDataCollection()
            {
                List<byte[]> result = new List<byte[]>();

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    // To do
                }

                if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    return MacOS.Monitor.GetEdidDataCollection();
                }

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    IEnumerable<Win.MonitorDeviceInfo> deviceMonitors = Win.SafeMonitorNativeMethods.EnumerateMonitorDevices();
                    foreach (Win.MonitorDeviceInfo device in deviceMonitors)
                    {
                        result.Add((byte[])device.Edid.Clone());
                    }
                }

                return result;
            }
        }
    }
}
