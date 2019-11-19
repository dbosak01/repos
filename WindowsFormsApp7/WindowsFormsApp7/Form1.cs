using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;


namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {

        #region Members

        // Path to Python exe
        string python = @"C:\Program Files (x86)\Microsoft Visual Studio\Shared\Anaconda3_64\python.exe";
        string cmd = @"C:\Windows\System32\cmd.exe";
        // Pointers to IO streams
        IntPtr g_hChildStd_IN_Rd;
        IntPtr g_hChildStd_IN_Wr;
        IntPtr g_hChildStd_OUT_Rd;
        IntPtr g_hChildStd_OUT_Wr;
        IntPtr g_hInputFile;

        private const int BUFSIZE = 4096;
        const int STD_OUTPUT_HANDLE = -11;
        const int STD_INPUT_HANDLE = -10;
        const int STD_ERROR_HANDLE = -12;
        #endregion

        #region Constructors
        public Form1()
        {
            InitializeComponent();
        }

        #endregion


        #region Methods
        public void Setup()
        {


            // Check status along the way
            bool res = true;

            // Initialize security attributes for pipe
            SECURITY_ATTRIBUTES saAttr = new SECURITY_ATTRIBUTES();
            saAttr.length = Marshal.SizeOf(saAttr);
            saAttr.bInheritHandle = true;
            saAttr.lpSecurityDescriptor = IntPtr.Zero;

            // Create pipe for standard out
            res = WindowsProcess.CreatePipe(out g_hChildStd_OUT_Rd, out g_hChildStd_OUT_Wr, ref saAttr, 0);

            // Set inherit flag on output read pipe to not inherit (0)
            res = WindowsProcess.SetHandleInformation(g_hChildStd_OUT_Rd, HANDLE_FLAGS.INHERIT, 0);

            // Create pipe for standard in
            res = WindowsProcess.CreatePipe(out g_hChildStd_IN_Rd, out g_hChildStd_IN_Wr, ref saAttr, 0);

            // Set inherit flag on input write pipe to not inherit (0)
            res = WindowsProcess.SetHandleInformation(g_hChildStd_IN_Wr, HANDLE_FLAGS.INHERIT, 0);

            // Initialize process info
            PROCESS_INFORMATION pi = new PROCESS_INFORMATION() { 
                dwProcessId = 0,
                dwThreadId = 0,
                hProcess = IntPtr.Zero,
                hThread = IntPtr.Zero
            };

            //// Set up members of the STARTUPINFO structure. 
            //// This structure specifies the STDIN and STDOUT handles for redirection.
            // Initialize startup info
            STARTUPINFO si = new STARTUPINFO();
            si.cb = (uint)Marshal.SizeOf(si);
            si.lpReserved = "";
            si.lpDesktop = "";
            si.lpTitle = "";
            si.dwX = 0;
            si.dwY =0;
            si.dwXSize = 0;
            si.dwYSize = 0;
            si.dwXCountChars = 0;
            si.dwYCountChars = 0;
            si.dwFillAttribute = 0;
            si.dwFlags += WindowsProcess.STARTF_USESTDHANDLES;
            si.wShowWindow = 0;
            si.cbReserved2 = 0;
            si.lpReserved2 = IntPtr.Zero;
            si.hStdInput = g_hChildStd_IN_Rd;
            si.hStdOutput = g_hChildStd_OUT_Wr;
            si.hStdError = g_hChildStd_OUT_Wr;


            // Create Python process
            res = WindowsProcess.CreateProcess(cmd, null, IntPtr.Zero, IntPtr.Zero, false, 0, IntPtr.Zero, null, ref si, out pi);

            string tempPath = Path.GetTempFileName();
            g_hInputFile = WindowsProcess.CreateFile(
                tempPath,
                 FileAccess.ReadWrite,
                0,
                IntPtr.Zero,
                 FileMode.OpenOrCreate,
                 FileAttributes.Normal,
                IntPtr.Zero);

            if (g_hInputFile == IntPtr.Zero)
                MessageBox.Show("Something went wrong");

            string b = "echo hello";
            byte[] bytes = Encoding.ASCII.GetBytes(b);
            uint dwRead = (uint)bytes.Length;
            uint dwWritten = 0;
            NativeOverlapped nat = new NativeOverlapped();
            res = WindowsProcess.WriteFile(g_hInputFile, bytes, dwRead, out dwWritten, ref nat);

            WriteToPipe();

            ReadFromPipe();

            WindowsProcess.CloseHandle(g_hInputFile);

            File.Delete(tempPath);
        }

        // Stop when there is no more data. 
        void WriteToPipe()
        {
            bool ret = true;
            string b = "echo hello";
            byte[] bytes = Encoding.ASCII.GetBytes(b);
            uint dwRead = (uint)bytes.Length;
            uint dwWritten = 0;
            IntPtr pDwRead = WindowsProcess.MarshalToPointer(dwRead);
            IntPtr pDwWritten = WindowsProcess.MarshalToPointer(dwWritten);
            byte[] chBuf = new byte[BUFSIZE];
            bool bSuccess = false;
            NativeOverlapped nat = new NativeOverlapped();

            for (; ; )
            {
                bSuccess = WindowsProcess.ReadFile(g_hInputFile, chBuf, BUFSIZE, pDwRead, ref nat);
                if (!bSuccess || dwRead == 0) break;

                ret = WindowsProcess.CloseHandle(g_hInputFile);

                bSuccess = WindowsProcess.WriteFile(g_hChildStd_IN_Wr, chBuf, dwRead, out dwWritten, ref nat);
                int rety = Marshal.GetLastWin32Error();
                if (!bSuccess) break;


                ret = WindowsProcess.CloseHandle(g_hChildStd_IN_Wr);
            }

            // Close the pipe handle so the child process stops reading. 

        }

        // Read output from the child process's pipe for STDOUT
        // and write to the parent process's pipe for STDOUT. 
        // Stop when there is no more data. 
        void ReadFromPipe()
        {
            uint dwRead = 0;
            uint dwWritten = 0;
            byte[] chBuf = new byte[BUFSIZE];
            bool bSuccess = false;
            IntPtr pDwRead = WindowsProcess.MarshalToPointer(dwRead);
            IntPtr pDwWritten = WindowsProcess.MarshalToPointer(dwWritten);
            NativeOverlapped nat = new NativeOverlapped();
            IntPtr pTextBox = txtOutput.Handle;

            for (; ; )
            {
                bSuccess = WindowsProcess.ReadFile(g_hChildStd_OUT_Rd, chBuf, BUFSIZE, pDwRead, ref nat);
                if (!bSuccess || dwRead == 0) break;

                bSuccess = WindowsProcess.WriteFile(pTextBox, chBuf, dwRead, out dwWritten, ref nat);
                if (!bSuccess) break;
            }
        }

        #endregion

        #region Events

        private void btnSetup_Click(object sender, EventArgs e)
        {
            Setup();

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {




        }





        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool res = false;


            // Clean up or risk memory leaks
            res = WindowsProcess.CloseHandle(g_hChildStd_OUT_Rd);
            res = WindowsProcess.CloseHandle(g_hChildStd_OUT_Wr);
        }
    }
}
