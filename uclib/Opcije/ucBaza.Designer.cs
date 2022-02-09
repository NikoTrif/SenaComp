namespace uclib.Opcije
{
    partial class ucBaza
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
            this.dApply = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.rbLokalna = new System.Windows.Forms.RadioButton();
            this.rbServer = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLokacija = new System.Windows.Forms.TextBox();
            this.dBrowse = new System.Windows.Forms.Button();
            this.dBazaHelp = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Backup = new System.Windows.Forms.Button();
            this.dVrati = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cbAutoAzuriranje = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMinuti = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dObrisi = new System.Windows.Forms.Button();
            this.dNovaBaza = new System.Windows.Forms.Button();
            this.pbBackup = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.labBackup = new System.Windows.Forms.Label();
            this.cbAutoBackup = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dApply
            // 
            this.dApply.Location = new System.Drawing.Point(595, 529);
            this.dApply.Margin = new System.Windows.Forms.Padding(4);
            this.dApply.Name = "dApply";
            this.dApply.Size = new System.Drawing.Size(104, 42);
            this.dApply.TabIndex = 3;
            this.dApply.Text = "Prihvati";
            this.dApply.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbLokalna, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbServer, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(703, 33);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip baze podataka:";
            // 
            // rbLokalna
            // 
            this.rbLokalna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbLokalna.AutoSize = true;
            this.rbLokalna.Location = new System.Drawing.Point(237, 6);
            this.rbLokalna.Name = "rbLokalna";
            this.rbLokalna.Size = new System.Drawing.Size(228, 21);
            this.rbLokalna.TabIndex = 1;
            this.rbLokalna.TabStop = true;
            this.rbLokalna.Text = "Lokalna";
            this.rbLokalna.UseVisualStyleBackColor = true;
            // 
            // rbServer
            // 
            this.rbServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbServer.AutoSize = true;
            this.rbServer.Location = new System.Drawing.Point(471, 6);
            this.rbServer.Name = "rbServer";
            this.rbServer.Size = new System.Drawing.Size(229, 21);
            this.rbServer.TabIndex = 1;
            this.rbServer.TabStop = true;
            this.rbServer.Text = "Server";
            this.rbServer.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.59468F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.40532F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbLokacija, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dBrowse, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dBazaHelp, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 65);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(703, 33);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lokacija:";
            // 
            // tbLokacija
            // 
            this.tbLokacija.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLokacija.Location = new System.Drawing.Point(132, 5);
            this.tbLokacija.Name = "tbLokacija";
            this.tbLokacija.Size = new System.Drawing.Size(466, 22);
            this.tbLokacija.TabIndex = 1;
            // 
            // dBrowse
            // 
            this.dBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dBrowse.Location = new System.Drawing.Point(604, 3);
            this.dBrowse.Name = "dBrowse";
            this.dBrowse.Size = new System.Drawing.Size(44, 27);
            this.dBrowse.TabIndex = 2;
            this.dBrowse.Text = "...";
            this.dBrowse.UseVisualStyleBackColor = true;
            // 
            // dBazaHelp
            // 
            this.dBazaHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dBazaHelp.Location = new System.Drawing.Point(654, 3);
            this.dBazaHelp.Name = "dBazaHelp";
            this.dBazaHelp.Size = new System.Drawing.Size(46, 27);
            this.dBazaHelp.TabIndex = 2;
            this.dBazaHelp.Text = "?";
            this.dBazaHelp.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.61069F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.38931F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Backup, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dVrati, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.dObrisi, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.dNovaBaza, 0, 4);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 230);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(703, 198);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(655, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Putanja Backup-a:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(137, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(512, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Backup
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.Backup, 3);
            this.Backup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Backup.Location = new System.Drawing.Point(3, 36);
            this.Backup.Name = "Backup";
            this.Backup.Size = new System.Drawing.Size(697, 27);
            this.Backup.TabIndex = 4;
            this.Backup.Text = "Backup";
            this.Backup.UseVisualStyleBackColor = true;
            // 
            // dVrati
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.dVrati, 3);
            this.dVrati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dVrati.Location = new System.Drawing.Point(3, 69);
            this.dVrati.Name = "dVrati";
            this.dVrati.Size = new System.Drawing.Size(697, 27);
            this.dVrati.TabIndex = 4;
            this.dVrati.Text = "Vrati";
            this.dVrati.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.41622F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.26834F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.4145F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.83243F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.06851F));
            this.tableLayoutPanel4.Controls.Add(this.cbAutoAzuriranje, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.tbMinuti, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.cbAutoBackup, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 104);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(703, 99);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // cbAutoAzuriranje
            // 
            this.cbAutoAzuriranje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAutoAzuriranje.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.cbAutoAzuriranje, 3);
            this.cbAutoAzuriranje.Location = new System.Drawing.Point(3, 5);
            this.cbAutoAzuriranje.Name = "cbAutoAzuriranje";
            this.cbAutoAzuriranje.Size = new System.Drawing.Size(352, 21);
            this.cbAutoAzuriranje.TabIndex = 0;
            this.cbAutoAzuriranje.Text = "Automatsko ažuriranje baze podataka";
            this.cbAutoAzuriranje.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ažuriraj Bazu svakih";
            // 
            // tbMinuti
            // 
            this.tbMinuti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMinuti.Location = new System.Drawing.Point(246, 37);
            this.tbMinuti.Name = "tbMinuti";
            this.tbMinuti.Size = new System.Drawing.Size(109, 22);
            this.tbMinuti.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "minuta.";
            // 
            // dObrisi
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.dObrisi, 3);
            this.dObrisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dObrisi.Location = new System.Drawing.Point(3, 168);
            this.dObrisi.Name = "dObrisi";
            this.dObrisi.Size = new System.Drawing.Size(697, 27);
            this.dObrisi.TabIndex = 8;
            this.dObrisi.Text = "Obriši";
            this.dObrisi.UseVisualStyleBackColor = true;
            // 
            // dNovaBaza
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.dNovaBaza, 3);
            this.dNovaBaza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dNovaBaza.Location = new System.Drawing.Point(3, 135);
            this.dNovaBaza.Name = "dNovaBaza";
            this.dNovaBaza.Size = new System.Drawing.Size(697, 27);
            this.dNovaBaza.TabIndex = 8;
            this.dNovaBaza.Text = "Nova Baza";
            this.dNovaBaza.UseVisualStyleBackColor = true;
            // 
            // pbBackup
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.pbBackup, 3);
            this.pbBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBackup.Location = new System.Drawing.Point(3, 36);
            this.pbBackup.Name = "pbBackup";
            this.pbBackup.Size = new System.Drawing.Size(697, 27);
            this.pbBackup.TabIndex = 8;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.pbBackup, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.labBackup, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 442);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(703, 66);
            this.tableLayoutPanel5.TabIndex = 9;
            this.tableLayoutPanel5.Visible = false;
            // 
            // labBackup
            // 
            this.labBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labBackup.AutoSize = true;
            this.labBackup.Location = new System.Drawing.Point(237, 8);
            this.labBackup.Name = "labBackup";
            this.labBackup.Size = new System.Drawing.Size(228, 17);
            this.labBackup.TabIndex = 9;
            this.labBackup.Text = "label6";
            this.labBackup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbAutoBackup
            // 
            this.cbAutoBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAutoBackup.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.cbAutoBackup, 3);
            this.cbAutoBackup.Location = new System.Drawing.Point(3, 71);
            this.cbAutoBackup.Name = "cbAutoBackup";
            this.cbAutoBackup.Size = new System.Drawing.Size(352, 21);
            this.cbAutoBackup.TabIndex = 0;
            this.cbAutoBackup.Text = "Automatski Backup baze podataka";
            this.cbAutoBackup.UseVisualStyleBackColor = true;
            // 
            // ucBaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dApply);
            this.Name = "ucBaza";
            this.Size = new System.Drawing.Size(709, 594);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dApply;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbLokalna;
        private System.Windows.Forms.RadioButton rbServer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLokacija;
        private System.Windows.Forms.Button dBrowse;
        private System.Windows.Forms.Button dBazaHelp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Backup;
        private System.Windows.Forms.Button dVrati;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.CheckBox cbAutoAzuriranje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMinuti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button dObrisi;
        private System.Windows.Forms.Button dNovaBaza;
        private System.Windows.Forms.ProgressBar pbBackup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label labBackup;
        private System.Windows.Forms.CheckBox cbAutoBackup;
    }
}
