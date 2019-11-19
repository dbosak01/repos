//using System;
//using System.Diagnostics;
//using System.Runtime.InteropServices;
//using System.IO;

//public struct PROCESS_INFORMATION
//{
//    public IntPtr hProcess;
//    public IntPtr hThread;
//    public uint dwProcessId;
//    public uint dwThreadId;
//}

//public struct STARTUPINFO
//{
//    public uint cb;
//    public string lpReserved;
//    public string lpDesktop;
//    public string lpTitle;
//    public uint dwX;
//    public uint dwY;
//    public uint dwXSize;
//    public uint dwYSize;
//    public uint dwXCountChars;
//    public uint dwYCountChars;
//    public uint dwFillAttribute;
//    public uint dwFlags;
//    public short wShowWindow;
//    public short cbReserved2;
//    public IntPtr lpReserved2;
//    public IntPtr hStdInput;
//    public IntPtr hStdOutput;
//    public IntPtr hStdError;
//}

//public struct SECURITY_ATTRIBUTES
//{
//    public int length;
//    public IntPtr lpSecurityDescriptor;
//    public bool bInheritHandle;
//}



//public class Program
//{

//    static string python = @"C:\Program Files (x86)\Microsoft Visual Studio\Shared\Anaconda3_64\python.exe";
//    private const int BUFSIZE = 4096;

//    IntPtr g_hChildStd_IN_Rd;
//    IntPtr g_hChildStd_IN_Wr;
//    IntPtr g_hChildStd_OUT_Rd;
//    IntPtr g_hChildStd_OUT_Wr;

//    IntPtr g_hInputFile;

//    const int STD_OUTPUT_HANDLE = -11;
//    const int STD_INPUT_HANDLE = -10;
//    const int STD_ERROR_HANDLE = -12;
//    const Int32 STARTF_USESTDHANDLES = 0x00000100;
//    const uint HANDLE_FLAG_INHERIT = 0x00000001;
//    IntPtr INVALID_HANDLE_VALUE = IntPtr.Zero;

//    public static void Main7()
//    {
//        STARTUPINFO si = new STARTUPINFO();

//        IntPtr a = si.hStdInput;


//        PROCESS_INFORMATION pi = new PROCESS_INFORMATION();
//        CreateProcess(python, null, IntPtr.Zero, IntPtr.Zero, false, 0, IntPtr.Zero, null, ref si, out pi);

//        uint pid = pi.dwProcessId;


//        Console.ReadLine();
//    }


//    public void Main2()
//    {
//        SECURITY_ATTRIBUTES saAttr = new SECURITY_ATTRIBUTES();

//        Console.WriteLine("->Start of parent execution.");

//        // Set the bInheritHandle flag so pipe handles are inherited. 

//        saAttr.length = Marshal.SizeOf(saAttr);
//        saAttr.bInheritHandle = true;
//        saAttr.lpSecurityDescriptor = IntPtr.Zero;

//        // Create a pipe for the child process's STDOUT. 

//        if (!CreatePipe(out g_hChildStd_OUT_Rd, out g_hChildStd_OUT_Wr, ref saAttr, 0))
//            ErrorExit("StdoutRd CreatePipe");

//        // Ensure the read handle to the pipe for STDOUT is not inherited.

//        if (!SetHandleInformation(g_hChildStd_OUT_Rd, HANDLE_FLAGS.INHERIT, 0))
//            ErrorExit("Stdout SetHandleInformation");

//        // Create a pipe for the child process's STDIN. 

//        if (!CreatePipe(out g_hChildStd_IN_Rd, out g_hChildStd_IN_Wr, ref saAttr, 0))
//            ErrorExit("Stdin CreatePipe");

//        // Ensure the write handle to the pipe for STDIN is not inherited. 

//        if (!SetHandleInformation(g_hChildStd_IN_Wr, HANDLE_FLAGS.INHERIT, 0))
//            ErrorExit("Stdin SetHandleInformation");

//        // Create the child process. 

//        CreateChildProcess();

//        // Get a handle to an input file for the parent. 
//        // This example assumes a plain text file and uses string output to verify data flow. 

//        if (argc == 1)
//            ErrorExit("Please specify an input file.\n");

//        g_hInputFile = CreateFile(
//            argv[1],
//            GENERIC_READ,
//            0,
//            NULL,
//            OPEN_EXISTING,
//            FILE_ATTRIBUTE_READONLY,
//            NULL);

//        if (g_hInputFile == INVALID_HANDLE_VALUE)
//            ErrorExit("CreateFile");

//        // Write to the pipe that is the standard input for a child process. 
//        // Data is written to the pipe's buffers, so it is not necessary to wait
//        // until the child process is running before writing data.

//        WriteToPipe();
//        Console.WriteLine("->Contents of {0} written to child STDIN pipe.", argv[1]);

//        // Read from pipe that is the standard output for child process. 

//        Console.WriteLine("->Contents of child process STDOUT: " + argv[1].ToString());
//        ReadFromPipe();

//        Console.WriteLine("->End of parent execution.");

//        // The remaining open handles are cleaned up when this process terminates. 
//        // To avoid resource leaks in a larger application, close handles explicitly. 


//    }

//    void ErrorExit(string msg)
//    {

//        Console.WriteLine(msg);
//        Environment.Exit(1);
//    }

//    void CreateChildProcess()
//    // Create a child process that uses the previously created pipes for STDIN and STDOUT.
//    {
//        string szCmdline = "child";
//        PROCESS_INFORMATION piProcInfo = new PROCESS_INFORMATION();
//        STARTUPINFO siStartInfo = new STARTUPINFO();
//        bool bSuccess = false;

//        // Set up members of the PROCESS_INFORMATION structure. 
//        IntPtr lpProcInfo = IntPtr.Zero;
//        Marshal.PtrToStructure<PROCESS_INFORMATION>(lpProcInfo, piProcInfo);
//        ZeroMemory(lpProcInfo,  Marshal.SizeOf(piProcInfo));

//        // Set up members of the STARTUPINFO structure. 
//        // This structure specifies the STDIN and STDOUT handles for redirection.

//        IntPtr lpStartupInfo = IntPtr.Zero;
//        Marshal.PtrToStructure<STARTUPINFO>(lpStartupInfo, siStartInfo);

//        ZeroMemory(lpStartupInfo, Marshal.SizeOf(STARTUPINFO));
//        siStartInfo.cb = Marshal.SizeOf(siStartInfo);
//        siStartInfo.hStdError = g_hChildStd_OUT_Wr;
//        siStartInfo.hStdOutput = g_hChildStd_OUT_Wr;
//        siStartInfo.hStdInput = g_hChildStd_IN_Rd;
//        siStartInfo.dwFlags |= STARTF_USESTDHANDLES;

//        // Create the child process. 

//        bSuccess = CreateProcess(null,
//           szCmdline,     // command line 
//           null,          // process security attributes 
//           null,          // primary thread security attributes 
//           true,          // handles are inherited 
//           0,             // creation flags 
//           null,          // use parent's environment 
//           null,          // use parent's current directory 
//           siStartInfo,  // STARTUPINFO pointer 
//           piProcInfo);  // receives PROCESS_INFORMATION 

//        // If an error occurs, exit the application. 
//        if (!bSuccess)
//            ErrorExit("CreateProcess");
//        else
//        {
//            // Close handles to the child process and its primary thread.
//            // Some applications might keep these handles to monitor the status
//            // of the child process, for example. 

//            CloseHandle(piProcInfo.hProcess);
//            CloseHandle(piProcInfo.hThread);
//        }
//    }

//    // Read from a file and write its contents to the pipe for the child's STDIN.
//    // Stop when there is no more data. 
//    void WriteToPipe()
//    {
//        uint dwRead, dwWritten;
//        char[] chBuf = new char[BUFSIZE];
//        bool bSuccess = false;

//        for (; ; )
//        {
//            bSuccess = ReadFileScatter(g_hInputFile, chBuf, BUFSIZE, &dwRead, null);
//            if (!bSuccess || dwRead == 0) break;

//            bSuccess = WriteFile(g_hChildStd_IN_Wr, chBuf, dwRead, &dwWritten, null);
//            if (!bSuccess) break;
//        }

//        // Close the pipe handle so the child process stops reading. 

//        if (!CloseHandle(g_hChildStd_IN_Wr))
//            ErrorExit("StdInWr CloseHandle");
//    }


//    // Read output from the child process's pipe for STDOUT
//    // and write to the parent process's pipe for STDOUT. 
//    // Stop when there is no more data. 
//    void ReadFromPipe()
//    {
//        uint dwRead, dwWritten;
//        char[] chBuf = new char[BUFSIZE];
//        bool bSuccess = false;
//        IntPtr hParentStdOut = GetStdHandle(STD_OUTPUT_HANDLE);

//        for (; ; )
//        {
//            bSuccess = ReadFileScatter(g_hChildStd_OUT_Rd, chBuf, BUFSIZE, &dwRead, null);
//            if (!bSuccess || dwRead == 0) break;

//            bSuccess = WriteFile(hParentStdOut, chBuf,
//                                 dwRead, &dwWritten, null);
//            if (!bSuccess) break;
//        }
//    }

//    [DllImport("kernel32.dll")]
//    static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, 
//        IntPtr lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment,
//        string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);

//    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
//    public static extern IntPtr CreateFile(
//     [MarshalAs(UnmanagedType.LPTStr)] string filename,
//     [MarshalAs(UnmanagedType.U4)] FileAccess access,
//     [MarshalAs(UnmanagedType.U4)] FileShare share,
//     IntPtr securityAttributes, // optional SECURITY_ATTRIBUTES struct or IntPtr.Zero
//     [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition,
//     [MarshalAs(UnmanagedType.U4)] FileAttributes flagsAndAttributes,
//     IntPtr templateFile);

//    [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
//    public static extern IntPtr CreateFileA(
//         [MarshalAs(UnmanagedType.LPStr)] string filename,
//         [MarshalAs(UnmanagedType.U4)] FileAccess access,
//         [MarshalAs(UnmanagedType.U4)] FileShare share,
//         IntPtr securityAttributes,
//         [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition,
//         [MarshalAs(UnmanagedType.U4)] FileAttributes flagsAndAttributes,
//         IntPtr templateFile);

//    [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
//    public static extern IntPtr CreateFileW(
//         [MarshalAs(UnmanagedType.LPWStr)] string filename,
//         [MarshalAs(UnmanagedType.U4)] FileAccess access,
//         [MarshalAs(UnmanagedType.U4)] FileShare share,
//         IntPtr securityAttributes,
//         [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition,
//         [MarshalAs(UnmanagedType.U4)] FileAttributes flagsAndAttributes,
//         IntPtr templateFile);


//        [DllImport("kernel32.dll", SetLastError = true)]
//        static extern IntPtr CreateNamedPipe(string lpName, uint dwOpenMode,
//        uint dwPipeMode, uint nMaxInstances, uint nOutBufferSize, uint nInBufferSize,
//        uint nDefaultTimeOut, IntPtr lpSecurityAttributes);

//        [DllImport("kernel32.dll", SetLastError = true)]
//        static extern IntPtr CreateNamedPipe(string lpName, uint dwOpenMode,
//            uint dwPipeMode, uint nMaxInstances, uint nOutBufferSize, uint nInBufferSize,
//            uint nDefaultTimeOut, SECURITY_ATTRIBUTES lpSecurityAttributes);

//        [Flags]
//        public enum PipeOpenModeFlags : uint
//        {
//            PIPE_ACCESS_DUPLEX = 0x00000003,
//            PIPE_ACCESS_INBOUND = 0x00000001,
//            PIPE_ACCESS_OUTBOUND = 0x00000002,
//            FILE_FLAG_FIRST_PIPE_INSTANCE = 0x00080000,
//            FILE_FLAG_WRITE_THROUGH = 0x80000000,
//            FILE_FLAG_OVERLAPPED = 0x40000000//,
//            //WRITE_DAC = 0x00040000L,
//            //WRITE_OWNER = 0x00080000L,
//            //ACCESS_SYSTEM_SECURITY = 0x01000000L
//        }

//        [Flags]
//        public enum PipeModeFlags : uint
//        {
//            //One of the following type modes can be specified. The same type mode must be specified for each instance of the pipe.
//            PIPE_TYPE_BYTE = 0x00000000,
//            PIPE_TYPE_MESSAGE = 0x00000004,
//            //One of the following read modes can be specified. Different instances of the same pipe can specify different read modes
//            PIPE_READMODE_BYTE = 0x00000000,
//            PIPE_READMODE_MESSAGE = 0x00000002,
//            //One of the following wait modes can be specified. Different instances of the same pipe can specify different wait modes.
//            PIPE_WAIT = 0x00000000,
//            PIPE_NOWAIT = 0x00000001,
//            //One of the following remote-client modes can be specified. Different instances of the same pipe can specify different remote-client modes.
//            PIPE_ACCEPT_REMOTE_CLIENTS = 0x00000000,
//            PIPE_REJECT_REMOTE_CLIENTS = 0x00000008
//        }

//        [DllImport("kernel32.dll", SetLastError = true)]
//        static extern bool SetHandleInformation(IntPtr hObject, HANDLE_FLAGS dwMask,
//       HANDLE_FLAGS dwFlags);

//        [Flags]
//        enum HANDLE_FLAGS : uint
//        {
//            None = 0,
//            INHERIT = 1,
//            PROTECT_FROM_CLOSE = 2
//        }

//        [DllImport("kernel32.dll")]
//        static extern bool WriteFile(IntPtr hFile, byte[] lpBuffer,
//           uint nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten,
//           [In] ref System.Threading.NativeOverlapped lpOverlapped);

//        [DllImport("kernel32.dll")]
//        static extern bool ReadFileScatter(IntPtr hFile, FILE_SEGMENT_ELEMENT[]
//           aSegementArray, uint nNumberOfBytesToRead, IntPtr lpReserved,
//           [In] ref System.Threading.NativeOverlapped lpOverlapped);

//        [StructLayout(LayoutKind.Explicit, Size = 8)]
//        internal struct FILE_SEGMENT_ELEMENT
//        {
//            [FieldOffset(0)]
//            public IntPtr Buffer;
//            [FieldOffset(0)]
//            public UInt64 Alignment;
//        }

//        [DllImport("kernel32.dll", SetLastError = true)]
//        static extern IntPtr GetStdHandle(int nStdHandle);

//        [DllImport("kernel32.dll", SetLastError = true)]
//        static extern bool CloseHandle(IntPtr hHandle);

//        [DllImport("Kernel32.dll", EntryPoint = "RtlZeroMemory", SetLastError = false)]
//        static extern void ZeroMemory(IntPtr dest, IntPtr size);

//        [DllImport("kernel32.dll")]
//        static extern bool CreatePipe(out IntPtr hReadPipe, out IntPtr hWritePipe,
//            ref SECURITY_ATTRIBUTES lpPipeAttributes, uint nSize);
//}