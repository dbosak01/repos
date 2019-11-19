using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Class6
    {
        static string python = @"C:\Progra~2\Micros~1\Shared\Anaconda3_64\python.exe";
        static string cmd = @"c:\Windows\System32\cmd.exe";


        public static void Main6()
        {

            Process p = new Process();
            p.StartInfo.FileName = cmd;
            //p.StartInfo.Arguments = @" > c:\temp\Test1.txt";
            //string tmp = Path.GetTempFileName();
            //File.WriteAllText(tmp, "a=1");
            //p.StartInfo.Arguments = tmp;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            var a = p.Start();


            StreamWriter sw = p.StandardInput;
            //sw.Write("print('hello')");



            sw.Write("echo hello");


            sw.Flush();
            

            string one = p.StandardOutput.ReadToEnd();

            sw.Write("echo goodbye");
            //t.Start();

            sw.Flush();

            string two = p.StandardOutput.ReadToEnd();
            



            sw.Close();


            //Console.WriteLine(p.StandardOutput.ReadToEnd());


            p.WaitForExit();

        }

    }
}
