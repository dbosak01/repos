using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
  public partial class Form1 : Form
  {
    DataSet ds = new DataSet("MyDS");
    public Form1()
    {
      InitializeComponent();
    }

    private void radButton1_Click(object sender, EventArgs e)
    {

      ds.ReadXml(@"C:\Projects2\Archytas\Solutions\Ascend_Legacy\Projects\1024722\Data\1024722.ddp");

      //foreach(DataTable dt in ds.Tables)
      //{
      //  Console.WriteLine(dt.Rows.Count);

      //}

      DataRelation r = new DataRelation("TableFieldRelation", ds.Tables["DictionaryTable"].Columns["Name"], ds.Tables["DictionaryField"].Columns["TableName"]);
      ds.Relations.Add(r);


      //radDropDownList1.DataSource = ds;
      //radDropDownList1.DataMember = "DictionaryTable";
      //radDropDownList1.DisplayMember = "Name";

      ////radGridView1.AutoGenerateHierarchy = true;
      //radGridView1.DataSource = ds;
      //radGridView1.DataMember = "DictionaryField";



      radTreeView1.DataSource = ds;
      radTreeView1.DataMember = "DictionaryTable";
      radTreeView1.DisplayMember = "Name";
      radTreeView1.ChildMember = "DictionaryFields";
      //radTreeView1.ParentMember = "TableName";

    }
  }
}
