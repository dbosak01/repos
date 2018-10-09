using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinForms.Documents.FormatProviders.OpenXml.Docx;
using TelerikWinFormsApp1.Properties;

namespace TelerikWinFormsApp1
{
  public partial class MainForm : Telerik.WinControls.UI.RadForm
  {
    public MainForm()
    {
      InitializeComponent();

      //Allow the ribbon bar in the form's title bar
      (this.FormBehavior as Telerik.WinControls.UI.RadRibbonFormBehavior).AllowTheming = false;

      DocxFormatProvider provider = new DocxFormatProvider();
      radRichTextEditor1.Document = provider.Import(Resources.SampleDoc);
    }
  }
}
