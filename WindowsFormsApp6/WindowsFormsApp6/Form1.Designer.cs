namespace WindowsFormsApp6
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
      Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
      this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
      this.radButton1 = new Telerik.WinControls.UI.RadButton();
      this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
      this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
      ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
      this.SuspendLayout();
      // 
      // radGridView1
      // 
      this.radGridView1.Location = new System.Drawing.Point(408, 86);
      // 
      // 
      // 
      this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition4;
      this.radGridView1.Name = "radGridView1";
      this.radGridView1.Size = new System.Drawing.Size(594, 584);
      this.radGridView1.TabIndex = 0;
      // 
      // radButton1
      // 
      this.radButton1.Location = new System.Drawing.Point(736, 27);
      this.radButton1.Name = "radButton1";
      this.radButton1.Size = new System.Drawing.Size(110, 24);
      this.radButton1.TabIndex = 1;
      this.radButton1.Text = "radButton1";
      this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
      // 
      // radTreeView1
      // 
      this.radTreeView1.AllowAdd = true;
      this.radTreeView1.AllowDefaultContextMenu = true;
      this.radTreeView1.AllowEdit = true;
      this.radTreeView1.AllowRemove = true;
      this.radTreeView1.Location = new System.Drawing.Point(12, 86);
      this.radTreeView1.Name = "radTreeView1";
      this.radTreeView1.Size = new System.Drawing.Size(390, 584);
      this.radTreeView1.SpacingBetweenNodes = -1;
      this.radTreeView1.TabIndex = 2;
      // 
      // radDropDownList1
      // 
      this.radDropDownList1.Location = new System.Drawing.Point(176, 27);
      this.radDropDownList1.Name = "radDropDownList1";
      this.radDropDownList1.Size = new System.Drawing.Size(346, 20);
      this.radDropDownList1.TabIndex = 3;
      this.radDropDownList1.Text = "radDropDownList1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1042, 682);
      this.Controls.Add(this.radDropDownList1);
      this.Controls.Add(this.radTreeView1);
      this.Controls.Add(this.radButton1);
      this.Controls.Add(this.radGridView1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Telerik.WinControls.UI.RadGridView radGridView1;
    private Telerik.WinControls.UI.RadButton radButton1;
    private Telerik.WinControls.UI.RadTreeView radTreeView1;
    private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
  }
}

