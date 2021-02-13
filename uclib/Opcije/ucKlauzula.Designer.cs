namespace uclib.Opcije
{
    partial class ucKlauzula
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rtbKlauzula = new System.Windows.Forms.RichTextBox();
            this.dApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klauzula:";
            // 
            // rtbKlauzula
            // 
            this.rtbKlauzula.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uclib.Properties.Settings.Default, "Klauzula", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rtbKlauzula.Location = new System.Drawing.Point(3, 33);
            this.rtbKlauzula.MaxLength = 511;
            this.rtbKlauzula.Name = "rtbKlauzula";
            this.rtbKlauzula.Size = new System.Drawing.Size(526, 109);
            this.rtbKlauzula.TabIndex = 1;
            this.rtbKlauzula.Text = global::uclib.Properties.Settings.Default.Klauzula;
            // 
            // dApply
            // 
            this.dApply.Location = new System.Drawing.Point(446, 430);
            this.dApply.Name = "dApply";
            this.dApply.Size = new System.Drawing.Size(78, 34);
            this.dApply.TabIndex = 2;
            this.dApply.Text = "Prihvati";
            this.dApply.UseVisualStyleBackColor = true;
            this.dApply.Click += new System.EventHandler(this.dApply_Click);
            // 
            // ucKlauzula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dApply);
            this.Controls.Add(this.rtbKlauzula);
            this.Controls.Add(this.label1);
            this.Name = "ucKlauzula";
            this.Size = new System.Drawing.Size(532, 483);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbKlauzula;
        private System.Windows.Forms.Button dApply;
    }
}
