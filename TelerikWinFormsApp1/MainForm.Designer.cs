namespace TelerikWinFormsApp1
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.richTextEditorRibbonBar1 = new Telerik.WinControls.UI.RichTextEditorRibbonBar();
      this.radRibbonFormBehavior1 = new Telerik.WinControls.UI.RadRibbonFormBehavior();
      this.radRichTextEditorRuler1 = new Telerik.WinControls.UI.RadRichTextEditorRuler();
      this.radRichTextEditor1 = new Telerik.WinControls.UI.RadRichTextEditor();
      this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
      ((System.ComponentModel.ISupportInitialize)(this.richTextEditorRibbonBar1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditorRuler1)).BeginInit();
      this.radRichTextEditorRuler1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditor1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      this.SuspendLayout();
      // 
      // richTextEditorRibbonBar1
      // 
      this.richTextEditorRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView;
      this.richTextEditorRibbonBar1.AssociatedRichTextEditor = this.radRichTextEditor1;
      this.richTextEditorRibbonBar1.BuiltInStylesVersion = Telerik.WinForms.Documents.Model.Styles.BuiltInStylesVersion.Office2013;
      this.richTextEditorRibbonBar1.Location = new System.Drawing.Point(0, 0);
      this.richTextEditorRibbonBar1.Name = "richTextEditorRibbonBar1";
      this.richTextEditorRibbonBar1.Size = new System.Drawing.Size(1145, 165);
      this.richTextEditorRibbonBar1.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("richTextEditorRibbonBar1.StartButtonImage")));
      this.richTextEditorRibbonBar1.TabIndex = 0;
      this.richTextEditorRibbonBar1.TabStop = false;
      this.richTextEditorRibbonBar1.Text = "richTextEditorRibbonBar1";
      this.richTextEditorRibbonBar1.ThemeName = "TelerikMetro";
      // 
      // radRibbonFormBehavior1
      // 
      this.radRibbonFormBehavior1.Form = this;
      // 
      // radRichTextEditorRuler1
      // 
      this.radRichTextEditorRuler1.AssociatedRichTextBox = this.radRichTextEditor1;
      this.radRichTextEditorRuler1.Controls.Add(this.radRichTextEditor1);
      this.radRichTextEditorRuler1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.radRichTextEditorRuler1.Location = new System.Drawing.Point(0, 165);
      this.radRichTextEditorRuler1.Name = "radRichTextEditorRuler1";
      this.radRichTextEditorRuler1.Size = new System.Drawing.Size(1145, 542);
      this.radRichTextEditorRuler1.TabIndex = 1;
      this.radRichTextEditorRuler1.Text = "radRichTextEditorRuler1";
      this.radRichTextEditorRuler1.ThemeName = "TelerikMetro";
      // 
      // radRichTextEditor1
      // 
      this.radRichTextEditor1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
      this.radRichTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.radRichTextEditor1.Location = new System.Drawing.Point(29, 29);
      this.radRichTextEditor1.Name = "radRichTextEditor1";
      this.radRichTextEditor1.SelectionFill = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(190)))));
      this.radRichTextEditor1.SelectionStroke = System.Drawing.Color.LightGray;
      this.radRichTextEditor1.Size = new System.Drawing.Size(1115, 512);
      this.radRichTextEditor1.TabIndex = 0;
      this.radRichTextEditor1.Text = "radRichTextEditor1";
      this.radRichTextEditor1.ThemeName = "TelerikMetro";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1145, 707);
      this.Controls.Add(this.radRichTextEditorRuler1);
      this.Controls.Add(this.richTextEditorRibbonBar1);
      this.FormBehavior = this.radRibbonFormBehavior1;
      this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
      this.Name = "MainForm";
      // 
      // 
      // 
      this.RootElement.ApplyShapeToControl = true;
      this.Text = "richTextEditorRibbonBar1";
      this.ThemeName = "ControlDefault";
      ((System.ComponentModel.ISupportInitialize)(this.richTextEditorRibbonBar1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditorRuler1)).EndInit();
      this.radRichTextEditorRuler1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditor1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Telerik.WinControls.UI.RichTextEditorRibbonBar richTextEditorRibbonBar1;
    private Telerik.WinControls.UI.RadRibbonFormBehavior radRibbonFormBehavior1;
    private Telerik.WinControls.UI.RadRichTextEditorRuler radRichTextEditorRuler1;
    private Telerik.WinControls.UI.RadRichTextEditor radRichTextEditor1;
    private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;



  }
}
