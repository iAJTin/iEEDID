
namespace iTin.Hardware.Abstractions
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;

    using iTin.Core.ComponentModel.Enums;
    using iTin.Core.Hardware.Windows.Device.Desktop.Monitor;

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
                    // Nothing to do
                }

                if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    var startInfo = new ProcessStartInfo()
                    {
                        FileName = MacProgram.IoReg.ToString(),
                        Arguments = "-lw0 -r -c \"IODisplayConnect\" -n \"display0\" -d 2 | grep IODisplayEDID",
                        UseShellExecute = false,
                        CreateNoWindow = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    };

                    var process = new Process()
                    {
                        StartInfo = startInfo
                    };

                    List<string> ioDisplayEdidItems = new List<string>();
                    process.OutputDataReceived += (sender, data) =>
                    {
                        if (data != null)
                        {
                            if (data.Data != null)
                            {
                                if (data.Data.Contains("\"IODisplayEDID\" = <"))
                                {
                                    string[] splitted = data.Data.Split(new[] { "\"IODisplayEDID\" = " }, StringSplitOptions.RemoveEmptyEntries);
                                    string rawEdid = splitted[1].Replace("<", string.Empty).Replace(">", string.Empty);
                                    ioDisplayEdidItems.Add(rawEdid);
                                }
                            }
                        }
                    };

                    process.ErrorDataReceived += (sender, data) =>
                    {
                    };

                    try
                    {
                        process.Start();
                        process.BeginOutputReadLine();
                        process.BeginErrorReadLine();
                        process.WaitForExit();
                    }
                    catch (Exception ex)
                    {
                    }

                    foreach (var ioDisplayEdid in ioDisplayEdidItems)
                    {
                        var item = new List<byte>();
                        for (int i = 0; i <= ioDisplayEdid.Length - 1; i += 2)
                        {
                            item.Add(Convert.ToByte(ioDisplayEdid.Substring(i, 2), 16));
                        }

                        result.Add(item.ToArray());
                    }

                }

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    IEnumerable<MonitorDeviceInfo> deviceMonitors = SafeMonitorNativeMethods.EnumerateMonitorDevices();
                    foreach (MonitorDeviceInfo device in deviceMonitors)
                    {
                        result.Add((byte[])device.Edid.Clone());
                    }
                }

                return result;
            }
        }
    }
}
