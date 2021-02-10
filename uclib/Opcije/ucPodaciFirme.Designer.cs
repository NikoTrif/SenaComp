namespace uclib.Opcije
{
    partial class ucPodaciFirme
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
            this.tbLogo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFirma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDelatnost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.pbSetLogo = new System.Windows.Forms.PictureBox();
            this.dBrowse = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTekuciRacun = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logo:";
            // 
            // tbLogo
            // 
            this.tbLogo.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uclib.Properties.Settings.Default, "Logo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbLogo.Location = new System.Drawing.Point(86, 34);
            this.tbLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLogo.Name = "tbLogo";
            this.tbLogo.Size = new System.Drawing.Size(179, 20);
            this.tbLogo.TabIndex = 1;
            this.tbLogo.Text = global::uclib.Properties.Settings.Default.Logo;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Naziv firme:";
            // 
            // tbFirma
            // 
            this.tbFirma.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uclib.Properties.Settings.Default, "NazivFirme", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbFirma.Location = new System.Drawing.Point(86, 57);
            this.tbFirma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFirma.Name = "tbFirma";
            this.tbFirma.Size = new System.Drawing.Size(179, 20);
            this.tbFirma.TabIndex = 3;
            this.tbFirma.Text = global::uclib.Properties.Settings.Default.NazivFirme;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Delatnost:";
            // 
            // tbDelatnost
            // 
            this.tbDelatnost.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uclib.Properties.Settings.Default, "Delatnost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbDelatnost.Location = new System.Drawing.Point(86, 80);
            this.tbDelatnost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDelatnost.Name = "tbDelatnost";
            this.tbDelatnost.Size = new System.Drawing.Size(179, 20);
            this.tbDelatnost.TabIndex = 4;
            this.tbDelatnost.Text = global::uclib.Properties.Settings.Default.Delatnost;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adresa:";
            // 
            // tbAdresa
            // 
            this.tbAdresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uclib.Properties.Settings.Default, "Adresa", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbAdresa.Location = new System.Drawing.Point(86, 102);
            this.tbAdresa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(179, 20);
            this.tbAdresa.TabIndex = 5;
            this.tbAdresa.Text = global::uclib.Properties.Settings.Default.Adresa;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefon:";
            // 
            // tbTelefon
            // 
            this.tbTelefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uclib.Properties.Settings.Default, "Telefon", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbTelefon.Location = new System.Drawing.Point(86, 125);
            this.tbTelefon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(179, 20);
            this.tbTelefon.TabIndex = 6;
            this.tbTelefon.Text = global::uclib.Properties.Settings.Default.Telefon;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "e-mail:";
            // 
            // tbMail
            // 
            this.tbMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uclib.Properties.Settings.Default, "eMail", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbMail.Location = new System.Drawing.Point(86, 148);
            this.tbMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(179, 20);
            this.tbMail.TabIndex = 7;
            this.tbMail.Text = global::uclib.Properties.Settings.Default.eMail;
            // 
            // pbSetLogo
            // 
            this.pbSetLogo.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", global::uclib.Properties.Settings.Default, "Logo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pbSetLogo.ImageLocation = global::uclib.Properties.Settings.Default.Logo;
            this.pbSetLogo.Location = new System.Drawing.Point(346, 34);
            this.pbSetLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbSetLogo.Name = "pbSetLogo";
            this.pbSetLogo.Size = new System.Drawing.Size(158, 158);
            this.pbSetLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSetLogo.TabIndex = 2;
            this.pbSetLogo.TabStop = false;
            // 
            // dBrowse
            // 
            this.dBrowse.Location = new System.Drawing.Point(268, 34);
            this.dBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dBrowse.Name = "dBrowse";
            this.dBrowse.Size = new System.Drawing.Size(26, 19);
            this.dBrowse.TabIndex = 2;
            this.dBrowse.Text = "...";
            this.dBrowse.UseVisualStyleBackColor = true;
            this.dBrowse.Click += new System.EventHandler(this.dBrowse_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 174);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tekući račun:";
            // 
            // tbTekuciRacun
            // 
            this.tbTekuciRacun.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uclib.Properties.Settings.Default, "TekuciRacun", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbTekuciRacun.Location = new System.Drawing.Point(86, 172);
            this.tbTekuciRacun.Margin = new System.Windows.Forms.Padding(2);
            this.tbTekuciRacun.Name = "tbTekuciRacun";
            this.tbTekuciRacun.Size = new System.Drawing.Size(179, 20);
            this.tbTekuciRacun.TabIndex = 8;
            this.tbTekuciRacun.Text = global::uclib.Properties.Settings.Default.TekuciRacun;
            // 
            // ucPodaciFirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dBrowse);
            this.Controls.Add(this.pbSetLogo);
            this.Controls.Add(this.tbTekuciRacun);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDelatnost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFirma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLogo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucPodaciFirme";
            this.Size = new System.Drawing.Size(532, 483);
            ((System.ComponentModel.ISupportInitialize)(this.pbSetLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFirma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDelatnost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.PictureBox pbSetLogo;
        private System.Windows.Forms.Button dBrowse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTekuciRacun;
    }
}
