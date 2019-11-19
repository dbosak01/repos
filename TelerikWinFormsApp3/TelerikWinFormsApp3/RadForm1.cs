using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TelerikWinFormsApp3
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();

            radTextBox1.DragDrop += RadTextBox1_DragDrop;
        }

        private void RadTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            radTextBox1.Text = e.Data.ToString();
        }

        private void radTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void radTreeView1_DragStarted(object sender, Telerik.WinControls.UI.RadTreeViewDragEventArgs e)
        {

        }

        private void radTreeView1_NodeMouseDown(object sender, Telerik.WinControls.UI.RadTreeViewMouseEventArgs e)
        {
            radTreeView1.DoDragDrop("Fork", DragDropEffects.Copy);
        }
    }
}
