using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApp7
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];
            TcpClient client = new TcpClient("localhost", 6000);

            int byteCount = Encoding.ASCII.GetByteCount(txtInput.Text);

            byte[] sendData = new byte[byteCount];

            sendData = Encoding.ASCII.GetBytes(txtInput.Text);

            NetworkStream stream = client.GetStream();

            stream.Write(sendData, 0, byteCount);

            stream.Close();

            client.Close();

        }
    }
}
