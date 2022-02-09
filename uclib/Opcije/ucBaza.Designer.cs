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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dBrowse = new System.Windows.Forms.Button();
            this.dBazaHelp = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Backup = new System.Windows.Forms.Button();
            this.dVrati = new System.Windows.Forms.Button();
            this.dObrisi = new System.Windows.Forms.Button();
            this.dNovaBaza = new System.Windows.Forms.Button();
            this.dBackupPathBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBackupPath = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMinuti = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAutoBackup = new System.Windows.Forms.CheckBox();
            this.pbBackup = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.labBackup = new System.Windows.Forms.Label();
            this.cbAutoAzuriranje = new System.Windows.Forms.CheckBox();
            this.tbLokacija = new System.Windows.Forms.TextBox();
            this.rbServer = new System.Windows.Forms.RadioButton();
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
            this.dApply.Click += new System.EventHandler(this.dApply_Click);
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
            this.rbLokalna.Checked = true;
            this.rbLokalna.Location = new System.Drawing.Point(237, 6);
            this.rbLokalna.Name = "rbLokalna";
            this.rbLokalna.Size = new System.Drawing.Size(228, 21);
            this.rbLokalna.TabIndex = 1;
            this.rbLokalna.TabStop = true;
            this.rbLokalna.Text = "Lokalna";
            this.rbLokalna.UseVisualStyleBackColor = true;
            this.rbLokalna.CheckedChanged += new System.EventHandler(this.rbLokalna_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
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
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lokacija:";
            // 
            // dBrowse
            // 
            this.dBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dBrowse.Location = new System.Drawing.Point(603, 3);
            this.dBrowse.Name = "dBrowse";
            this.dBrowse.Size = new System.Drawing.Size(44, 27);
            this.dBrowse.TabIndex = 2;
            this.dBrowse.Text = "...";
            this.dBrowse.UseVisualStyleBackColor = true;
            // 
            // dBazaHelp
            // 
            this.dBazaHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dBazaHelp.Location = new System.Drawing.Point(653, 3);
            this.dBazaHelp.Name = "dBazaHelp";
            this.dBazaHelp.Size = new System.Drawing.Size(47, 27);
            this.dBazaHelp.TabIndex = 2;
            this.dBazaHelp.Text = "?";
            this.dBazaHelp.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.61069F));
            this.tableLayoutPanel3.Controls.Add(this.Backup, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dVrati, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dObrisi, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.dNovaBaza, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 255);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(703, 165);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // Backup
            // 
            this.Backup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Backup.Location = new System.Drawing.Point(3, 3);
            this.Backup.Name = "Backup";
            this.Backup.Size = new System.Drawing.Size(697, 27);
            this.Backup.TabIndex = 4;
            this.Backup.Text = "Backup";
            this.Backup.UseVisualStyleBackColor = true;
            // 
            // dVrati
            // 
            this.dVrati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dVrati.Location = new System.Drawing.Point(3, 36);
            this.dVrati.Name = "dVrati";
            this.dVrati.Size = new System.Drawing.Size(697, 27);
            this.dVrati.TabIndex = 4;
            this.dVrati.Text = "Vrati";
            this.dVrati.UseVisualStyleBackColor = true;
            // 
            // dObrisi
            // 
            this.dObrisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dObrisi.Location = new System.Drawing.Point(3, 135);
            this.dObrisi.Name = "dObrisi";
            this.dObrisi.Size = new System.Drawing.Size(697, 27);
            this.dObrisi.TabIndex = 8;
            this.dObrisi.Text = "Obriši";
            this.dObrisi.UseVisualStyleBackColor = true;
            // 
            // dNovaBaza
            // 
            this.dNovaBaza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dNovaBaza.Location = new System.Drawing.Point(3, 102);
            this.dNovaBaza.Name = "dNovaBaza";
            this.dNovaBaza.Size = new System.Drawing.Size(697, 27);
            this.dNovaBaza.TabIndex = 8;
            this.dNovaBaza.Text = "Nova Baza";
            this.dNovaBaza.UseVisualStyleBackColor = true;
            // 
            // dBackupPathBrowse
            // 
            this.dBackupPathBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dBackupPathBrowse.Location = new System.Drawing.Point(646, 102);
            this.dBackupPathBrowse.Name = "dBackupPathBrowse";
            this.dBackupPathBrowse.Size = new System.Drawing.Size(54, 27);
            this.dBackupPathBrowse.TabIndex = 3;
            this.dBackupPathBrowse.Text = "...";
            this.dBackupPathBrowse.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Putanja backup-a:";
            // 
            // tbBackupPath
            // 
            this.tbBackupPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.SetColumnSpan(this.tbBackupPath, 2);
            this.tbBackupPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uclib.Properties.Settings.Default, "BazaAutpBackupPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbBackupPath.Location = new System.Drawing.Point(234, 104);
            this.tbBackupPath.Name = "tbBackupPath";
            this.tbBackupPath.Size = new System.Drawing.Size(406, 22);
            this.tbBackupPath.TabIndex = 1;
            this.tbBackupPath.Text = global::uclib.Properties.Settings.Default.BazaAutpBackupPath;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.92308F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.30769F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.69231F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel4.Controls.Add(this.dBackupPathBrowse, 4, 3);
            this.tableLayoutPanel4.Controls.Add(this.cbAutoAzuriranje, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.tbMinuti, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.cbAutoBackup, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.tbBackupPath, 2, 3);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 104);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(703, 132);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ažuriraj bazu svakih";
            // 
            // tbMinuti
            // 
            this.tbMinuti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMinuti.Location = new System.Drawing.Point(234, 38);
            this.tbMinuti.Name = "tbMinuti";
            this.tbMinuti.Size = new System.Drawing.Size(60, 22);
            this.tbMinuti.TabIndex = 2;
            this.tbMinuti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinuti_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "minuta.";
            // 
            // cbAutoBackup
            // 
            this.cbAutoBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAutoBackup.AutoSize = true;
            this.cbAutoBackup.Checked = global::uclib.Properties.Settings.Default.BazaAutoBackup;
            this.tableLayoutPanel4.SetColumnSpan(this.cbAutoBackup, 3);
            this.cbAutoBackup.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uclib.Properties.Settings.Default, "BazaAutoBackup", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbAutoBackup.Location = new System.Drawing.Point(3, 72);
            this.cbAutoBackup.Name = "cbAutoBackup";
            this.cbAutoBackup.Size = new System.Drawing.Size(291, 21);
            this.cbAutoBackup.TabIndex = 0;
            this.cbAutoBackup.Text = "Automatski Backup baze podataka";
            this.cbAutoBackup.UseVisualStyleBackColor = true;
            this.cbAutoBackup.CheckedChanged += new System.EventHandler(this.cbAutoBackup_CheckedChanged);
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
            // cbAutoAzuriranje
            // 
            this.cbAutoAzuriranje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAutoAzuriranje.AutoSize = true;
            this.cbAutoAzuriranje.Checked = global::uclib.Properties.Settings.Default.BazaAutoUpdate;
            this.tableLayoutPanel4.SetColumnSpan(this.cbAutoAzuriranje, 3);
            this.cbAutoAzuriranje.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uclib.Properties.Settings.Default, "BazaAutoUpdate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbAutoAzuriranje.Location = new System.Drawing.Point(3, 6);
            this.cbAutoAzuriranje.Name = "cbAutoAzuriranje";
            this.cbAutoAzuriranje.Size = new System.Drawing.Size(291, 21);
            this.cbAutoAzuriranje.TabIndex = 0;
            this.cbAutoAzuriranje.Text = "Automatsko ažuriranje baze podataka";
            this.cbAutoAzuriranje.UseVisualStyleBackColor = true;
            this.cbAutoAzuriranje.CheckedChanged += new System.EventHandler(this.cbAutoAzuriranje_CheckedChanged);
            // 
            // tbLokacija
            // 
            this.tbLokacija.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLokacija.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uclib.Properties.Settings.Default, "BazaServerPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbLokacija.Location = new System.Drawing.Point(87, 5);
            this.tbLokacija.Name = "tbLokacija";
            this.tbLokacija.Size = new System.Drawing.Size(510, 22);
            this.tbLokacija.TabIndex = 1;
            this.tbLokacija.Text = global::uclib.Properties.Settings.Default.BazaServerPath;
            // 
            // rbServer
            // 
            this.rbServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbServer.AutoSize = true;
            this.rbServer.Checked = global::uclib.Properties.Settings.Default.BazaServer;
            this.rbServer.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uclib.Properties.Settings.Default, "BazaServer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rbServer.Location = new System.Drawing.Point(471, 6);
            this.rbServer.Name = "rbServer";
            this.rbServer.Size = new System.Drawing.Size(229, 21);
            this.rbServer.TabIndex = 1;
            this.rbServer.TabStop = true;
            this.rbServer.Text = "Server";
            this.rbServer.UseVisualStyleBackColor = true;
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
            this.Load += new System.EventHandler(this.ucBaza_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
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
        private System.Windows.Forms.Button dBackupPathBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBackupPath;
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
