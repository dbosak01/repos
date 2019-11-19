using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    #region Members

    #endregion

    #region Structs
    public struct PROCESS_INFORMATION
    {

        public IntPtr hProcess;
        public IntPtr hThread;
        public uint dwProcessId;
        public uint dwThreadId;
    }

    public struct STARTUPINFO
    {
        public uint cb;
        public string lpReserved;
        public string lpDesktop;
        public string lpTitle;
        public uint dwX;
        public uint dwY;
        public uint dwXSize;
        public uint dwYSize;
        public uint dwXCountChars;
        public uint dwYCountChars;
        public uint dwFillAttribute;
        public uint dwFlags;
        public short wShowWindow;
        public short cbReserved2;
        public IntPtr lpReserved2;
        public IntPtr hStdInput;
        public IntPtr hStdOutput;
        public IntPtr hStdError;
    }

    public struct SECURITY_ATTRIBUTES
    {
        public int length;
        public IntPtr lpSecurityDescriptor;
        public bool bInheritHandle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct FILE_SEGMENT_ELEMENT
    {
        [FieldOffset(0)]
        public IntPtr Buffer;
        [FieldOffset(0)]
        public UInt64 Alignment;
    }
    #endregion

    #region Enums
    [Flags]
    public enum HANDLE_FLAGS : uint
    {
        None = 0,
        INHERIT = 1,
        PROTECT_FROM_CLOSE = 2
    }

    [Flags]
    public enum PipeModeFlags : uint
    {
        //One of the following type modes can be specified. The same type mode must be specified for each instance of the pipe.
        PIPE_TYPE_BYTE = 0x00000000,
        PIPE_TYPE_MESSAGE = 0x00000004,
        //One of the following read modes can be specified. Different instances of the same pipe can specify different read modes
        PIPE_READMODE_BYTE = 0x00000000,
        PIPE_READMODE_MESSAGE = 0x00000002,
        //One of the following wait modes can be specified. Different instances of the same pipe can specify different wait modes.
        PIPE_WAIT = 0x00000000,
        PIPE_NOWAIT = 0x00000001,
        //One of the following remote-client modes can be specified. Different instances of the same pipe can specify different remote-client modes.
        PIPE_ACCEPT_REMOTE_CLIENTS = 0x00000000,
        PIPE_REJECT_REMOTE_CLIENTS = 0x00000008
    }
    #endregion


    public class WindowsProcess
    {

        #region Members
        private const int BUFSIZE = 4096;
        public const Int32 STARTF_USESTDHANDLES = 0x00000100;
        #endregion

        #region Methods


        [DllImport("kernel32.dll")]
        public static extern bool CreatePipe(out IntPtr hReadPipe, out IntPtr hWritePipe,
            ref SECURITY_ATTRIBUTES lpPipeAttributes, uint nSize);


        [DllImport("kernel32.dll")]
        public static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes,
            IntPtr lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment,
            string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CloseHandle(IntPtr hHandle);


        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetHandleInformation(IntPtr hObject, HANDLE_FLAGS dwMask, HANDLE_FLAGS dwFlags);

        [DllImport("Kernel32.dll", EntryPoint = "RtlZeroMemory", SetLastError = false)]
        public static extern void ZeroMemory(IntPtr dest, IntPtr size);

        [DllImport("Kernel32.dll", EntryPoint = "RtlSecureZeroMemory", SetLastError = false)]
        public static extern void SecureZeroMemory(IntPtr dest, IntPtr size);


        public static IntPtr MarshalToPointer(object data)
        {
            IntPtr buf = Marshal.AllocHGlobal(
                Marshal.SizeOf(data));
            Marshal.StructureToPtr(data,
                buf, false);
            return buf;
        }


        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CreateFile(
             [MarshalAs(UnmanagedType.LPTStr)] string filename,
             [MarshalAs(UnmanagedType.U4)] FileAccess access,
             [MarshalAs(UnmanagedType.U4)] FileShare share,
             IntPtr securityAttributes, // optional SECURITY_ATTRIBUTES struct or IntPtr.Zero
             [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition,
             [MarshalAs(UnmanagedType.U4)] FileAttributes flagsAndAttributes,
             IntPtr templateFile);

        [DllImport("kernel32.dll")]
        public static extern bool WriteFile(IntPtr hFile, byte[] lpBuffer,
           uint nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten,
           [In] ref System.Threading.NativeOverlapped lpOverlapped);

        [DllImport("kernel32.dll")]
        public static extern bool ReadFile(IntPtr hFile, byte[] lpBuffer,
           uint nNumberOfBytesToRead, IntPtr lpNumberOfBytesRead,
           [In] ref System.Threading.NativeOverlapped lpOverlapped);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetStdHandle(int nStdHandle);

        #endregion
    }
}
