using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace ConsoleApp2
{
    class Class8
    {

        public static void Main8()
        {
            string python = @"C:\Progra~2\Micros~1\Shared\Anaconda3_64\python.exe";

            //Create process
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();

            //strCommand is path and file name of command to run
            pProcess.StartInfo.FileName = python;

            //strCommandParameters are parameters to pass to program
            pProcess.StartInfo.Arguments = @"c:\temp\Test3.txt";

            pProcess.StartInfo.UseShellExecute = false;

            //Set output of program to be written to process output stream
            pProcess.StartInfo.RedirectStandardOutput = true;

            //Optional
            //pProcess.StartInfo.WorkingDirectory = strWorkingDirectory;

            File.WriteAllText(@"c:\temp\Test3.txt", "a=1");

            //Start the process
            pProcess.Start();

            //Get program output

            string strOutput = pProcess.StandardOutput.ReadToEnd();

            //Wait for process to finish
            pProcess.WaitForExit();

            File.WriteAllText(@"c:\temp\Test3.txt", "print(a)");
            //Start the process
            pProcess.Start();

            //Get program output
            strOutput = pProcess.StandardOutput.ReadToEnd();

            //Wait for process to finish
            pProcess.WaitForExit();

        }

    }
}
