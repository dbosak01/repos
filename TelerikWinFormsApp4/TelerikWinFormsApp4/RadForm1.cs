using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TelerikWinFormsApp4
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grid1.Columns.Insert(0);
            grid1.Columns[0].Width = 100;
            grid1.Rows.Insert(0);
            grid1.Rows.Insert(0);

            DevAge.Drawing.RectangleBorder rb = new DevAge.Drawing.RectangleBorder();
            rb.Bottom = new DevAge.Drawing.BorderLine()
            grid1.GetCell(0, 0).View.Border = new 

        }

        private void button4_Click(object sender, EventArgs e)
        {
            arrayGrid1.d
        }
    }
}
