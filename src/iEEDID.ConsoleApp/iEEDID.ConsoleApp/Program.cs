
using System.Text;
using Win32 = Microsoft.Win32;

namespace iEEDID.ConsoleApp
{
    using System;
    using System.Runtime.InteropServices;

    class Program
    {
        // Invoke methods
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", SetLastError = true)]
        internal static extern int DeviceIoControlCE(int hDevice, int dwIoControlCode, byte[] lpInBuffer,
            int nInBufferSize, byte[] lpOutBuffer, int nOutBufferSize, ref int lpBytesReturned, IntPtr lpOverlapped);

        [DllImport("kernel32", SetLastError = true)]
        private static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode,
            IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle(IntPtr hObject);

        // Found on pinvoke.net
        public const UInt32 GENERIC_ALL = 0x10000000;
        public const UInt32 GENERIC_READ = 0x80000000;
        public const UInt32 GENERIC_WRITE = 0x40000000;
        public const UInt32 GENERIC_EXECUTE = 0x20000000;
        public const UInt32 FILE_SHARE_READ = 1;
        public const UInt32 FILE_SHARE_WRITE = 2;
        public const UInt32 OPEN_EXISTING = 3;

        // Found with I2C driver
        public const Int32 IOCTL_I2C_READ = 262144;
        public const Int32 IOCTL_I2C_WRITE = 262148;
        public const Int32 IOCTL_I2C_GET_FASTCALL = 262152;

        /// <summary>
        /// Struct for I2C driver
        /// </summary>
        unsafe struct _I2C_IO_DESC
        {
            public UInt32 SlaveAddr; // Target Slave Address
            public byte WordAddr; // Starting Slave Word Address
            public byte* Data; // pBuffer
            public UInt32 Count; // nBytes to read/write
        }

        /// <summary>
        /// I2C Handler
        /// </summary>
        private static IntPtr _i2cFile;

        // Migth be useless
        static int _rCount = 0;

        static void Main(string[] args)
        {
            //ReadEdid(0xa1);
            Foo();
        }

        private static void OpenHandle0()
        {
            // Open the channel 0
            _i2cFile =
                CreateFile(
                    "I2C0:",
                    GENERIC_READ | GENERIC_WRITE,
                    FILE_SHARE_READ | FILE_SHARE_WRITE,
                    IntPtr.Zero,
                    OPEN_EXISTING,
                    0,
                    IntPtr.Zero);
        }

        private static void CloseHandle0()
        {
            CloseHandle(_i2cFile);
        }

        private static void ReadEdid(uint address)
        {
            unsafe
            {
                byte[] data = new byte[16];

                fixed (byte* p = data) //Make sure that garbage collector won't move the data 
                {
                    _I2C_IO_DESC i2CMsg;
                    i2CMsg.SlaveAddr = address; // 0xA1; // Eeprom Adress
                    i2CMsg.WordAddr = 0x00;     // Start Adress
                    i2CMsg.Count = 16;          // Nb of byte to read
                    i2CMsg.Data = p;            // Pointer

                    byte[] buffer = ObjectToByteArray(i2CMsg);
                    OpenHandle0();
                    DeviceIoControlCE(
                        (int) _i2cFile,
                        IOCTL_I2C_READ,
                        buffer,
                        buffer.Length,
                        buffer,
                        0,
                        ref _rCount,
                        IntPtr.Zero);

                    CloseHandle0();

                    _I2C_IO_DESC i2cRead = ByteArrayToObject<_I2C_IO_DESC>(buffer);

                    //*****At this point, "data" contains the content of the eeprom*****
                    var aa = ObjectToByteArray(i2cRead);
                }
            }
        }

        /// <summary>
        /// Convert an object to a byte array. Will not work with dynamic size object This method is based from an example on codeproject.com (http: //www.codeproject.com/KB/cs/C__Poiter.aspx)
        /// </summary>
        /// <param name="obj">Object to convert</param>
        /// <returns>Array of bytes</returns>
        public static byte[] ObjectToByteArray(object obj)
        {
            int Length = Marshal.SizeOf(obj);
            byte[] byteArray = new byte[Length];
            IntPtr ptr = Marshal.AllocHGlobal(Length);
            Marshal.StructureToPtr(obj, ptr, false);
            Marshal.Copy(ptr, byteArray, 0, Length);
            Marshal.FreeHGlobal(ptr);
            return byteArray;
        }

        /// <summary>
        /// Convert a byte array to an object of type T. Will not work with dynamic size object  This method is based from an example on codeproject.com (http://www.codeproject.com/KB/cs/C__Poiter.aspx)
        /// </summary>
        /// <typeparam name="T">Type of the returned object</typeparam>
        /// <param name="byteArray">Byte array to convert</param>
        /// <returns>Object from byte array</returns>
        public static T ByteArrayToObject<T>(byte[] byteArray)
        {
            T obj;
            int Length = Marshal.SizeOf(typeof(T));
            IntPtr ptr = Marshal.AllocHGlobal(Length);
            Marshal.Copy(byteArray, 0, ptr, Length);
            obj = (T) Marshal.PtrToStructure(ptr, typeof(T));
            Marshal.FreeHGlobal(ptr);
            return obj;
        }


        private static void Foo()
        {
            Guid DisplayGUID = new Guid(Bar.GUID_DEVINTERFACE_MONITOR);

            IntPtr displaysHandle = Bar.SetupDiGetClassDevs(ref DisplayGUID, null, IntPtr.Zero, (uint) (0x00000002 | 0x00000010)); //Win32.DIGCF_PRESENT | Win32.DIGCF_DEVICEINTERFACE));

            Bar.SP_DEVICE_INTERFACE_DATA Data = new Bar.SP_DEVICE_INTERFACE_DATA();
            Data.cbSize = Marshal.SizeOf(Data);

            for (uint id = 0; Bar.SetupDiEnumDeviceInterfaces(displaysHandle, IntPtr.Zero, ref DisplayGUID, id, ref Data); id++)
            {
                Bar.SP_DEVINFO_DATA SPDID = new Bar.SP_DEVINFO_DATA();
                SPDID.cbSize = (uint)Marshal.SizeOf(SPDID);

                Bar.SP_DEVICE_INTERFACE_DETAIL_DATA NDIDD = new Bar.SP_DEVICE_INTERFACE_DETAIL_DATA();

                if (IntPtr.Size == 8) //64 bit
                {
                    NDIDD.cbSize = 8;
                }
                else //32 bit
                {
                    NDIDD.cbSize = 4 + Marshal.SystemDefaultCharSize;
                }

                uint requiredsize = 0;
                uint buffer = Bar.BUFFER_SIZE;

                if (Bar.SetupDiGetDeviceInterfaceDetail(displaysHandle, ref Data, ref NDIDD, buffer, ref requiredsize, ref SPDID))
                {
                    StringBuilder IDBuffer = new StringBuilder((int)buffer);
                    Bar.CM_Get_Device_ID(SPDID.DevInst, IDBuffer, (int)buffer);

                    Console.WriteLine("InstanceID: {0}", IDBuffer);
                    Console.WriteLine("DevicePath: {0}\n", NDIDD.DevicePath);

                    //uint size = 0;
                    //Bar.CM_Get_Device_ID_Size(out size, SPDID.DevInst);

                    ////IntPtr ptrInstanceBuf = Marshal.AllocHGlobal((int)size);

                    ////Bar.CM_Get_Device_ID(SPDID.DevInst, ref ptrInstanceBuf, size);

                    //string InstanceID = Marshal.PtrToStringAuto(ptrInstanceBuf);

                    //Console.WriteLine("InstanceID: {0}", InstanceID);

                    //Marshal.FreeHGlobal(ptrInstanceBuf);

                    //Console.WriteLine("DevicePath: {0}\n", NDIDD.DevicePath);
                }
            }

            Bar.SetupDiDestroyDeviceInfoList(displaysHandle);
        }

        private class Bar
        {
            [DllImport("setupapi.dll", CharSet = CharSet.Auto)]
            public static extern IntPtr SetupDiGetClassDevs(ref Guid ClassGuid, [MarshalAs(UnmanagedType.LPTStr)] string Enumerator, IntPtr hwndParent, uint Flags);

            [DllImport("setupapi.dll", SetLastError = true)]
            public static extern bool SetupDiDestroyDeviceInfoList(IntPtr DeviceInfoSet);

            [DllImport(@"setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern Boolean SetupDiEnumDeviceInterfaces(IntPtr hDevInfo, IntPtr devInfo, ref Guid interfaceClassGuid, UInt32 memberIndex, ref SP_DEVICE_INTERFACE_DATA deviceInterfaceData);

            [DllImport(@"setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern Boolean SetupDiGetDeviceInterfaceDetail(IntPtr hDevInfo, ref SP_DEVICE_INTERFACE_DATA deviceInterfaceData, ref SP_DEVICE_INTERFACE_DETAIL_DATA deviceInterfaceDetailData, UInt32 deviceInterfaceDetailDataSize, ref UInt32 requiredSize, ref SP_DEVINFO_DATA deviceInfoData);

            //[DllImport("setupapi.dll", SetLastError = true)]
            //public static extern int CM_Get_Device_ID_Size(out uint pulLen, UInt32 dnDevInst, int flags = 0);

            [DllImport("setupapi.dll", SetLastError = true)]
            public static extern int CM_Get_Device_ID(uint dnDevInst, StringBuilder Buffer, int BufferLen, int ulFlags = 0);

            [DllImport("setupapi.dll", SetLastError = true)]
            public static extern int CM_Get_Device_ID(uint dnDevInst, ref IntPtr Buffer, uint BufferLen, int ulFlags = 0);

            public const int BUFFER_SIZE = 168; //guess

            public const string GUID_DEVINTERFACE_MONITOR = "{E6F07B5F-EE97-4a90-B076-33F57BF4EAA7}";

            [Flags]
            public enum DiGetClassFlags : uint
            {
                DIGCF_DEFAULT = 0x00000001,  // only valid with DIGCF_DEVICEINTERFACE
                DIGCF_PRESENT = 0x00000002,
                DIGCF_ALLCLASSES = 0x00000004,
                DIGCF_PROFILE = 0x00000008,
                DIGCF_DEVICEINTERFACE = 0x00000010,
            }

            [StructLayout(LayoutKind.Sequential)]
            public struct SP_DEVICE_INTERFACE_DATA
            {
                public Int32 cbSize;
                public Guid interfaceClassGuid;
                public Int32 flags;
                private UIntPtr reserved;
            }

            [StructLayout(LayoutKind.Sequential)]
            public struct SP_DEVINFO_DATA
            {
                public uint cbSize;
                public Guid classGuid;
                public uint DevInst;
                public IntPtr reserved;
            }

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
            public struct SP_DEVICE_INTERFACE_DETAIL_DATA
            {
                public int cbSize;
                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = BUFFER_SIZE)]
                public string DevicePath;
            }
        }
    }
}
