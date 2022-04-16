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
            this.Backup = new System.Windows.Forms.Button();
            this.dVrati = new System.Windows.Forms.Button();
            this.dObrisi = new System.Windows.Forms.Button();
            this.dBackupPathBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cbAutoAzuriranje = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMinuti = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAutoBackup = new System.Windows.Forms.CheckBox();
            this.tbBackupPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDani = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbBackup = new System.Windows.Forms.ProgressBar();
            this.tlpBackup = new System.Windows.Forms.TableLayoutPanel();
            this.labBackup = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tlpBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dApply
            // 
            this.dApply.Location = new System.Drawing.Point(446, 430);
            this.dApply.Name = "dApply";
            this.dApply.Size = new System.Drawing.Size(78, 34);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 21);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 27);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip baze podataka:";
            // 
            // rbLokalna
            // 
            this.rbLokalna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbLokalna.AutoSize = true;
            this.rbLokalna.Checked = true;
            this.rbLokalna.Location = new System.Drawing.Point(177, 5);
            this.rbLokalna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbLokalna.Name = "rbLokalna";
            this.rbLokalna.Size = new System.Drawing.Size(171, 17);
            this.rbLokalna.TabIndex = 1;
            this.rbLokalna.TabStop = true;
            this.rbLokalna.Text = "Lokalna";
            this.rbLokalna.UseVisualStyleBackColor = true;
            this.rbLokalna.CheckedChanged += new System.EventHandler(this.rbLokalna_CheckedChanged);
            // 
            // rbServer
            // 
            this.rbServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbServer.AutoSize = true;
            this.rbServer.Checked = global::uclib.Properties.Settings.Default.BazaServer;
            this.rbServer.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uclib.Properties.Settings.Default, "BazaServer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rbServer.Location = new System.Drawing.Point(352, 5);
            this.rbServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbServer.Name = "rbServer";
            this.rbServer.Size = new System.Drawing.Size(173, 17);
            this.rbServer.TabIndex = 1;
            this.rbServer.TabStop = true;
            this.rbServer.Text = "Server";
            this.rbServer.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbLokacija, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dBrowse, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dBazaHelp, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 53);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(527, 27);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lokacija:";
            // 
            // tbLokacija
            // 
            this.tbLokacija.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLokacija.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uclib.Properties.Settings.Default, "BazaServerPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbLokacija.Location = new System.Drawing.Point(59, 3);
            this.tbLokacija.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLokacija.Name = "tbLokacija";
            this.tbLokacija.Size = new System.Drawing.Size(351, 20);
            this.tbLokacija.TabIndex = 1;
            this.tbLokacija.Text = global::uclib.Properties.Settings.Default.BazaServerPath;
            // 
            // dBrowse
            // 
            this.dBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dBrowse.Location = new System.Drawing.Point(414, 2);
            this.dBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dBrowse.Name = "dBrowse";
            this.dBrowse.Size = new System.Drawing.Size(52, 23);
            this.dBrowse.TabIndex = 2;
            this.dBrowse.Text = "...";
            this.dBrowse.UseVisualStyleBackColor = true;
            this.dBrowse.Click += new System.EventHandler(this.dBrowse_Click);
            // 
            // dBazaHelp
            // 
            this.dBazaHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dBazaHelp.Location = new System.Drawing.Point(470, 2);
            this.dBazaHelp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dBazaHelp.Name = "dBazaHelp";
            this.dBazaHelp.Size = new System.Drawing.Size(55, 23);
            this.dBazaHelp.TabIndex = 2;
            this.dBazaHelp.Text = "?";
            this.dBazaHelp.UseVisualStyleBackColor = true;
            this.dBazaHelp.Click += new System.EventHandler(this.dBazaHelp_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.61069F));
            this.tableLayoutPanel3.Controls.Add(this.Backup, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dVrati, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dObrisi, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 223);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(527, 107);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // Backup
            // 
            this.Backup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Backup.Location = new System.Drawing.Point(2, 2);
            this.Backup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Backup.Name = "Backup";
            this.Backup.Size = new System.Drawing.Size(523, 22);
            this.Backup.TabIndex = 4;
            this.Backup.Text = "Backup";
            this.Backup.UseVisualStyleBackColor = true;
            this.Backup.Click += new System.EventHandler(this.Backup_Click);
            // 
            // dVrati
            // 
            this.dVrati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dVrati.Location = new System.Drawing.Point(2, 28);
            this.dVrati.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dVrati.Name = "dVrati";
            this.dVrati.Size = new System.Drawing.Size(523, 22);
            this.dVrati.TabIndex = 4;
            this.dVrati.Text = "Vrati";
            this.dVrati.UseVisualStyleBackColor = true;
            this.dVrati.Click += new System.EventHandler(this.dVrati_Click);
            // 
            // dObrisi
            // 
            this.dObrisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dObrisi.Location = new System.Drawing.Point(2, 80);
            this.dObrisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dObrisi.Name = "dObrisi";
            this.dObrisi.Size = new System.Drawing.Size(523, 25);
            this.dObrisi.TabIndex = 8;
            this.dObrisi.Text = "Obriši";
            this.dObrisi.UseVisualStyleBackColor = true;
            this.dObrisi.Click += new System.EventHandler(this.dObrisi_Click);
            // 
            // dBackupPathBrowse
            // 
            this.dBackupPathBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dBackupPathBrowse.Location = new System.Drawing.Point(467, 110);
            this.dBackupPathBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dBackupPathBrowse.Name = "dBackupPathBrowse";
            this.dBackupPathBrowse.Size = new System.Drawing.Size(58, 23);
            this.dBackupPathBrowse.TabIndex = 3;
            this.dBackupPathBrowse.Text = "...";
            this.dBackupPathBrowse.UseVisualStyleBackColor = true;
            this.dBackupPathBrowse.Click += new System.EventHandler(this.dBackupPathBrowse_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Putanja backup-a:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.92308F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.30769F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.69231F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.Controls.Add(this.cbAutoAzuriranje, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.tbMinuti, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.cbAutoBackup, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label3, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.tbBackupPath, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.dBackupPathBrowse, 4, 4);
            this.tableLayoutPanel4.Controls.Add(this.label6, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.tbDani, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.label7, 3, 3);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 84);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(527, 135);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // cbAutoAzuriranje
            // 
            this.cbAutoAzuriranje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAutoAzuriranje.AutoSize = true;
            this.cbAutoAzuriranje.Checked = global::uclib.Properties.Settings.Default.BazaAutoUpdate;
            this.tableLayoutPanel4.SetColumnSpan(this.cbAutoAzuriranje, 3);
            this.cbAutoAzuriranje.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::uclib.Properties.Settings.Default, "BazaAutoUpdate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbAutoAzuriranje.Location = new System.Drawing.Point(2, 5);
            this.cbAutoAzuriranje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAutoAzuriranje.Name = "cbAutoAzuriranje";
            this.cbAutoAzuriranje.Size = new System.Drawing.Size(211, 17);
            this.cbAutoAzuriranje.TabIndex = 0;
            this.cbAutoAzuriranje.Text = "Automatsko ažuriranje baze podataka";
            this.cbAutoAzuriranje.UseVisualStyleBackColor = true;
            this.cbAutoAzuriranje.CheckedChanged += new System.EventHandler(this.cbAutoAzuriranje_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ažuriraj bazu svakih";
            // 
            // tbMinuti
            // 
            this.tbMinuti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMinuti.Location = new System.Drawing.Point(169, 30);
            this.tbMinuti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMinuti.Name = "tbMinuti";
            this.tbMinuti.Size = new System.Drawing.Size(44, 20);
            this.tbMinuti.TabIndex = 2;
            this.tbMinuti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinuti_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 13);
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
            this.cbAutoBackup.Location = new System.Drawing.Point(2, 59);
            this.cbAutoBackup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAutoBackup.Name = "cbAutoBackup";
            this.cbAutoBackup.Size = new System.Drawing.Size(211, 17);
            this.cbAutoBackup.TabIndex = 0;
            this.cbAutoBackup.Text = "Automatski Backup baze podataka";
            this.cbAutoBackup.UseVisualStyleBackColor = true;
            this.cbAutoBackup.CheckedChanged += new System.EventHandler(this.cbAutoBackup_CheckedChanged);
            // 
            // tbBackupPath
            // 
            this.tbBackupPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.SetColumnSpan(this.tbBackupPath, 2);
            this.tbBackupPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::uclib.Properties.Settings.Default, "BazaAutpBackupPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbBackupPath.Location = new System.Drawing.Point(169, 111);
            this.tbBackupPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbBackupPath.Name = "tbBackupPath";
            this.tbBackupPath.Size = new System.Drawing.Size(294, 20);
            this.tbBackupPath.TabIndex = 1;
            this.tbBackupPath.Text = global::uclib.Properties.Settings.Default.BazaAutpBackupPath;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sačuvaj svakih";
            // 
            // tbDani
            // 
            this.tbDani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDani.Location = new System.Drawing.Point(169, 84);
            this.tbDani.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDani.Name = "tbDani";
            this.tbDani.Size = new System.Drawing.Size(44, 20);
            this.tbDani.TabIndex = 2;
            this.tbDani.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinuti_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "dana.";
            // 
            // pbBackup
            // 
            this.tlpBackup.SetColumnSpan(this.pbBackup, 3);
            this.pbBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBackup.Location = new System.Drawing.Point(2, 29);
            this.pbBackup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbBackup.Name = "pbBackup";
            this.pbBackup.Size = new System.Drawing.Size(523, 23);
            this.pbBackup.TabIndex = 8;
            // 
            // tlpBackup
            // 
            this.tlpBackup.ColumnCount = 3;
            this.tlpBackup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBackup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBackup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBackup.Controls.Add(this.pbBackup, 0, 1);
            this.tlpBackup.Controls.Add(this.labBackup, 1, 0);
            this.tlpBackup.Location = new System.Drawing.Point(2, 361);
            this.tlpBackup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpBackup.Name = "tlpBackup";
            this.tlpBackup.RowCount = 2;
            this.tlpBackup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBackup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBackup.Size = new System.Drawing.Size(527, 54);
            this.tlpBackup.TabIndex = 9;
            this.tlpBackup.Visible = false;
            // 
            // labBackup
            // 
            this.labBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labBackup.AutoSize = true;
            this.labBackup.Location = new System.Drawing.Point(177, 7);
            this.labBackup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labBackup.Name = "labBackup";
            this.labBackup.Size = new System.Drawing.Size(171, 13);
            this.labBackup.TabIndex = 9;
            this.labBackup.Text = "label6";
            this.labBackup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucBaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpBackup);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dApply);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucBaza";
            this.Size = new System.Drawing.Size(532, 483);
            this.Load += new System.EventHandler(this.ucBaza_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tlpBackup.ResumeLayout(false);
            this.tlpBackup.PerformLayout();
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
        private System.Windows.Forms.ProgressBar pbBackup;
        private System.Windows.Forms.TableLayoutPanel tlpBackup;
        private System.Windows.Forms.Label labBackup;
        private System.Windows.Forms.CheckBox cbAutoBackup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDani;
        private System.Windows.Forms.Label label7;
    }
}
