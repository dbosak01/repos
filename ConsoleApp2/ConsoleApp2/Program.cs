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
    class StandardAsyncOutputExample
    {
        private static int lineCount = 0;
        private static StringBuilder output = new StringBuilder();
        static string python = @"C:\Program Files (x86)\Microsoft Visual Studio\Shared\Anaconda3_64\python.exe";


        public static void Main2()
        {
            Process process = new Process();
            process.StartInfo.FileName = python;

            //string temp = Path.GetTempFileName();
            //File.WriteAllText(temp, "print('fork')");
            //process.StartInfo.Arguments = temp;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                // Prepend line numbers to each line of the output.
                if (!String.IsNullOrEmpty(e.Data))
                {
                    lineCount++;
                    output.Append("\n[" + lineCount + "]: " + e.Data);
                }
            });



            Process.Start(python);
            Console.WriteLine("\n\nPress x key to exit.");


            while (1==1)
            { 


            string command = Console.ReadLine();

                if (command == "x")
                    break;
            output.Clear();

            //File.WriteAllText(temp, command);
                process.StandardInput.WriteLine(command);

                process.StandardInput.Flush();
                // Asynchronously read the standard output of the spawned process. 
                // This raises OutputDataReceived events for each line of output.
                process.BeginOutputReadLine();
            process.WaitForExit();

            // Write the redirected output to this application's window.
            Console.WriteLine(output);
            process.CancelOutputRead();






            }

            process.WaitForExit();
            process.Close();
   

        }
    }


}
