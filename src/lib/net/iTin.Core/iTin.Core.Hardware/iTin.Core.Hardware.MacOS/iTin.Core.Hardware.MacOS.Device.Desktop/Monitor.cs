
namespace iTin.Core.Hardware.MacOS.Device.Desktop
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    using iTin.Core.ComponentModel.Enums;

    /// <summary>
    /// Defines 
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

            var startInfo = new ProcessStartInfo()
            {
                FileName = MacProgram.IoReg.ToString(),
                /*Arguments = "-lw0 -r -c \"IODisplayConnect\" -n \"display0\" -d 2 | grep IODisplayEDID",*/
                Arguments = "-lw0 -r -c \"AppleSMBIOS\"",
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
