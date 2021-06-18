namespace uclib.Baze
{
    partial class ucFirme
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label pIBLabel;
            System.Windows.Forms.Label gradLabel;
            System.Windows.Forms.Label ulicaBrojLabel;
            System.Windows.Forms.Label kontaktLabel;
            System.Windows.Forms.Label eMailLabel;
            System.Windows.Forms.Label tekuciRacunLabel;
            System.Windows.Forms.Label maticniBrojLabel;
            this.firmeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maticniBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSenaCompDataSet = new uclib.dbSenaCompDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dNovi = new System.Windows.Forms.Button();
            this.dOtkazi = new System.Windows.Forms.Button();
            this.dSacuvaj = new System.Windows.Forms.Button();
            this.dObrisi = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.maticniBrojTextBox = new System.Windows.Forms.TextBox();
            this.pIBTextBox = new System.Windows.Forms.TextBox();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.tekuciRacunTextBox = new System.Windows.Forms.TextBox();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.kontaktTextBox = new System.Windows.Forms.TextBox();
            this.ulicaBrojTextBox = new System.Windows.Forms.TextBox();
            this.gradTextBox = new System.Windows.Forms.TextBox();
            this.firmeTableAdapter = new uclib.dbSenaCompDataSetTableAdapters.FirmeTableAdapter();
            this.tableAdapterManager = new uclib.dbSenaCompDataSetTableAdapters.TableAdapterManager();
            iDLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            pIBLabel = new System.Windows.Forms.Label();
            gradLabel = new System.Windows.Forms.Label();
            ulicaBrojLabel = new System.Windows.Forms.Label();
            kontaktLabel = new System.Windows.Forms.Label();
            eMailLabel = new System.Windows.Forms.Label();
            tekuciRacunLabel = new System.Windows.Forms.Label();
            maticniBrojLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.firmeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSenaCompDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(3, 6);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(107, 17);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // nazivLabel
            // 
            nazivLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(3, 35);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(107, 17);
            nazivLabel.TabIndex = 2;
            nazivLabel.Text = "Naziv firme:";
            // 
            // pIBLabel
            // 
            pIBLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            pIBLabel.AutoSize = true;
            pIBLabel.Location = new System.Drawing.Point(3, 64);
            pIBLabel.Name = "pIBLabel";
            pIBLabel.Size = new System.Drawing.Size(107, 17);
            pIBLabel.TabIndex = 4;
            pIBLabel.Text = "PIB:";
            // 
            // gradLabel
            // 
            gradLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            gradLabel.AutoSize = true;
            gradLabel.Location = new System.Drawing.Point(3, 122);
            gradLabel.Name = "gradLabel";
            gradLabel.Size = new System.Drawing.Size(107, 17);
            gradLabel.TabIndex = 6;
            gradLabel.Text = "Grad:";
            // 
            // ulicaBrojLabel
            // 
            ulicaBrojLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            ulicaBrojLabel.AutoSize = true;
            ulicaBrojLabel.Location = new System.Drawing.Point(3, 151);
            ulicaBrojLabel.Name = "ulicaBrojLabel";
            ulicaBrojLabel.Size = new System.Drawing.Size(107, 17);
            ulicaBrojLabel.TabIndex = 8;
            ulicaBrojLabel.Text = "Ulica i broj:";
            // 
            // kontaktLabel
            // 
            kontaktLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            kontaktLabel.AutoSize = true;
            kontaktLabel.Location = new System.Drawing.Point(3, 180);
            kontaktLabel.Name = "kontaktLabel";
            kontaktLabel.Size = new System.Drawing.Size(107, 17);
            kontaktLabel.TabIndex = 10;
            kontaktLabel.Text = "Kontakt:";
            // 
            // eMailLabel
            // 
            eMailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            eMailLabel.AutoSize = true;
            eMailLabel.Location = new System.Drawing.Point(3, 209);
            eMailLabel.Name = "eMailLabel";
            eMailLabel.Size = new System.Drawing.Size(107, 17);
            eMailLabel.TabIndex = 12;
            eMailLabel.Text = "e-Mail:";
            // 
            // tekuciRacunLabel
            // 
            tekuciRacunLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            tekuciRacunLabel.AutoSize = true;
            tekuciRacunLabel.Location = new System.Drawing.Point(3, 241);
            tekuciRacunLabel.Name = "tekuciRacunLabel";
            tekuciRacunLabel.Size = new System.Drawing.Size(107, 17);
            tekuciRacunLabel.TabIndex = 14;
            tekuciRacunLabel.Text = "Tekući račun:";
            // 
            // maticniBrojLabel
            // 
            maticniBrojLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            maticniBrojLabel.AutoSize = true;
            maticniBrojLabel.Location = new System.Drawing.Point(3, 93);
            maticniBrojLabel.Name = "maticniBrojLabel";
            maticniBrojLabel.Size = new System.Drawing.Size(107, 17);
            maticniBrojLabel.TabIndex = 16;
            maticniBrojLabel.Text = "Matični broj:";
            // 
            // firmeDataGridView
            // 
            this.firmeDataGridView.AllowUserToAddRows = false;
            this.firmeDataGridView.AllowUserToDeleteRows = false;
            this.firmeDataGridView.AutoGenerateColumns = false;
            this.firmeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.firmeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firmeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.maticniBroj,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.firmeDataGridView.DataSource = this.firmeBindingSource;
            this.firmeDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.firmeDataGridView.Location = new System.Drawing.Point(0, 452);
            this.firmeDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.firmeDataGridView.Name = "firmeDataGridView";
            this.firmeDataGridView.ReadOnly = true;
            this.firmeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.firmeDataGridView.Size = new System.Drawing.Size(1407, 343);
            this.firmeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PIB";
            this.dataGridViewTextBoxColumn3.HeaderText = "PIB";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // maticniBroj
            // 
            this.maticniBroj.DataPropertyName = "maticniBroj";
            this.maticniBroj.HeaderText = "Matični Broj";
            this.maticniBroj.Name = "maticniBroj";
            this.maticniBroj.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Grad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Grad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "UlicaBroj";
            this.dataGridViewTextBoxColumn5.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Kontakt";
            this.dataGridViewTextBoxColumn6.HeaderText = "Kontakt";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "eMail";
            this.dataGridViewTextBoxColumn7.HeaderText = "e-Mail";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "tekuciRacun";
            this.dataGridViewTextBoxColumn8.HeaderText = "Tekući Račun";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // firmeBindingSource
            // 
            this.firmeBindingSource.DataMember = "Firme";
            this.firmeBindingSource.DataSource = this.dbSenaCompDataSet;
            // 
            // dbSenaCompDataSet
            // 
            this.dbSenaCompDataSet.DataSetName = "dbSenaCompDataSet";
            this.dbSenaCompDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dNovi, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dOtkazi, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dSacuvaj, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dObrisi, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(131, 36);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(915, 44);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dNovi
            // 
            this.dNovi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dNovi.Location = new System.Drawing.Point(4, 4);
            this.dNovi.Margin = new System.Windows.Forms.Padding(4);
            this.dNovi.Name = "dNovi";
            this.dNovi.Size = new System.Drawing.Size(175, 36);
            this.dNovi.TabIndex = 1;
            this.dNovi.Text = "Novi korisnik";
            this.dNovi.UseVisualStyleBackColor = true;
            this.dNovi.Click += new System.EventHandler(this.dNovi_Click);
            // 
            // dOtkazi
            // 
            this.dOtkazi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dOtkazi.Location = new System.Drawing.Point(187, 4);
            this.dOtkazi.Margin = new System.Windows.Forms.Padding(4);
            this.dOtkazi.Name = "dOtkazi";
            this.dOtkazi.Size = new System.Drawing.Size(175, 36);
            this.dOtkazi.TabIndex = 2;
            this.dOtkazi.Text = "Otkaži";
            this.dOtkazi.UseVisualStyleBackColor = true;
            this.dOtkazi.Click += new System.EventHandler(this.dOtkazi_Click);
            // 
            // dSacuvaj
            // 
            this.dSacuvaj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dSacuvaj.Location = new System.Drawing.Point(370, 4);
            this.dSacuvaj.Margin = new System.Windows.Forms.Padding(4);
            this.dSacuvaj.Name = "dSacuvaj";
            this.dSacuvaj.Size = new System.Drawing.Size(175, 36);
            this.dSacuvaj.TabIndex = 3;
            this.dSacuvaj.Text = "Sačuvaj";
            this.dSacuvaj.UseVisualStyleBackColor = true;
            this.dSacuvaj.Click += new System.EventHandler(this.dSacuvaj_Click);
            // 
            // dObrisi
            // 
            this.dObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dObrisi.Location = new System.Drawing.Point(736, 4);
            this.dObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.dObrisi.Name = "dObrisi";
            this.dObrisi.Size = new System.Drawing.Size(175, 36);
            this.dObrisi.TabIndex = 4;
            this.dObrisi.Text = "Obriši";
            this.dObrisi.UseVisualStyleBackColor = true;
            this.dObrisi.Click += new System.EventHandler(this.dObrisi_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Sve",
            "ID",
            "Naziv",
            "PIB",
            "Maticni broj",
            "Grad",
            "Adresa",
            "Kontakt",
            "e-Mail",
            "Tekući Račun"});
            this.cbFilter.Location = new System.Drawing.Point(429, 412);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(143, 24);
            this.cbFilter.TabIndex = 14;
            this.cbFilter.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Filter:";
            // 
            // tbPretraga
            // 
            this.tbPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPretraga.Location = new System.Drawing.Point(79, 414);
            this.tbPretraga.Margin = new System.Windows.Forms.Padding(4);
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.Size = new System.Drawing.Size(300, 22);
            this.tbPretraga.TabIndex = 13;
            this.tbPretraga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPretraga_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 417);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Pretraga:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(3, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(421, 286);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korisnik";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.38386F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.61614F));
            this.tableLayoutPanel2.Controls.Add(maticniBrojLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.maticniBrojTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(pIBLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pIBTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(nazivLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.nazivTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(iDLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.iDTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(tekuciRacunLabel, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.tekuciRacunTextBox, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.eMailTextBox, 1, 7);
            this.tableLayoutPanel2.Controls.Add(eMailLabel, 0, 7);
            this.tableLayoutPanel2.Controls.Add(kontaktLabel, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.kontaktTextBox, 1, 6);
            this.tableLayoutPanel2.Controls.Add(ulicaBrojLabel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.ulicaBrojTextBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(gradLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.gradTextBox, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(415, 267);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // maticniBrojTextBox
            // 
            this.maticniBrojTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maticniBrojTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmeBindingSource, "maticniBroj", true));
            this.maticniBrojTextBox.Location = new System.Drawing.Point(116, 90);
            this.maticniBrojTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maticniBrojTextBox.Name = "maticniBrojTextBox";
            this.maticniBrojTextBox.Size = new System.Drawing.Size(296, 22);
            this.maticniBrojTextBox.TabIndex = 7;
            // 
            // pIBTextBox
            // 
            this.pIBTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pIBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmeBindingSource, "PIB", true));
            this.pIBTextBox.Location = new System.Drawing.Point(116, 61);
            this.pIBTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pIBTextBox.Name = "pIBTextBox";
            this.pIBTextBox.Size = new System.Drawing.Size(296, 22);
            this.pIBTextBox.TabIndex = 6;
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmeBindingSource, "Naziv", true));
            this.nazivTextBox.Location = new System.Drawing.Point(116, 32);
            this.nazivTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(296, 22);
            this.nazivTextBox.TabIndex = 5;
            // 
            // iDTextBox
            // 
            this.iDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmeBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(116, 3);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(296, 22);
            this.iDTextBox.TabIndex = 1;
            this.iDTextBox.TabStop = false;
            // 
            // tekuciRacunTextBox
            // 
            this.tekuciRacunTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tekuciRacunTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmeBindingSource, "tekuciRacun", true));
            this.tekuciRacunTextBox.Location = new System.Drawing.Point(116, 238);
            this.tekuciRacunTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tekuciRacunTextBox.Name = "tekuciRacunTextBox";
            this.tekuciRacunTextBox.Size = new System.Drawing.Size(296, 22);
            this.tekuciRacunTextBox.TabIndex = 12;
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.eMailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmeBindingSource, "eMail", true));
            this.eMailTextBox.Location = new System.Drawing.Point(116, 206);
            this.eMailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(296, 22);
            this.eMailTextBox.TabIndex = 11;
            // 
            // kontaktTextBox
            // 
            this.kontaktTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kontaktTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmeBindingSource, "Kontakt", true));
            this.kontaktTextBox.Location = new System.Drawing.Point(116, 177);
            this.kontaktTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kontaktTextBox.Name = "kontaktTextBox";
            this.kontaktTextBox.Size = new System.Drawing.Size(296, 22);
            this.kontaktTextBox.TabIndex = 10;
            this.kontaktTextBox.Leave += new System.EventHandler(this.kontaktTextBox_Leave);
            // 
            // ulicaBrojTextBox
            // 
            this.ulicaBrojTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ulicaBrojTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmeBindingSource, "UlicaBroj", true));
            this.ulicaBrojTextBox.Location = new System.Drawing.Point(116, 148);
            this.ulicaBrojTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ulicaBrojTextBox.Name = "ulicaBrojTextBox";
            this.ulicaBrojTextBox.Size = new System.Drawing.Size(296, 22);
            this.ulicaBrojTextBox.TabIndex = 9;
            // 
            // gradTextBox
            // 
            this.gradTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gradTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmeBindingSource, "Grad", true));
            this.gradTextBox.Location = new System.Drawing.Point(116, 119);
            this.gradTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradTextBox.Name = "gradTextBox";
            this.gradTextBox.Size = new System.Drawing.Size(296, 22);
            this.gradTextBox.TabIndex = 8;
            // 
            // firmeTableAdapter
            // 
            this.firmeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtikliPFOTableAdapter = null;
            this.tableAdapterManager.ArtikliTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FaktureTableAdapter = null;
            this.tableAdapterManager.FirmeTableAdapter = this.firmeTableAdapter;
            this.tableAdapterManager.NaloziFTableAdapter = null;
            this.tableAdapterManager.NaloziPTableAdapter = null;
            this.tableAdapterManager.OtpremniceTableAdapter = null;
            this.tableAdapterManager.ProfaktureTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = uclib.dbSenaCompDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ucFirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.firmeDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucFirme";
            this.Size = new System.Drawing.Size(1407, 795);
            this.Load += new System.EventHandler(this.ucFirme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firmeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSenaCompDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbSenaCompDataSet dbSenaCompDataSet;
        private System.Windows.Forms.BindingSource firmeBindingSource;
        private dbSenaCompDataSetTableAdapters.FirmeTableAdapter firmeTableAdapter;
        private dbSenaCompDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView firmeDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button dNovi;
        private System.Windows.Forms.Button dOtkazi;
        private System.Windows.Forms.Button dSacuvaj;
        private System.Windows.Forms.Button dObrisi;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tekuciRacunTextBox;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.TextBox kontaktTextBox;
        private System.Windows.Forms.TextBox ulicaBrojTextBox;
        private System.Windows.Forms.TextBox gradTextBox;
        private System.Windows.Forms.TextBox pIBTextBox;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn maticniBroj;
        private System.Windows.Forms.TextBox maticniBrojTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}
