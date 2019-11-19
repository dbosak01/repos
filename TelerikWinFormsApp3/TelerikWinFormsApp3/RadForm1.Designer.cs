namespace TelerikWinFormsApp3
{
    partial class RadForm1
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
            Telerik.WinControls.UI.RadTreeNode radTreeNode1 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode2 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode3 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode4 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode5 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode6 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode7 = new Telerik.WinControls.UI.RadTreeNode();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextBox1
            // 
            this.radTextBox1.AllowDrop = true;
            this.radTextBox1.Location = new System.Drawing.Point(74, 67);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(171, 20);
            this.radTextBox1.TabIndex = 0;
            this.radTextBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.radTextBox1_DragEnter);
            // 
            // radTreeView1
            // 
            this.radTreeView1.AllowDrop = true;
            this.radTreeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.radTreeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radTreeView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radTreeView1.ForeColor = System.Drawing.Color.Black;
            this.radTreeView1.Location = new System.Drawing.Point(427, 182);
            this.radTreeView1.Name = "radTreeView1";
            radTreeNode1.Expanded = true;
            radTreeNode1.Name = "Node1";
            radTreeNode2.Name = "Node6";
            radTreeNode2.Text = "Node6";
            radTreeNode3.Name = "Node7";
            radTreeNode3.Text = "Node7";
            radTreeNode1.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode2,
            radTreeNode3});
            radTreeNode1.Text = "Node1";
            radTreeNode4.Expanded = true;
            radTreeNode4.Name = "Node2";
            radTreeNode5.Name = "Node3";
            radTreeNode5.Text = "Node3";
            radTreeNode6.Name = "Node4";
            radTreeNode6.Text = "Node4";
            radTreeNode7.Name = "Node5";
            radTreeNode7.Text = "Node5";
            radTreeNode4.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode5,
            radTreeNode6,
            radTreeNode7});
            radTreeNode4.Text = "Node2";
            this.radTreeView1.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode1,
            radTreeNode4});
            this.radTreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radTreeView1.Size = new System.Drawing.Size(349, 250);
            this.radTreeView1.SpacingBetweenNodes = -1;
            this.radTreeView1.TabIndex = 1;
            this.radTreeView1.DragStarted += new Telerik.WinControls.UI.RadTreeView.DragStartedHandler(this.radTreeView1_DragStarted);
            this.radTreeView1.NodeMouseDown += new Telerik.WinControls.UI.RadTreeView.TreeViewMouseEventHandler(this.radTreeView1_NodeMouseDown);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 641);
            this.Controls.Add(this.radTreeView1);
            this.Controls.Add(this.radTextBox1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadTreeView radTreeView1;
    }
}