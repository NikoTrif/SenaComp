namespace uclib.Nalozi
{
    partial class ucPrivatni
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
            System.Windows.Forms.Label brojNalogaLabel;
            System.Windows.Forms.Label datumLabel;
            System.Windows.Forms.Label imePrezimeLabel;
            System.Windows.Forms.Label kontaktLabel;
            System.Windows.Forms.Label eMailLabel;
            System.Windows.Forms.Label uredjajLabel;
            System.Windows.Forms.Label proizvodjacLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label serijskiBrojLabel;
            System.Windows.Forms.Label opisKvaraLabel;
            System.Windows.Forms.Label izvestajLabel;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.clRadniNalogPrivBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.naloziPDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDelova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaServis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsBaza = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.napomenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naloziPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSenaCompDataSet = new uclib.dbSenaCompDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.brojNalogaTextBox = new System.Windows.Forms.TextBox();
            this.cmsBrojNaloga = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.noviBrojNalogaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniBrojNalogaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naCekanjuRadioButton = new System.Windows.Forms.RadioButton();
            this.zavrsenoRadioButton = new System.Windows.Forms.RadioButton();
            this.korisnikOdbioPlacanjeRadioButton1 = new System.Windows.Forms.RadioButton();
            this.servisOdustaoRadioButton = new System.Windows.Forms.RadioButton();
            this.korisnikOdustaoRadioButton = new System.Windows.Forms.RadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.kontaktTextBox = new System.Windows.Forms.TextBox();
            this.imePrezimeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.serijskiBrojTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.proizvodjacComboBox = new System.Windows.Forms.ComboBox();
            this.uredjajComboBox = new System.Windows.Forms.ComboBox();
            this.ostaloTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.opisKvaraTextBox = new System.Windows.Forms.TextBox();
            this.izvestajRichTextBox = new System.Windows.Forms.RichTextBox();
            this.dSacuvaj = new System.Windows.Forms.Button();
            this.dOtkazi = new System.Windows.Forms.Button();
            this.dObrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            this.dStampaj = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dNovi = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.naloziPTableAdapter = new uclib.dbSenaCompDataSetTableAdapters.NaloziPTableAdapter();
            this.tableAdapterManager = new uclib.dbSenaCompDataSetTableAdapters.TableAdapterManager();
            brojNalogaLabel = new System.Windows.Forms.Label();
            datumLabel = new System.Windows.Forms.Label();
            imePrezimeLabel = new System.Windows.Forms.Label();
            kontaktLabel = new System.Windows.Forms.Label();
            eMailLabel = new System.Windows.Forms.Label();
            uredjajLabel = new System.Windows.Forms.Label();
            proizvodjacLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            serijskiBrojLabel = new System.Windows.Forms.Label();
            opisKvaraLabel = new System.Windows.Forms.Label();
            izvestajLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clRadniNalogPrivBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naloziPDataGridView)).BeginInit();
            this.cmsBaza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.naloziPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSenaCompDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.cmsBrojNaloga.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // brojNalogaLabel
            // 
            brojNalogaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            brojNalogaLabel.AutoSize = true;
            brojNalogaLabel.Location = new System.Drawing.Point(4, 8);
            brojNalogaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            brojNalogaLabel.Name = "brojNalogaLabel";
            brojNalogaLabel.Size = new System.Drawing.Size(110, 17);
            brojNalogaLabel.TabIndex = 0;
            brojNalogaLabel.Text = "Broj Naloga:";
            // 
            // datumLabel
            // 
            datumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            datumLabel.AutoSize = true;
            datumLabel.Location = new System.Drawing.Point(4, 41);
            datumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(110, 17);
            datumLabel.TabIndex = 2;
            datumLabel.Text = "Datum:";
            // 
            // imePrezimeLabel
            // 
            imePrezimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            imePrezimeLabel.AutoSize = true;
            imePrezimeLabel.Location = new System.Drawing.Point(4, 8);
            imePrezimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            imePrezimeLabel.Name = "imePrezimeLabel";
            imePrezimeLabel.Size = new System.Drawing.Size(97, 17);
            imePrezimeLabel.TabIndex = 0;
            imePrezimeLabel.Text = "Ime i prezime:";
            // 
            // kontaktLabel
            // 
            kontaktLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            kontaktLabel.AutoSize = true;
            kontaktLabel.Location = new System.Drawing.Point(4, 41);
            kontaktLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            kontaktLabel.Name = "kontaktLabel";
            kontaktLabel.Size = new System.Drawing.Size(97, 17);
            kontaktLabel.TabIndex = 2;
            kontaktLabel.Text = "Kontakt:";
            // 
            // eMailLabel
            // 
            eMailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            eMailLabel.AutoSize = true;
            eMailLabel.Location = new System.Drawing.Point(4, 74);
            eMailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            eMailLabel.Name = "eMailLabel";
            eMailLabel.Size = new System.Drawing.Size(97, 17);
            eMailLabel.TabIndex = 4;
            eMailLabel.Text = "e-Mail:";
            // 
            // uredjajLabel
            // 
            uredjajLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            uredjajLabel.AutoSize = true;
            uredjajLabel.Location = new System.Drawing.Point(4, 7);
            uredjajLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            uredjajLabel.Name = "uredjajLabel";
            uredjajLabel.Size = new System.Drawing.Size(91, 17);
            uredjajLabel.TabIndex = 0;
            uredjajLabel.Text = "Uređaj:";
            // 
            // proizvodjacLabel
            // 
            proizvodjacLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            proizvodjacLabel.AutoSize = true;
            proizvodjacLabel.Location = new System.Drawing.Point(290, 7);
            proizvodjacLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            proizvodjacLabel.Name = "proizvodjacLabel";
            proizvodjacLabel.Size = new System.Drawing.Size(103, 17);
            proizvodjacLabel.TabIndex = 2;
            proizvodjacLabel.Text = "Proizvođač:";
            // 
            // modelLabel
            // 
            modelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(4, 38);
            modelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(91, 17);
            modelLabel.TabIndex = 4;
            modelLabel.Text = "Model:";
            // 
            // serijskiBrojLabel
            // 
            serijskiBrojLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            serijskiBrojLabel.AutoSize = true;
            serijskiBrojLabel.Location = new System.Drawing.Point(290, 38);
            serijskiBrojLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            serijskiBrojLabel.Name = "serijskiBrojLabel";
            serijskiBrojLabel.Size = new System.Drawing.Size(103, 17);
            serijskiBrojLabel.TabIndex = 6;
            serijskiBrojLabel.Text = "Serijski Broj:";
            // 
            // opisKvaraLabel
            // 
            opisKvaraLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            opisKvaraLabel.AutoSize = true;
            opisKvaraLabel.Location = new System.Drawing.Point(4, 7);
            opisKvaraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            opisKvaraLabel.Name = "opisKvaraLabel";
            opisKvaraLabel.Size = new System.Drawing.Size(91, 17);
            opisKvaraLabel.TabIndex = 11;
            opisKvaraLabel.Text = "Opis kvara:";
            // 
            // izvestajLabel
            // 
            izvestajLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            izvestajLabel.AutoSize = true;
            izvestajLabel.Location = new System.Drawing.Point(4, 75);
            izvestajLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            izvestajLabel.Name = "izvestajLabel";
            izvestajLabel.Size = new System.Drawing.Size(91, 17);
            izvestajLabel.TabIndex = 13;
            izvestajLabel.Text = "Izvestaj:";
            // 
            // clRadniNalogPrivBindingSource
            // 
            this.clRadniNalogPrivBindingSource.DataSource = typeof(iflib.ReportClasses.clRadniNalogPriv);
            // 
            // naloziPDataGridView
            // 
            this.naloziPDataGridView.AllowUserToAddRows = false;
            this.naloziPDataGridView.AllowUserToDeleteRows = false;
            this.naloziPDataGridView.AutoGenerateColumns = false;
            this.naloziPDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.naloziPDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.naloziPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.naloziPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.cenaDelova,
            this.cenaServis,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewCheckBoxColumn5,
            this.dataGridViewTextBoxColumn15});
            this.naloziPDataGridView.ContextMenuStrip = this.cmsBaza;
            this.naloziPDataGridView.DataSource = this.naloziPBindingSource;
            this.naloziPDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.naloziPDataGridView.Location = new System.Drawing.Point(0, 591);
            this.naloziPDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.naloziPDataGridView.MultiSelect = false;
            this.naloziPDataGridView.Name = "naloziPDataGridView";
            this.naloziPDataGridView.ReadOnly = true;
            this.naloziPDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.naloziPDataGridView.Size = new System.Drawing.Size(1407, 204);
            this.naloziPDataGridView.TabIndex = 1;
            this.naloziPDataGridView.TabStop = false;
            this.naloziPDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.naloziPDataGridView_CellClick);
            this.naloziPDataGridView.SelectionChanged += new System.EventHandler(this.naloziPDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "brojNaloga";
            this.dataGridViewTextBoxColumn1.HeaderText = "Broj Naloga";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn2.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "imePrezime";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ime i prezime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Kontakt";
            this.dataGridViewTextBoxColumn4.HeaderText = "Kontakt";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "eMail";
            this.dataGridViewTextBoxColumn5.HeaderText = "e-Mail";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Uredjaj";
            this.dataGridViewTextBoxColumn6.HeaderText = "Uređaj";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Proizvodjac";
            this.dataGridViewTextBoxColumn7.HeaderText = "Proizvođač";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn8.HeaderText = "Model";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "serijskiBroj";
            this.dataGridViewTextBoxColumn9.HeaderText = "Serijski Broj";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Oprema";
            this.dataGridViewTextBoxColumn10.HeaderText = "Oprema";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "opisKvara";
            this.dataGridViewTextBoxColumn11.HeaderText = "Opis kvara";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Izvestaj";
            this.dataGridViewTextBoxColumn12.HeaderText = "Izveštaj";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // cenaDelova
            // 
            this.cenaDelova.DataPropertyName = "cenaDelova";
            this.cenaDelova.HeaderText = "cenaDelova";
            this.cenaDelova.Name = "cenaDelova";
            this.cenaDelova.ReadOnly = true;
            this.cenaDelova.Visible = false;
            // 
            // cenaServis
            // 
            this.cenaServis.DataPropertyName = "cenaServis";
            this.cenaServis.HeaderText = "cenaServis";
            this.cenaServis.Name = "cenaServis";
            this.cenaServis.ReadOnly = true;
            this.cenaServis.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn14.HeaderText = "Status";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "naCekanju";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Na čekanju";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Zavrseno";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Završeno";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Visible = false;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "korisnikOdustao";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Korisnik odustao";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            this.dataGridViewCheckBoxColumn3.Visible = false;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "servisOdustao";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Servis odustao";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.ReadOnly = true;
            this.dataGridViewCheckBoxColumn4.Visible = false;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "korisnikOdbioPlacanje";
            this.dataGridViewCheckBoxColumn5.HeaderText = "Korisnik odbio Plaćanje";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.ReadOnly = true;
            this.dataGridViewCheckBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Napomena";
            this.dataGridViewTextBoxColumn15.HeaderText = "Napomena";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // cmsBaza
            // 
            this.cmsBaza.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsBaza.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.napomenaToolStripMenuItem});
            this.cmsBaza.Name = "cmsBaza";
            this.cmsBaza.Size = new System.Drawing.Size(153, 28);
            // 
            // napomenaToolStripMenuItem
            // 
            this.napomenaToolStripMenuItem.Name = "napomenaToolStripMenuItem";
            this.napomenaToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.napomenaToolStripMenuItem.Text = "Napomena";
            this.napomenaToolStripMenuItem.Click += new System.EventHandler(this.napomenaToolStripMenuItem_Click);
            // 
            // naloziPBindingSource
            // 
            this.naloziPBindingSource.DataMember = "NaloziP";
            this.naloziPBindingSource.DataSource = this.dbSenaCompDataSet;
            // 
            // dbSenaCompDataSet
            // 
            this.dbSenaCompDataSet.DataSetName = "dbSenaCompDataSet";
            this.dbSenaCompDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(4, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(380, 192);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nalog";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.89964F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.10036F));
            this.tableLayoutPanel1.Controls.Add(datumLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.datumDateTimePicker, 1, 1);
            this.tableLayoutPanel1.Controls.Add(brojNalogaLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.brojNalogaTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.naCekanjuRadioButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.zavrsenoRadioButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.korisnikOdbioPlacanjeRadioButton1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.servisOdustaoRadioButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.korisnikOdustaoRadioButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 169);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.naloziPBindingSource, "Datum", true));
            this.datumDateTimePicker.Location = new System.Drawing.Point(122, 38);
            this.datumDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(246, 22);
            this.datumDateTimePicker.TabIndex = 25;
            this.datumDateTimePicker.TabStop = false;
            // 
            // brojNalogaTextBox
            // 
            this.brojNalogaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.brojNalogaTextBox.ContextMenuStrip = this.cmsBrojNaloga;
            this.brojNalogaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.naloziPBindingSource, "brojNaloga", true));
            this.brojNalogaTextBox.Location = new System.Drawing.Point(122, 5);
            this.brojNalogaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.brojNalogaTextBox.Name = "brojNalogaTextBox";
            this.brojNalogaTextBox.ReadOnly = true;
            this.brojNalogaTextBox.Size = new System.Drawing.Size(246, 22);
            this.brojNalogaTextBox.TabIndex = 25;
            this.brojNalogaTextBox.TabStop = false;
            // 
            // cmsBrojNaloga
            // 
            this.cmsBrojNaloga.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsBrojNaloga.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviBrojNalogaToolStripMenuItem,
            this.izmeniBrojNalogaToolStripMenuItem});
            this.cmsBrojNaloga.Name = "cmsBrojNaloga";
            this.cmsBrojNaloga.Size = new System.Drawing.Size(204, 80);
            // 
            // noviBrojNalogaToolStripMenuItem
            // 
            this.noviBrojNalogaToolStripMenuItem.Name = "noviBrojNalogaToolStripMenuItem";
            this.noviBrojNalogaToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.noviBrojNalogaToolStripMenuItem.Text = "Novi broj naloga";
            this.noviBrojNalogaToolStripMenuItem.Click += new System.EventHandler(this.noviBrojNalogaToolStripMenuItem_Click);
            // 
            // izmeniBrojNalogaToolStripMenuItem
            // 
            this.izmeniBrojNalogaToolStripMenuItem.CheckOnClick = true;
            this.izmeniBrojNalogaToolStripMenuItem.Name = "izmeniBrojNalogaToolStripMenuItem";
            this.izmeniBrojNalogaToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.izmeniBrojNalogaToolStripMenuItem.Text = "Izmeni broj naloga";
            this.izmeniBrojNalogaToolStripMenuItem.Click += new System.EventHandler(this.izmeniBrojNalogaToolStripMenuItem_Click);
            // 
            // naCekanjuRadioButton
            // 
            this.naCekanjuRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.naCekanjuRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.naloziPBindingSource, "naCekanju", true));
            this.naCekanjuRadioButton.Location = new System.Drawing.Point(4, 70);
            this.naCekanjuRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.naCekanjuRadioButton.Name = "naCekanjuRadioButton";
            this.naCekanjuRadioButton.Size = new System.Drawing.Size(110, 25);
            this.naCekanjuRadioButton.TabIndex = 25;
            this.naCekanjuRadioButton.Text = "Na čekanju";
            this.naCekanjuRadioButton.UseVisualStyleBackColor = true;
            // 
            // zavrsenoRadioButton
            // 
            this.zavrsenoRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.zavrsenoRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.naloziPBindingSource, "Zavrseno", true));
            this.zavrsenoRadioButton.Location = new System.Drawing.Point(4, 103);
            this.zavrsenoRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.zavrsenoRadioButton.Name = "zavrsenoRadioButton";
            this.zavrsenoRadioButton.Size = new System.Drawing.Size(110, 25);
            this.zavrsenoRadioButton.TabIndex = 25;
            this.zavrsenoRadioButton.Text = "Završeno";
            this.zavrsenoRadioButton.UseVisualStyleBackColor = true;
            // 
            // korisnikOdbioPlacanjeRadioButton1
            // 
            this.korisnikOdbioPlacanjeRadioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.korisnikOdbioPlacanjeRadioButton1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.naloziPBindingSource, "korisnikOdbioPlacanje", true));
            this.korisnikOdbioPlacanjeRadioButton1.Location = new System.Drawing.Point(122, 137);
            this.korisnikOdbioPlacanjeRadioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.korisnikOdbioPlacanjeRadioButton1.Name = "korisnikOdbioPlacanjeRadioButton1";
            this.korisnikOdbioPlacanjeRadioButton1.Size = new System.Drawing.Size(246, 26);
            this.korisnikOdbioPlacanjeRadioButton1.TabIndex = 25;
            this.korisnikOdbioPlacanjeRadioButton1.Text = "Korisnik odbio da plati";
            this.korisnikOdbioPlacanjeRadioButton1.UseVisualStyleBackColor = true;
            // 
            // servisOdustaoRadioButton
            // 
            this.servisOdustaoRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.servisOdustaoRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.naloziPBindingSource, "servisOdustao", true));
            this.servisOdustaoRadioButton.Location = new System.Drawing.Point(122, 103);
            this.servisOdustaoRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.servisOdustaoRadioButton.Name = "servisOdustaoRadioButton";
            this.servisOdustaoRadioButton.Size = new System.Drawing.Size(246, 25);
            this.servisOdustaoRadioButton.TabIndex = 25;
            this.servisOdustaoRadioButton.Text = "Servis odustao od popravke";
            this.servisOdustaoRadioButton.UseVisualStyleBackColor = true;
            // 
            // korisnikOdustaoRadioButton
            // 
            this.korisnikOdustaoRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.korisnikOdustaoRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.naloziPBindingSource, "korisnikOdustao", true));
            this.korisnikOdustaoRadioButton.Location = new System.Drawing.Point(122, 70);
            this.korisnikOdustaoRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.korisnikOdustaoRadioButton.Name = "korisnikOdustaoRadioButton";
            this.korisnikOdustaoRadioButton.Size = new System.Drawing.Size(246, 25);
            this.korisnikOdustaoRadioButton.TabIndex = 25;
            this.korisnikOdustaoRadioButton.Text = "Korisnik odustao od popravke";
            this.korisnikOdustaoRadioButton.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 80;
            reportDataSource1.Name = "dsNalog";
            reportDataSource1.Value = this.clRadniNalogPrivBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "uclib.Reportovi.repNalogP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1143, 25);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(109, 64);
            this.reportViewer1.TabIndex = 26;
            this.reportViewer1.Visible = false;
            this.reportViewer1.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(this.reportViewer1_RenderingComplete);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(4, 295);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(380, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Korisnik";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.31541F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.68459F));
            this.tableLayoutPanel2.Controls.Add(eMailLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.eMailTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(kontaktLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.kontaktTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(imePrezimeLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.imePrezimeTextBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(372, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.eMailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.naloziPBindingSource, "eMail", true));
            this.eMailTextBox.Location = new System.Drawing.Point(109, 72);
            this.eMailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(259, 22);
            this.eMailTextBox.TabIndex = 3;
            // 
            // kontaktTextBox
            // 
            this.kontaktTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kontaktTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.naloziPBindingSource, "Kontakt", true));
            this.kontaktTextBox.Location = new System.Drawing.Point(109, 38);
            this.kontaktTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.kontaktTextBox.MaxLength = 21;
            this.kontaktTextBox.Name = "kontaktTextBox";
            this.kontaktTextBox.Size = new System.Drawing.Size(259, 22);
            this.kontaktTextBox.TabIndex = 2;
            this.kontaktTextBox.Leave += new System.EventHandler(this.kontaktTextBox_Leave);
            // 
            // imePrezimeTextBox
            // 
            this.imePrezimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.imePrezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.naloziPBindingSource, "imePrezime", true));
            this.imePrezimeTextBox.Location = new System.Drawing.Point(109, 5);
            this.imePrezimeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.imePrezimeTextBox.MaxLength = 24;
            this.imePrezimeTextBox.Name = "imePrezimeTextBox";
            this.imePrezimeTextBox.Size = new System.Drawing.Size(259, 22);
            this.imePrezimeTextBox.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Location = new System.Drawing.Point(392, 96);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(751, 192);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Uređaj";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel3.Controls.Add(serijskiBrojLabel, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.serijskiBrojTextBox, 3, 1);
            this.tableLayoutPanel3.Controls.Add(modelLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.modelTextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(proizvodjacLabel, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.proizvodjacComboBox, 3, 0);
            this.tableLayoutPanel3.Controls.Add(uredjajLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.uredjajComboBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ostaloTextBox, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(743, 169);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.flowLayoutPanel1, 4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(103, 66);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(637, 66);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // serijskiBrojTextBox
            // 
            this.serijskiBrojTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.serijskiBrojTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.naloziPBindingSource, "serijskiBroj", true));
            this.serijskiBrojTextBox.Location = new System.Drawing.Point(401, 35);
            this.serijskiBrojTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.serijskiBrojTextBox.MaxLength = 27;
            this.serijskiBrojTextBox.Name = "serijskiBrojTextBox";
            this.serijskiBrojTextBox.Size = new System.Drawing.Size(220, 22);
            this.serijskiBrojTextBox.TabIndex = 7;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.naloziPBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(103, 35);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.modelTextBox.MaxLength = 27;
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(179, 22);
            this.modelTextBox.TabIndex = 6;
            // 
            // proizvodjacComboBox
            // 
            this.proizvodjacComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.proizvodjacComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.proizvodjacComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.proizvodjacComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.naloziPBindingSource, "Proizvodjac", true));
            this.proizvodjacComboBox.FormattingEnabled = true;
            this.proizvodjacComboBox.Location = new System.Drawing.Point(401, 4);
            this.proizvodjacComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.proizvodjacComboBox.Name = "proizvodjacComboBox";
            this.proizvodjacComboBox.Size = new System.Drawing.Size(220, 24);
            this.proizvodjacComboBox.TabIndex = 5;
            // 
            // uredjajComboBox
            // 
            this.uredjajComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uredjajComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uredjajComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.uredjajComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.naloziPBindingSource, "Uredjaj", true));
            this.uredjajComboBox.FormattingEnabled = true;
            this.uredjajComboBox.Location = new System.Drawing.Point(103, 4);
            this.uredjajComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.uredjajComboBox.Name = "uredjajComboBox";
            this.uredjajComboBox.Size = new System.Drawing.Size(179, 24);
            this.uredjajComboBox.TabIndex = 4;
            // 
            // ostaloTextBox
            // 
            this.ostaloTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.ostaloTextBox, 4);
            this.ostaloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.naloziPBindingSource, "Oprema", true));
            this.ostaloTextBox.Location = new System.Drawing.Point(103, 141);
            this.ostaloTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ostaloTextBox.MaxLength = 64;
            this.ostaloTextBox.Name = "ostaloTextBox";
            this.ostaloTextBox.Size = new System.Drawing.Size(637, 22);
            this.ostaloTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Oprema:";
            // 
            // opisKvaraTextBox
            // 
            this.opisKvaraTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.SetColumnSpan(this.opisKvaraTextBox, 6);
            this.opisKvaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.naloziPBindingSource, "opisKvara", true));
            this.opisKvaraTextBox.Location = new System.Drawing.Point(103, 4);
            this.opisKvaraTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.opisKvaraTextBox.MaxLength = 64;
            this.opisKvaraTextBox.Name = "opisKvaraTextBox";
            this.opisKvaraTextBox.Size = new System.Drawing.Size(637, 22);
            this.opisKvaraTextBox.TabIndex = 9;
            // 
            // izvestajRichTextBox
            // 
            this.izvestajRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.SetColumnSpan(this.izvestajRichTextBox, 6);
            this.izvestajRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.naloziPBindingSource, "Izvestaj", true));
            this.izvestajRichTextBox.Location = new System.Drawing.Point(103, 36);
            this.izvestajRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.izvestajRichTextBox.MaxLength = 330;
            this.izvestajRichTextBox.Name = "izvestajRichTextBox";
            this.izvestajRichTextBox.Size = new System.Drawing.Size(637, 95);
            this.izvestajRichTextBox.TabIndex = 10;
            this.izvestajRichTextBox.Text = "";
            this.izvestajRichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.izvestajRichTextBox_KeyPress);
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
            this.dSacuvaj.TabIndex = 11;
            this.dSacuvaj.Text = "Sačuvaj";
            this.dSacuvaj.UseVisualStyleBackColor = true;
            this.dSacuvaj.Click += new System.EventHandler(this.dSacuvaj_Click);
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
            this.dOtkazi.TabIndex = 13;
            this.dOtkazi.Text = "Otkaži";
            this.dOtkazi.UseVisualStyleBackColor = true;
            this.dOtkazi.Click += new System.EventHandler(this.dOtkazi_Click);
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
            this.dObrisi.TabIndex = 15;
            this.dObrisi.TabStop = false;
            this.dObrisi.Text = "Obriši";
            this.dObrisi.UseVisualStyleBackColor = true;
            this.dObrisi.Click += new System.EventHandler(this.dObrisi_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 562);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pretraga:";
            // 
            // tbPretraga
            // 
            this.tbPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPretraga.Location = new System.Drawing.Point(83, 559);
            this.tbPretraga.Margin = new System.Windows.Forms.Padding(4);
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.Size = new System.Drawing.Size(300, 22);
            this.tbPretraga.TabIndex = 5;
            this.tbPretraga.TabStop = false;
            this.tbPretraga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPretraga_KeyDown);
            // 
            // dStampaj
            // 
            this.dStampaj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dStampaj.Location = new System.Drawing.Point(553, 4);
            this.dStampaj.Margin = new System.Windows.Forms.Padding(4);
            this.dStampaj.Name = "dStampaj";
            this.dStampaj.Size = new System.Drawing.Size(175, 36);
            this.dStampaj.TabIndex = 12;
            this.dStampaj.Text = "Štampaj";
            this.dStampaj.UseVisualStyleBackColor = true;
            this.dStampaj.Click += new System.EventHandler(this.dStampaj_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.dObrisi, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.dSacuvaj, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.dStampaj, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.dOtkazi, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.dNovi, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(131, 36);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(915, 44);
            this.tableLayoutPanel5.TabIndex = 4;
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
            this.dNovi.TabIndex = 14;
            this.dNovi.Text = "Novi nalog";
            this.dNovi.UseVisualStyleBackColor = true;
            this.dNovi.Click += new System.EventHandler(this.dNovi_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel4.Controls.Add(opisKvaraLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.opisKvaraTextBox, 1, 0);
            this.tableLayoutPanel4.Controls.Add(izvestajLabel, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.izvestajRichTextBox, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(743, 168);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.tableLayoutPanel4);
            this.groupBox4.Location = new System.Drawing.Point(392, 295);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(751, 191);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Servis";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filter:";
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Korinsik",
            "Broj Naloga",
            "Uređaj",
            "Izveštaj",
            "Status"});
            this.cbFilter.Location = new System.Drawing.Point(449, 559);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(143, 24);
            this.cbFilter.TabIndex = 7;
            this.cbFilter.TabStop = false;
            // 
            // naloziPTableAdapter
            // 
            this.naloziPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtikliPFOTableAdapter = null;
            this.tableAdapterManager.ArtikliTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FaktureTableAdapter = null;
            this.tableAdapterManager.FirmeTableAdapter = null;
            this.tableAdapterManager.NaloziFTableAdapter = null;
            this.tableAdapterManager.NaloziPTableAdapter = this.naloziPTableAdapter;
            this.tableAdapterManager.OtpremniceTableAdapter = null;
            this.tableAdapterManager.ProfaktureTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = uclib.dbSenaCompDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ucPrivatni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tbPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.naloziPDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucPrivatni";
            this.Size = new System.Drawing.Size(1407, 795);
            this.Load += new System.EventHandler(this.ucPrivatni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clRadniNalogPrivBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naloziPDataGridView)).EndInit();
            this.cmsBaza.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.naloziPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSenaCompDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.cmsBrojNaloga.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbSenaCompDataSet dbSenaCompDataSet;
        private System.Windows.Forms.BindingSource naloziPBindingSource;
        private dbSenaCompDataSetTableAdapters.NaloziPTableAdapter naloziPTableAdapter;
        private dbSenaCompDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView naloziPDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private System.Windows.Forms.TextBox brojNalogaTextBox;
        private System.Windows.Forms.RadioButton naCekanjuRadioButton;
        private System.Windows.Forms.RadioButton zavrsenoRadioButton;
        private System.Windows.Forms.RadioButton servisOdustaoRadioButton;
        private System.Windows.Forms.RadioButton korisnikOdustaoRadioButton;
        private System.Windows.Forms.RadioButton korisnikOdbioPlacanjeRadioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.TextBox kontaktTextBox;
        private System.Windows.Forms.TextBox imePrezimeTextBox;
        private System.Windows.Forms.TextBox serijskiBrojTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox ostaloTextBox;
        private System.Windows.Forms.TextBox opisKvaraTextBox;
        private System.Windows.Forms.RichTextBox izvestajRichTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dSacuvaj;
        private System.Windows.Forms.Button dOtkazi;
        private System.Windows.Forms.Button dObrisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPretraga;
        private System.Windows.Forms.Button dStampaj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button dNovi;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.ComboBox uredjajComboBox;
        public System.Windows.Forms.ComboBox proizvodjacComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ContextMenuStrip cmsBaza;
        private System.Windows.Forms.ToolStripMenuItem napomenaToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaServis;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDelova;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ContextMenuStrip cmsBrojNaloga;
        private System.Windows.Forms.ToolStripMenuItem noviBrojNalogaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniBrojNalogaToolStripMenuItem;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource clRadniNalogPrivBindingSource;
    }
}
