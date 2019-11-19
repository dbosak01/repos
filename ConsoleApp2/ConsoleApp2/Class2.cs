using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {

        static void Main5(string[] args)
        {

            var x = new ConsoleAppManager("cmd.exe");
            x.StandartTextReceived += X_StandartTextReceived;
            x.WriteLine("dir");
            x.ExecuteAsync("dir");


            //var cmd = new Process
            //{
            //    StartInfo = new ProcessStartInfo("cmd.exe")
            //    {
            //        CreateNoWindow = true,
            //        UseShellExecute = false,
            //        RedirectStandardInput = true,
            //        RedirectStandardOutput = true,
            //        RedirectStandardError = true
            //    }
            //};
            //cmd.Start();

            //StreamPipe pout = new StreamPipe(cmd.StandardOutput.BaseStream, Console.OpenStandardOutput());
            //StreamPipe perr = new StreamPipe(cmd.StandardError.BaseStream, Console.OpenStandardError());
            //StreamPipe pin = new StreamPipe(Console.OpenStandardInput(), cmd.StandardInput.BaseStream);

            //pin.Connect();
            //pout.Connect();
            //perr.Connect();

            //cmd.WaitForExit();
        }

        private static void X_StandartTextReceived(object sender, string e)
        {
            Console.WriteLine(e);
        }
    }

    class StreamPipe
    {
        private const Int32 BufferSize = 4096;

        public Stream Source { get; protected set; }
        public Stream Destination { get; protected set; }

        private CancellationTokenSource _cancellationToken;
        private Task _worker;

        public StreamPipe(Stream source, Stream destination)
        {
            Source = source;
            Destination = destination;
        }

        public StreamPipe Connect()
        {
            _cancellationToken = new CancellationTokenSource();
            _worker = Task.Run(async () =>
            {
                byte[] buffer = new byte[BufferSize];
                while (true)
                {
                    _cancellationToken.Token.ThrowIfCancellationRequested();
                    var count = await Source.ReadAsync(buffer, 0, BufferSize, _cancellationToken.Token);
                    if (count <= 0)
                        break;
                    await Destination.WriteAsync(buffer, 0, count, _cancellationToken.Token);
                    await Destination.FlushAsync(_cancellationToken.Token);
                }
            }, _cancellationToken.Token);
            return this;
        }

        public void Disconnect()
        {
            _cancellationToken.Cancel();
        }
    }
}