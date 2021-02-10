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
            this.dApply = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logo:";
            // 
            // tbLogo
            // 
            this.tbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogo.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uclib.Properties.Settings.Default, "Logo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbLogo.Location = new System.Drawing.Point(83, 2);
            this.tbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.tbLogo.Name = "tbLogo";
            this.tbLogo.Size = new System.Drawing.Size(173, 20);
            this.tbLogo.TabIndex = 1;
            this.tbLogo.Text = global::uclib.Properties.Settings.Default.Logo;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Naziv firme:";
            // 
            // tbFirma
            // 
            this.tbFirma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirma.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uclib.Properties.Settings.Default, "NazivFirme", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbFirma.Location = new System.Drawing.Point(83, 25);
            this.tbFirma.Margin = new System.Windows.Forms.Padding(2);
            this.tbFirma.Name = "tbFirma";
            this.tbFirma.Size = new System.Drawing.Size(173, 20);
            this.tbFirma.TabIndex = 3;
            this.tbFirma.Text = global::uclib.Properties.Settings.Default.NazivFirme;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Delatnost:";
            // 
            // tbDelatnost
            // 
            this.tbDelatnost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDelatnost.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uclib.Properties.Settings.Default, "Delatnost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbDelatnost.Location = new System.Drawing.Point(83, 48);
            this.tbDelatnost.Margin = new System.Windows.Forms.Padding(2);
            this.tbDelatnost.Name = "tbDelatnost";
            this.tbDelatnost.Size = new System.Drawing.Size(173, 20);
            this.tbDelatnost.TabIndex = 4;
            this.tbDelatnost.Text = global::uclib.Properties.Settings.Default.Delatnost;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adresa:";
            // 
            // tbAdresa
            // 
            this.tbAdresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uclib.Properties.Settings.Default, "Adresa", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbAdresa.Location = new System.Drawing.Point(83, 71);
            this.tbAdresa.Margin = new System.Windows.Forms.Padding(2);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(173, 20);
            this.tbAdresa.TabIndex = 5;
            this.tbAdresa.Text = global::uclib.Properties.Settings.Default.Adresa;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefon:";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTelefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uclib.Properties.Settings.Default, "Telefon", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbTelefon.Location = new System.Drawing.Point(83, 94);
            this.tbTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(173, 20);
            this.tbTelefon.TabIndex = 6;
            this.tbTelefon.Text = global::uclib.Properties.Settings.Default.Telefon;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "e-mail:";
            // 
            // tbMail
            // 
            this.tbMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uclib.Properties.Settings.Default, "eMail", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbMail.Location = new System.Drawing.Point(83, 117);
            this.tbMail.Margin = new System.Windows.Forms.Padding(2);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(173, 20);
            this.tbMail.TabIndex = 7;
            this.tbMail.Text = global::uclib.Properties.Settings.Default.eMail;
            // 
            // pbSetLogo
            // 
            this.pbSetLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSetLogo.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", global::uclib.Properties.Settings.Default, "Logo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pbSetLogo.ImageLocation = global::uclib.Properties.Settings.Default.Logo;
            this.pbSetLogo.Location = new System.Drawing.Point(332, 34);
            this.pbSetLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbSetLogo.Name = "pbSetLogo";
            this.pbSetLogo.Size = new System.Drawing.Size(163, 163);
            this.pbSetLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSetLogo.TabIndex = 2;
            this.pbSetLogo.TabStop = false;
            // 
            // dBrowse
            // 
            this.dBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dBrowse.Location = new System.Drawing.Point(260, 2);
            this.dBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.dBrowse.Name = "dBrowse";
            this.dBrowse.Size = new System.Drawing.Size(25, 19);
            this.dBrowse.TabIndex = 2;
            this.dBrowse.Text = "...";
            this.dBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dBrowse.UseVisualStyleBackColor = true;
            this.dBrowse.Click += new System.EventHandler(this.dBrowse_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tekući račun:";
            // 
            // tbTekuciRacun
            // 
            this.tbTekuciRacun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTekuciRacun.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uclib.Properties.Settings.Default, "TekuciRacun", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbTekuciRacun.Location = new System.Drawing.Point(83, 140);
            this.tbTekuciRacun.Margin = new System.Windows.Forms.Padding(2);
            this.tbTekuciRacun.Name = "tbTekuciRacun";
            this.tbTekuciRacun.Size = new System.Drawing.Size(173, 20);
            this.tbTekuciRacun.TabIndex = 8;
            this.tbTekuciRacun.Text = global::uclib.Properties.Settings.Default.TekuciRacun;
            // 
            // dApply
            // 
            this.dApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dApply.Location = new System.Drawing.Point(446, 430);
            this.dApply.Margin = new System.Windows.Forms.Padding(2);
            this.dApply.Name = "dApply";
            this.dApply.Size = new System.Drawing.Size(78, 34);
            this.dApply.TabIndex = 9;
            this.dApply.Text = "Primeni";
            this.dApply.UseVisualStyleBackColor = true;
            this.dApply.Click += new System.EventHandler(this.dApply_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.39535F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.60465F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dBrowse, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbTekuciRacun, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbMail, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbTelefon, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbAdresa, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbLogo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbDelatnost, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbFirma, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(287, 163);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // ucPodaciFirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dApply);
            this.Controls.Add(this.pbSetLogo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucPodaciFirme";
            this.Size = new System.Drawing.Size(532, 483);
            ((System.ComponentModel.ISupportInitialize)(this.pbSetLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button dApply;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
