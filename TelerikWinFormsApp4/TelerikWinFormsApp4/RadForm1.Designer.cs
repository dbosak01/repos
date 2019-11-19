namespace TelerikWinFormsApp4
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
            SourceGrid.Extensions.PingGrids.EmptyPingSource emptyPingSource3 = new SourceGrid.Extensions.PingGrids.EmptyPingSource();
            this.arrayGrid1 = new SourceGrid.ArrayGrid();
            this.grid1 = new SourceGrid.Grid();
            this.dataGrid1 = new SourceGrid.DataGrid();
            this.pingGrid1 = new SourceGrid.Extensions.PingGrids.PingGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // arrayGrid1
            // 
            this.arrayGrid1.EnableSort = true;
            this.arrayGrid1.Location = new System.Drawing.Point(425, 50);
            this.arrayGrid1.Name = "arrayGrid1";
            this.arrayGrid1.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.arrayGrid1.Size = new System.Drawing.Size(200, 100);
            this.arrayGrid1.TabIndex = 0;
            this.arrayGrid1.TabStop = true;
            this.arrayGrid1.ToolTipText = "";
            // 
            // grid1
            // 
            this.grid1.EnableSort = true;
            this.grid1.Location = new System.Drawing.Point(425, 193);
            this.grid1.Name = "grid1";
            this.grid1.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid1.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid1.Size = new System.Drawing.Size(200, 100);
            this.grid1.TabIndex = 1;
            this.grid1.TabStop = true;
            this.grid1.ToolTipText = "";
            // 
            // dataGrid1
            // 
            this.dataGrid1.DeleteQuestionMessage = "Are you sure to delete all the selected rows?";
            this.dataGrid1.EnableSort = false;
            this.dataGrid1.FixedRows = 1;
            this.dataGrid1.Location = new System.Drawing.Point(160, 193);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.dataGrid1.Size = new System.Drawing.Size(200, 100);
            this.dataGrid1.TabIndex = 2;
            this.dataGrid1.TabStop = true;
            this.dataGrid1.ToolTipText = "";
            // 
            // pingGrid1
            // 
            emptyPingSource3.AllowSort = false;
            emptyPingSource3.Count = 0;
            this.pingGrid1.DataSource = emptyPingSource3;
            this.pingGrid1.DeleteQuestionMessage = "Are you sure to delete all the selected rows?";
            this.pingGrid1.EnableSort = true;
            this.pingGrid1.FixedRows = 1;
            this.pingGrid1.Location = new System.Drawing.Point(160, 50);
            this.pingGrid1.Name = "pingGrid1";
            this.pingGrid1.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.pingGrid1.Size = new System.Drawing.Size(200, 100);
            this.pingGrid1.TabIndex = 3;
            this.pingGrid1.TabStop = true;
            this.pingGrid1.ToolTipText = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(56, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(683, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 367);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pingGrid1);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.arrayGrid1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SourceGrid.ArrayGrid arrayGrid1;
        private SourceGrid.Grid grid1;
        private SourceGrid.DataGrid dataGrid1;
        private SourceGrid.Extensions.PingGrids.PingGrid pingGrid1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}