using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TelerikWinFormsApp2
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {

            string txt = File.ReadAllText(@"C:\Users\dbosa\source\repos\TelerikWinFormsApp2\TelerikWinFormsApp2\TextFile1.py");
            syntaxEditor1.Document.AppendText(txt);


        }



        private void radButton2_Click(object sender, EventArgs e)
        {
            // full path of python interpreter  
            string python = @"C:\Program Files (x86)\Microsoft Visual Studio\Shared\Anaconda3_64\python.exe";

            // python app to call  
            string myPythonApp = @"C:\Users\dbosa\source\repos\TelerikWinFormsApp2\TelerikWinFormsApp2\TextFile1.py";

            // dummy parameters to send Python script  
            int x = 2;
            int y = 5;

            // Create new process start info 
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(python);

            // make sure we can read the output from stdout 
            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardOutput = true;

            // start python app with 3 arguments  
            // 1st argument is pointer to itself, 2nd and 3rd are actual arguments we want to send 
            myProcessStartInfo.Arguments = myPythonApp + " " + x + " " + y;

            Process myProcess = new Process();
            // assign start information to the process 
            myProcess.StartInfo = myProcessStartInfo;

            // start process 
            myProcess.Start();

            // Read the standard output of the app we called.  
            StreamReader myStreamReader = myProcess.StandardOutput;
            string myString = myStreamReader.ReadLine();

            // wait exit signal from the app we called 
            myProcess.WaitForExit();

            // close the process 
            myProcess.Close();

            // write the output we got from python app 
            radTextBox1.Text = "Value received from script: " + myString;
        }
    }
}
