namespace uclib
{
    partial class fRazno
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
            this.pRazno = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pRazno
            // 
            this.pRazno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pRazno.Location = new System.Drawing.Point(0, 0);
            this.pRazno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pRazno.Name = "pRazno";
            this.pRazno.Size = new System.Drawing.Size(283, 254);
            this.pRazno.TabIndex = 0;
            // 
            // fRazno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 254);
            this.Controls.Add(this.pRazno);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fRazno";
            this.Text = "fRazno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fRazno_FormClosing);
            this.Load += new System.EventHandler(this.fRazno_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pRazno;
    }
}