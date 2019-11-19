using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EPPlus.FormulaParsing;
using EPPlus;
using OfficeOpenXml;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"c:\temp\LawsonTemplate2.xlsx";

            FileInfo fi = new FileInfo(path);

            using (ExcelPackage package = new ExcelPackage(fi))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                int rowCount = worksheet.Dimension.End.Row;
                int colCount = worksheet.Dimension.End.Column;

                for (int row = 14; row <= 18; row++)
                {
                    for (int col = 2; col <= colCount; col++)
                    {
                        worksheet.Cells[row, col].Value = row + col;
                    }
                }

                package.Save();
            }
        }
    }
}
