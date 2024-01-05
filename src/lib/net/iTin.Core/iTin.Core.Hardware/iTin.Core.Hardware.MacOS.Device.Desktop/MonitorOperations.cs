
using System;
using System.Collections.Generic;
using System.Diagnostics;

using iTin.Core.Hardware.Abstractions.Devices.Desktop.Monitor;
using iTin.Core.Interop.Shared.MacOS;

namespace iTin.Core.Hardware.MacOS.Device.Desktop
{
    /// <summary>
    /// Specialization of the <see cref="IMonitorOperations"/> interface that contains the <strong>Monitor</strong> operations for <strong>MacOS</strong> system.
    /// </summary>
    public class MonitorOperations : IMonitorOperations
    {
        /// <summary>
        /// Gets a value containing the raw <strong>EDID</strong> data.
        /// </summary>
        /// <returns>
        /// The raw <strong>EDID</strong> data.
        /// </returns>
        public IEnumerable<byte[]> GetEdidDataCollection()
        {
            var result = new List<byte[]>();

            var startInfo = new ProcessStartInfo
            {
                FileName = Command.IoReg.ToString(),
                Arguments = "-lw0 -r -c \"IODisplayConnect\" -n \"display0\" -d 2 | grep IODisplayEDID",
                UseShellExecute = false,
                CreateNoWindow = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            var process = new Process
            {
                StartInfo = startInfo
            };

            var ioDisplayEdidItems = new List<string>();
            process.OutputDataReceived += (sender, data) =>
            {
                if (data?.Data == null)
                {
                    return;
                }

                if (!data.Data.Contains("\"IODisplayEDID\" = <"))
                {
                    return;
                }

                var splitted = data.Data.Split(new[] { "\"IODisplayEDID\" = " }, StringSplitOptions.RemoveEmptyEntries);
                var rawEdid = splitted[1].Replace("<", string.Empty).Replace(">", string.Empty);
                ioDisplayEdidItems.Add(rawEdid);
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
            catch 
            {
            }

            foreach (var ioDisplayEdid in ioDisplayEdidItems)
            {
                var item = new List<byte>();
                for (int i = 0; i <= ioDisplayEdid.Length - 1; i += 2)
                {
                    item.Add(Convert.ToByte(ioDisplayEdid.Substring(i, 2), 16));
                }

                result.Add((byte[])item.ToArray().Clone());
            }

            return result;
        }
    }
}
