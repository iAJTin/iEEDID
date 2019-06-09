﻿
namespace iTin.Core.Interop.Windows.Development.SystemServices.SystemInformation.Firmware
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Functions to handle system firmware tables.
    /// </summary>
    internal static class NativeMethods
    {
        /// <summary>
        /// Enumerates all system firmware tables of the specified type. For more inforation, see https://docs.microsoft.com/es-es/windows/desktop/api/sysinfoapi/nf-sysinfoapi-enumsystemfirmwaretables.
        /// </summary>
        [DllImport(ExternDll.Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int EnumSystemFirmwareTables(KnownProvider firmwareTableProviderSignature, IntPtr firmwareTableBuffer, int bufferSize);

        /// <summary>
        /// Retrieves the specified firmware table from the firmware table provider. For more inforation, see https://docs.microsoft.com/es-es/windows/desktop/api/sysinfoapi/nf-sysinfoapi-getsystemfirmwaretable.
        /// </summary>
        [DllImport(ExternDll.Kernel32, CallingConvention = CallingConvention.Winapi, SetLastError = true)]
        public static extern int GetSystemFirmwareTable(KnownProvider firmwareTableProviderSignature, int firmwareTableId, IntPtr firmwareTableBuffer, int bufferSize);
    }
}
