namespace uclib.Opcije.Osnovno
{
    partial class ucOprema
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
            this.lbOprema = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOprema = new System.Windows.Forms.TextBox();
            this.dDodaj = new System.Windows.Forms.Button();
            this.dGore = new System.Windows.Forms.Button();
            this.dDole = new System.Windows.Forms.Button();
            this.dObrisi = new System.Windows.Forms.Button();
            this.dApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOprema
            // 
            this.lbOprema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbOprema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOprema.FormattingEnabled = true;
            this.lbOprema.ItemHeight = 20;
            this.lbOprema.Location = new System.Drawing.Point(117, 58);
            this.lbOprema.Margin = new System.Windows.Forms.Padding(2);
            this.lbOprema.Name = "lbOprema";
            this.lbOprema.Size = new System.Drawing.Size(301, 404);
            this.lbOprema.TabIndex = 0;
            this.lbOprema.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbOprema_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oprema";
            // 
            // tbOprema
            // 
            this.tbOprema.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbOprema.Location = new System.Drawing.Point(164, 29);
            this.tbOprema.Margin = new System.Windows.Forms.Padding(2);
            this.tbOprema.Name = "tbOprema";
            this.tbOprema.Size = new System.Drawing.Size(146, 20);
            this.tbOprema.TabIndex = 2;
            this.tbOprema.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbOprema_KeyDown);
            this.tbOprema.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOprema_KeyPress);
            // 
            // dDodaj
            // 
            this.dDodaj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dDodaj.Location = new System.Drawing.Point(314, 25);
            this.dDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.dDodaj.Name = "dDodaj";
            this.dDodaj.Size = new System.Drawing.Size(50, 27);
            this.dDodaj.TabIndex = 3;
            this.dDodaj.Text = "Dodaj";
            this.dDodaj.UseVisualStyleBackColor = true;
            this.dDodaj.Click += new System.EventHandler(this.dDodaj_Click);
            // 
            // dGore
            // 
            this.dGore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dGore.Location = new System.Drawing.Point(422, 208);
            this.dGore.Margin = new System.Windows.Forms.Padding(2);
            this.dGore.Name = "dGore";
            this.dGore.Size = new System.Drawing.Size(28, 31);
            this.dGore.TabIndex = 4;
            this.dGore.Text = "U";
            this.dGore.UseVisualStyleBackColor = true;
            this.dGore.Click += new System.EventHandler(this.dGore_Click);
            // 
            // dDole
            // 
            this.dDole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dDole.Location = new System.Drawing.Point(422, 244);
            this.dDole.Margin = new System.Windows.Forms.Padding(2);
            this.dDole.Name = "dDole";
            this.dDole.Size = new System.Drawing.Size(28, 31);
            this.dDole.TabIndex = 4;
            this.dDole.Text = "D";
            this.dDole.UseVisualStyleBackColor = true;
            this.dDole.Click += new System.EventHandler(this.dDole_Click);
            // 
            // dObrisi
            // 
            this.dObrisi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dObrisi.Location = new System.Drawing.Point(368, 25);
            this.dObrisi.Margin = new System.Windows.Forms.Padding(2);
            this.dObrisi.Name = "dObrisi";
            this.dObrisi.Size = new System.Drawing.Size(50, 27);
            this.dObrisi.TabIndex = 3;
            this.dObrisi.Text = "Obriši";
            this.dObrisi.UseVisualStyleBackColor = true;
            this.dObrisi.Click += new System.EventHandler(this.dObrisi_Click);
            // 
            // dApply
            // 
            this.dApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dApply.Location = new System.Drawing.Point(422, 427);
            this.dApply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 20);
            this.dApply.Name = "dApply";
            this.dApply.Size = new System.Drawing.Size(108, 35);
            this.dApply.TabIndex = 3;
            this.dApply.Text = "Primeni";
            this.dApply.UseVisualStyleBackColor = true;
            this.dApply.Click += new System.EventHandler(this.dApply_Click);
            // 
            // ucOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dDole);
            this.Controls.Add(this.dGore);
            this.Controls.Add(this.dApply);
            this.Controls.Add(this.dObrisi);
            this.Controls.Add(this.dDodaj);
            this.Controls.Add(this.tbOprema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOprema);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucOprema";
            this.Size = new System.Drawing.Size(532, 483);
            this.Load += new System.EventHandler(this.ucOprema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOprema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOprema;
        private System.Windows.Forms.Button dDodaj;
        private System.Windows.Forms.Button dGore;
        private System.Windows.Forms.Button dDole;
        private System.Windows.Forms.Button dObrisi;
        private System.Windows.Forms.Button dApply;
    }
}
