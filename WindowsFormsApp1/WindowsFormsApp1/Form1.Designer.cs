namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.axEditorControl1 = new AxEDITORCONTROLLib.AxEditorControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.axSASGraph1 = new AxSASGRPH9Lib.AxSASGraph();
            ((System.ComponentModel.ISupportInitialize)(this.axEditorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axSASGraph1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // axEditorControl1
            // 
            this.axEditorControl1.Enabled = true;
            this.axEditorControl1.Location = new System.Drawing.Point(12, 57);
            this.axEditorControl1.Name = "axEditorControl1";
            this.axEditorControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axEditorControl1.OcxState")));
            this.axEditorControl1.Size = new System.Drawing.Size(757, 329);
            this.axEditorControl1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // axSASGraph1
            // 
            this.axSASGraph1.Enabled = true;
            this.axSASGraph1.Location = new System.Drawing.Point(28, 422);
            this.axSASGraph1.Name = "axSASGraph1";
            this.axSASGraph1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axSASGraph1.OcxState")));
            this.axSASGraph1.Size = new System.Drawing.Size(500, 400);
            this.axSASGraph1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 852);
            this.Controls.Add(this.axSASGraph1);
            this.Controls.Add(this.axEditorControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axEditorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axSASGraph1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private AxEDITORCONTROLLib.AxEditorControl axEditorControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxSASGRPH9Lib.AxSASGraph axSASGraph1;
    }
}

