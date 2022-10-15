
using System.Collections.Generic;
using System.Runtime.InteropServices;

using Linux = iTin.Core.Hardware.Linux.Device.Desktop;
using MacOS = iTin.Core.Hardware.MacOS.Device.Desktop;
using Win = iTin.Core.Hardware.Windows.Device.Desktop.Monitor;

namespace iTin.Hardware.Abstractions.Devices
{
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
                var result = new List<byte[]>();

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    return Linux.Monitor.GetEdidDataCollection();
                }

                if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    return MacOS.Monitor.GetEdidDataCollection();
                }

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    var deviceMonitors = Win.SafeMonitorNativeMethods.EnumerateMonitorDevices();
                    foreach (var device in deviceMonitors)
                    {
                        result.Add((byte[])device.Edid.Clone());
                    }
                }

                return result;
            }
        }
    }
}
