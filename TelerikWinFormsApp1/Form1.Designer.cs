namespace TelerikWinFormsApp1
{
  partial class Form1
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
      this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
      this.radChat1 = new Telerik.WinControls.UI.RadChat();
      ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radChat1)).BeginInit();
      this.SuspendLayout();
      // 
      // radDropDownList1
      // 
      this.radDropDownList1.Location = new System.Drawing.Point(77, 12);
      this.radDropDownList1.Name = "radDropDownList1";
      this.radDropDownList1.Size = new System.Drawing.Size(125, 20);
      this.radDropDownList1.TabIndex = 0;
      this.radDropDownList1.Text = "radDropDownList1";
      // 
      // radChat1
      // 
      this.radChat1.Location = new System.Drawing.Point(48, 153);
      this.radChat1.Name = "radChat1";
      this.radChat1.Size = new System.Drawing.Size(675, 227);
      this.radChat1.TabIndex = 1;
      this.radChat1.Text = "radChat1";
      this.radChat1.TimeSeparatorInterval = System.TimeSpan.Parse("1.00:00:00");
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.radChat1);
      this.Controls.Add(this.radDropDownList1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radChat1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
    private Telerik.WinControls.UI.RadChat radChat1;
  }
}