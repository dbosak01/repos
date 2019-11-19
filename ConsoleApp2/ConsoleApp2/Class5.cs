using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace ConsoleTEsting1
{
    class ConsoleRemoteTest
    {

        private static StringBuilder output = new StringBuilder();
        static string python = @"C:\Program Files (x86)\Microsoft Visual Studio\Shared\Anaconda3_64\python.exe";


        public static void Main5()
        {


            ProcessStartInfo psi = new ProcessStartInfo();

            psi.FileName = python;
            //psi.Arguments = python;
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardInput = true;
            //psi.CreateNoWindow = true;

            Process process = new Process();
            process.EnableRaisingEvents = true;
            process.OutputDataReceived += Process_OutputDataReceived;
            process.Exited += Process_Exited;
            process.StartInfo = psi;

            var x = process.Start();

            StreamWriter sw = process.StandardInput;

            //sw.WriteLine("a=1");
            sw.WriteLine("print('hello')");
            //sw.Write(sw.NewLine);

            sw.Flush();
           // process.CloseMainWindow();
            //sw.Close();
            

            process.BeginOutputReadLine();


            //string fork = process.StandardOutput.ReadToEnd();

            process.WaitForExit();


            process.CancelOutputRead();

            //x = process.Start();

            sw = process.StandardInput;

            sw.WriteLine("print('goodbye')");
            sw.WriteLine("print(a)");
            sw.Write(sw.NewLine);

            sw.Close();
            //sw.Flush();

            process.BeginOutputReadLine();

            process.WaitForExit(1000);

            process.CancelOutputRead();

            process.Close();
            process.Dispose();

            Console.Write(sb.ToString());

        }

        private static void Process_Exited(object sender, EventArgs e)
        {
            int i = 0;
        }

        static StringBuilder sb = new StringBuilder();
        private static void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            sb.Append(e.Data);
        }
    }


}
