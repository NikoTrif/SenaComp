namespace uclib.Baze
{
    partial class ucArtikli
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
            System.Windows.Forms.Label sifraLabel;
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label jedinicaMereLabel;
            System.Windows.Forms.Label pDVLabel;
            System.Windows.Forms.Label prodajnaCenaLabel;
            System.Windows.Forms.Label uslugaLabel;
            System.Windows.Forms.Label cenaLabel;
            this.artikliDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dNovi = new System.Windows.Forms.Button();
            this.dOtkazi = new System.Windows.Forms.Button();
            this.dSacuvaj = new System.Windows.Forms.Button();
            this.dObrisi = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.uslugaCheckBox = new System.Windows.Forms.CheckBox();
            this.prodajnaCenaTextBox = new System.Windows.Forms.TextBox();
            this.jedinicaMereTextBox = new System.Windows.Forms.TextBox();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.sifraTextBox = new System.Windows.Forms.TextBox();
            this.pDVTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKalkNabavnaCena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbKalkRabat = new System.Windows.Forms.TextBox();
            this.dCE = new System.Windows.Forms.Button();
            this.dIzracunaj = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKalkProdajnaCena = new System.Windows.Forms.TextBox();
            this.tbKalkPDV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbKalkMarza = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbKalkCenaBezPDV = new System.Windows.Forms.TextBox();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSenaCompDataSet = new uclib.dbSenaCompDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliTableAdapter = new uclib.dbSenaCompDataSetTableAdapters.ArtikliTableAdapter();
            this.tableAdapterManager = new uclib.dbSenaCompDataSetTableAdapters.TableAdapterManager();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            sifraLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            jedinicaMereLabel = new System.Windows.Forms.Label();
            pDVLabel = new System.Windows.Forms.Label();
            prodajnaCenaLabel = new System.Windows.Forms.Label();
            uslugaLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.artikliDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSenaCompDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sifraLabel
            // 
            sifraLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            sifraLabel.AutoSize = true;
            sifraLabel.Location = new System.Drawing.Point(4, 7);
            sifraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sifraLabel.Name = "sifraLabel";
            sifraLabel.Size = new System.Drawing.Size(102, 17);
            sifraLabel.TabIndex = 0;
            sifraLabel.Text = "Šifra:";
            // 
            // nazivLabel
            // 
            nazivLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(4, 39);
            nazivLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(102, 17);
            nazivLabel.TabIndex = 2;
            nazivLabel.Text = "Naziv:";
            // 
            // jedinicaMereLabel
            // 
            jedinicaMereLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            jedinicaMereLabel.AutoSize = true;
            jedinicaMereLabel.Location = new System.Drawing.Point(4, 71);
            jedinicaMereLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            jedinicaMereLabel.Name = "jedinicaMereLabel";
            jedinicaMereLabel.Size = new System.Drawing.Size(102, 17);
            jedinicaMereLabel.TabIndex = 4;
            jedinicaMereLabel.Text = "Jedinica Mere:";
            // 
            // pDVLabel
            // 
            pDVLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            pDVLabel.AutoSize = true;
            pDVLabel.Location = new System.Drawing.Point(4, 135);
            pDVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pDVLabel.Name = "pDVLabel";
            pDVLabel.Size = new System.Drawing.Size(102, 17);
            pDVLabel.TabIndex = 8;
            pDVLabel.Text = "PDV:";
            // 
            // prodajnaCenaLabel
            // 
            prodajnaCenaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            prodajnaCenaLabel.AutoSize = true;
            prodajnaCenaLabel.Location = new System.Drawing.Point(4, 160);
            prodajnaCenaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            prodajnaCenaLabel.Name = "prodajnaCenaLabel";
            prodajnaCenaLabel.Size = new System.Drawing.Size(102, 32);
            prodajnaCenaLabel.TabIndex = 9;
            prodajnaCenaLabel.Text = "Prodajna Cena:";
            // 
            // uslugaLabel
            // 
            uslugaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            uslugaLabel.AutoSize = true;
            uslugaLabel.Location = new System.Drawing.Point(4, 202);
            uslugaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            uslugaLabel.Name = "uslugaLabel";
            uslugaLabel.Size = new System.Drawing.Size(102, 17);
            uslugaLabel.TabIndex = 10;
            uslugaLabel.Text = "Usluga:";
            // 
            // artikliDataGridView
            // 
            this.artikliDataGridView.AllowUserToAddRows = false;
            this.artikliDataGridView.AllowUserToDeleteRows = false;
            this.artikliDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artikliDataGridView.AutoGenerateColumns = false;
            this.artikliDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.artikliDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artikliDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.artikliDataGridView.DataSource = this.artikliBindingSource;
            this.artikliDataGridView.Location = new System.Drawing.Point(4, 427);
            this.artikliDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.artikliDataGridView.Name = "artikliDataGridView";
            this.artikliDataGridView.ReadOnly = true;
            this.artikliDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.artikliDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.artikliDataGridView.Size = new System.Drawing.Size(1399, 364);
            this.artikliDataGridView.TabIndex = 1;
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
            this.tableLayoutPanel1.TabIndex = 3;
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
            this.dNovi.TabIndex = 12;
            this.dNovi.Text = "Novi artikal";
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
            this.dOtkazi.TabIndex = 10;
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
            this.dSacuvaj.TabIndex = 9;
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
            this.dObrisi.TabIndex = 11;
            this.dObrisi.Text = "Obriši";
            this.dObrisi.UseVisualStyleBackColor = true;
            this.dObrisi.Click += new System.EventHandler(this.dObrisi_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.43451F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.56549F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Controls.Add(cenaLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cenaTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(uslugaLabel, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.uslugaCheckBox, 1, 6);
            this.tableLayoutPanel2.Controls.Add(prodajnaCenaLabel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.prodajnaCenaTextBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(jedinicaMereLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.jedinicaMereTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(nazivLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.nazivTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(sifraLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.sifraTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pDVTextBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(pDVLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label13, 2, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(417, 229);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // uslugaCheckBox
            // 
            this.uslugaCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uslugaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.artikliBindingSource, "Usluga", true));
            this.uslugaCheckBox.Location = new System.Drawing.Point(114, 196);
            this.uslugaCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.uslugaCheckBox.Name = "uslugaCheckBox";
            this.uslugaCheckBox.Size = new System.Drawing.Size(269, 29);
            this.uslugaCheckBox.TabIndex = 6;
            this.uslugaCheckBox.UseVisualStyleBackColor = true;
            // 
            // prodajnaCenaTextBox
            // 
            this.prodajnaCenaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.prodajnaCenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artikliBindingSource, "prodajnaCena", true));
            this.prodajnaCenaTextBox.Location = new System.Drawing.Point(114, 165);
            this.prodajnaCenaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prodajnaCenaTextBox.Name = "prodajnaCenaTextBox";
            this.prodajnaCenaTextBox.Size = new System.Drawing.Size(269, 22);
            this.prodajnaCenaTextBox.TabIndex = 5;
            // 
            // jedinicaMereTextBox
            // 
            this.jedinicaMereTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.jedinicaMereTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artikliBindingSource, "jedinicaMere", true));
            this.jedinicaMereTextBox.Location = new System.Drawing.Point(114, 69);
            this.jedinicaMereTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.jedinicaMereTextBox.Name = "jedinicaMereTextBox";
            this.jedinicaMereTextBox.Size = new System.Drawing.Size(269, 22);
            this.jedinicaMereTextBox.TabIndex = 3;
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artikliBindingSource, "Naziv", true));
            this.nazivTextBox.Location = new System.Drawing.Point(114, 37);
            this.nazivTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(269, 22);
            this.nazivTextBox.TabIndex = 2;
            // 
            // sifraTextBox
            // 
            this.sifraTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sifraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artikliBindingSource, "Sifra", true));
            this.sifraTextBox.Location = new System.Drawing.Point(114, 5);
            this.sifraTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sifraTextBox.Name = "sifraTextBox";
            this.sifraTextBox.Size = new System.Drawing.Size(269, 22);
            this.sifraTextBox.TabIndex = 1;
            // 
            // pDVTextBox
            // 
            this.pDVTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pDVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artikliBindingSource, "PDV", true));
            this.pDVTextBox.Location = new System.Drawing.Point(114, 133);
            this.pDVTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pDVTextBox.Name = "pDVTextBox";
            this.pDVTextBox.Size = new System.Drawing.Size(269, 22);
            this.pDVTextBox.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(390, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "%";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(4, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(425, 252);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artikli i usluge";
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Šifra",
            "Naziv",
            "Usluga"});
            this.cbFilter.Location = new System.Drawing.Point(435, 394);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(143, 24);
            this.cbFilter.TabIndex = 7;
            this.cbFilter.TabStop = false;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Filter:";
            // 
            // tbPretraga
            // 
            this.tbPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPretraga.Location = new System.Drawing.Point(79, 395);
            this.tbPretraga.Margin = new System.Windows.Forms.Padding(4);
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.Size = new System.Drawing.Size(300, 22);
            this.tbPretraga.TabIndex = 8;
            this.tbPretraga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPretraga_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 399);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Pretraga:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Location = new System.Drawing.Point(756, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 252);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kalkulator cena";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbKalkNabavnaCena, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.tbKalkRabat, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.dCE, 2, 6);
            this.tableLayoutPanel3.Controls.Add(this.dIzracunaj, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.label9, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.label10, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.label11, 4, 4);
            this.tableLayoutPanel3.Controls.Add(this.label8, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label12, 5, 2);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.tbKalkProdajnaCena, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.tbKalkPDV, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tbKalkMarza, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tbKalkCenaBezPDV, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(366, 231);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nabavna cena:";
            // 
            // tbKalkNabavnaCena
            // 
            this.tbKalkNabavnaCena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.tbKalkNabavnaCena, 3);
            this.tbKalkNabavnaCena.Location = new System.Drawing.Point(127, 3);
            this.tbKalkNabavnaCena.Name = "tbKalkNabavnaCena";
            this.tbKalkNabavnaCena.Size = new System.Drawing.Size(192, 22);
            this.tbKalkNabavnaCena.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rabat:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Prodajna cena:";
            // 
            // tbKalkRabat
            // 
            this.tbKalkRabat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.tbKalkRabat, 3);
            this.tbKalkRabat.Location = new System.Drawing.Point(127, 32);
            this.tbKalkRabat.Name = "tbKalkRabat";
            this.tbKalkRabat.Size = new System.Drawing.Size(192, 22);
            this.tbKalkRabat.TabIndex = 14;
            // 
            // dCE
            // 
            this.dCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dCE.Location = new System.Drawing.Point(191, 177);
            this.dCE.Name = "dCE";
            this.dCE.Size = new System.Drawing.Size(58, 51);
            this.dCE.TabIndex = 19;
            this.dCE.Text = "CE";
            this.dCE.UseVisualStyleBackColor = true;
            this.dCE.Click += new System.EventHandler(this.dCE_Click);
            // 
            // dIzracunaj
            // 
            this.dIzracunaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dIzracunaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dIzracunaj.Location = new System.Drawing.Point(127, 177);
            this.dIzracunaj.Name = "dIzracunaj";
            this.dIzracunaj.Size = new System.Drawing.Size(58, 51);
            this.dIzracunaj.TabIndex = 18;
            this.dIzracunaj.Text = "=";
            this.dIzracunaj.UseVisualStyleBackColor = true;
            this.dIzracunaj.Click += new System.EventHandler(this.dIzracunaj_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(325, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(325, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(325, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "%";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(347, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "*";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(347, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "*";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "PDV:";
            // 
            // tbKalkProdajnaCena
            // 
            this.tbKalkProdajnaCena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.tbKalkProdajnaCena, 3);
            this.tbKalkProdajnaCena.Location = new System.Drawing.Point(127, 148);
            this.tbKalkProdajnaCena.Name = "tbKalkProdajnaCena";
            this.tbKalkProdajnaCena.Size = new System.Drawing.Size(192, 22);
            this.tbKalkProdajnaCena.TabIndex = 17;
            // 
            // tbKalkPDV
            // 
            this.tbKalkPDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.tbKalkPDV, 3);
            this.tbKalkPDV.Location = new System.Drawing.Point(127, 119);
            this.tbKalkPDV.Name = "tbKalkPDV";
            this.tbKalkPDV.Size = new System.Drawing.Size(192, 22);
            this.tbKalkPDV.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Marža:";
            // 
            // tbKalkMarza
            // 
            this.tbKalkMarza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.tbKalkMarza, 3);
            this.tbKalkMarza.Location = new System.Drawing.Point(127, 61);
            this.tbKalkMarza.Name = "tbKalkMarza";
            this.tbKalkMarza.Size = new System.Drawing.Size(192, 22);
            this.tbKalkMarza.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Cena bez PDV-a:";
            // 
            // tbKalkCenaBezPDV
            // 
            this.tbKalkCenaBezPDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.tbKalkCenaBezPDV, 3);
            this.tbKalkCenaBezPDV.Location = new System.Drawing.Point(127, 90);
            this.tbKalkCenaBezPDV.Name = "tbKalkCenaBezPDV";
            this.tbKalkCenaBezPDV.Size = new System.Drawing.Size(192, 22);
            this.tbKalkCenaBezPDV.TabIndex = 15;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "Artikli";
            this.artikliBindingSource.DataSource = this.dbSenaCompDataSet;
            // 
            // dbSenaCompDataSet
            // 
            this.dbSenaCompDataSet.DataSetName = "dbSenaCompDataSet";
            this.dbSenaCompDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Sifra";
            this.dataGridViewTextBoxColumn1.HeaderText = "Šifra";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "jedinicaMere";
            this.dataGridViewTextBoxColumn3.HeaderText = "Jedinica Mere";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Usluga";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Usluga";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PDV";
            this.dataGridViewTextBoxColumn4.HeaderText = "PDV";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "prodajnaCena";
            this.dataGridViewTextBoxColumn5.HeaderText = "Prodajna Cena";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtikliPFOTableAdapter = null;
            this.tableAdapterManager.ArtikliTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FaktureTableAdapter = null;
            this.tableAdapterManager.FirmeTableAdapter = null;
            this.tableAdapterManager.NaloziFTableAdapter = null;
            this.tableAdapterManager.NaloziPTableAdapter = null;
            this.tableAdapterManager.OtpremniceTableAdapter = null;
            this.tableAdapterManager.ProfaktureTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = uclib.dbSenaCompDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cenaLabel
            // 
            cenaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new System.Drawing.Point(3, 103);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(104, 17);
            cenaLabel.TabIndex = 20;
            cenaLabel.Text = "Cena:";
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artikliBindingSource, "Cena", true));
            this.cenaTextBox.Location = new System.Drawing.Point(113, 101);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(271, 22);
            this.cenaTextBox.TabIndex = 21;
            // 
            // ucArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.artikliDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucArtikli";
            this.Size = new System.Drawing.Size(1407, 795);
            this.Load += new System.EventHandler(this.ucArtikli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artikliDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSenaCompDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbSenaCompDataSet dbSenaCompDataSet;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private dbSenaCompDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private dbSenaCompDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView artikliDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button dNovi;
        private System.Windows.Forms.Button dOtkazi;
        private System.Windows.Forms.Button dSacuvaj;
        private System.Windows.Forms.Button dObrisi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jedinicaMereTextBox;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.TextBox sifraTextBox;
        private System.Windows.Forms.TextBox pDVTextBox;
        private System.Windows.Forms.CheckBox uslugaCheckBox;
        private System.Windows.Forms.TextBox prodajnaCenaTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKalkNabavnaCena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbKalkRabat;
        private System.Windows.Forms.TextBox tbKalkPDV;
        private System.Windows.Forms.TextBox tbKalkProdajnaCena;
        private System.Windows.Forms.Button dIzracunaj;
        private System.Windows.Forms.Button dCE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbKalkCenaBezPDV;
        private System.Windows.Forms.TextBox tbKalkMarza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cenaTextBox;
    }
}
