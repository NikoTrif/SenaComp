﻿namespace uclib.Racuni
{
    partial class ucProfakture
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
            System.Windows.Forms.Label redniBrojLabel;
            System.Windows.Forms.Label datumLabel;
            System.Windows.Forms.Label valutaLabel;
            System.Windows.Forms.Label datumIsplateLabel;
            System.Windows.Forms.Label iDKlijentaLabel;
            System.Windows.Forms.Label klijentLabel;
            System.Windows.Forms.Label pIBLabel;
            System.Windows.Forms.Label matBrojLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label gradLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dNovi = new System.Windows.Forms.Button();
            this.dOtkazi = new System.Windows.Forms.Button();
            this.dSacuvaj = new System.Windows.Forms.Button();
            this.dStampaj = new System.Windows.Forms.Button();
            this.dObrisi = new System.Windows.Forms.Button();
            this.profaktureDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PIB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumIsplate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profaktureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSenaCompDataSet = new uclib.dbSenaCompDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.datumIsplateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.valutaTextBox = new System.Windows.Forms.TextBox();
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.redniBrojTextBox = new System.Windows.Forms.TextBox();
            this.rbPlaceno = new System.Windows.Forms.RadioButton();
            this.rbNaCekanju = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dFaktura = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gradTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.matBrojTextBox = new System.Windows.Forms.TextBox();
            this.pIBTextBox = new System.Windows.Forms.TextBox();
            this.klijentTextBox = new System.Windows.Forms.TextBox();
            this.iDKlijentaTextBox = new System.Windows.Forms.TextBox();
            this.dOdaberi = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tbArtProfPret = new System.Windows.Forms.TextBox();
            this.dArtUkloni = new System.Windows.Forms.Button();
            this.dgvProfArtikli = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IzPDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicaMere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaPDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.artikliDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznosPDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbArtPret = new System.Windows.Forms.TextBox();
            this.dArtDodaj = new System.Windows.Forms.Button();
            this.tbArtKol = new System.Windows.Forms.TextBox();
            this.profaktureTableAdapter = new uclib.dbSenaCompDataSetTableAdapters.ProfaktureTableAdapter();
            this.tableAdapterManager = new uclib.dbSenaCompDataSetTableAdapters.TableAdapterManager();
            this.artikliTableAdapter = new uclib.dbSenaCompDataSetTableAdapters.ArtikliTableAdapter();
            redniBrojLabel = new System.Windows.Forms.Label();
            datumLabel = new System.Windows.Forms.Label();
            valutaLabel = new System.Windows.Forms.Label();
            datumIsplateLabel = new System.Windows.Forms.Label();
            iDKlijentaLabel = new System.Windows.Forms.Label();
            klijentLabel = new System.Windows.Forms.Label();
            pIBLabel = new System.Windows.Forms.Label();
            matBrojLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            gradLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profaktureDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profaktureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSenaCompDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfArtikli)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artikliDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // redniBrojLabel
            // 
            redniBrojLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            redniBrojLabel.AutoSize = true;
            redniBrojLabel.Location = new System.Drawing.Point(3, 8);
            redniBrojLabel.Name = "redniBrojLabel";
            redniBrojLabel.Size = new System.Drawing.Size(118, 17);
            redniBrojLabel.TabIndex = 0;
            redniBrojLabel.Text = "Redni broj:";
            // 
            // datumLabel
            // 
            datumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            datumLabel.AutoSize = true;
            datumLabel.Location = new System.Drawing.Point(3, 42);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(118, 17);
            datumLabel.TabIndex = 2;
            datumLabel.Text = "Datum:";
            // 
            // valutaLabel
            // 
            valutaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            valutaLabel.AutoSize = true;
            valutaLabel.Location = new System.Drawing.Point(3, 76);
            valutaLabel.Name = "valutaLabel";
            valutaLabel.Size = new System.Drawing.Size(118, 17);
            valutaLabel.TabIndex = 4;
            valutaLabel.Text = "Valuta:";
            // 
            // datumIsplateLabel
            // 
            datumIsplateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            datumIsplateLabel.AutoSize = true;
            datumIsplateLabel.Location = new System.Drawing.Point(3, 146);
            datumIsplateLabel.Name = "datumIsplateLabel";
            datumIsplateLabel.Size = new System.Drawing.Size(118, 17);
            datumIsplateLabel.TabIndex = 8;
            datumIsplateLabel.Text = "Datum isplate:";
            // 
            // iDKlijentaLabel
            // 
            iDKlijentaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            iDKlijentaLabel.AutoSize = true;
            iDKlijentaLabel.Location = new System.Drawing.Point(3, 8);
            iDKlijentaLabel.Name = "iDKlijentaLabel";
            iDKlijentaLabel.Size = new System.Drawing.Size(118, 17);
            iDKlijentaLabel.TabIndex = 0;
            iDKlijentaLabel.Text = "ID kijenta:";
            // 
            // klijentLabel
            // 
            klijentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            klijentLabel.AutoSize = true;
            klijentLabel.Location = new System.Drawing.Point(3, 42);
            klijentLabel.Name = "klijentLabel";
            klijentLabel.Size = new System.Drawing.Size(118, 17);
            klijentLabel.TabIndex = 2;
            klijentLabel.Text = "Klijent:";
            // 
            // pIBLabel
            // 
            pIBLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            pIBLabel.AutoSize = true;
            pIBLabel.Location = new System.Drawing.Point(3, 76);
            pIBLabel.Name = "pIBLabel";
            pIBLabel.Size = new System.Drawing.Size(118, 17);
            pIBLabel.TabIndex = 4;
            pIBLabel.Text = "PIB:";
            // 
            // matBrojLabel
            // 
            matBrojLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            matBrojLabel.AutoSize = true;
            matBrojLabel.Location = new System.Drawing.Point(3, 110);
            matBrojLabel.Name = "matBrojLabel";
            matBrojLabel.Size = new System.Drawing.Size(118, 17);
            matBrojLabel.TabIndex = 6;
            matBrojLabel.Text = "Matični broj:";
            // 
            // adresaLabel
            // 
            adresaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            adresaLabel.AutoSize = true;
            adresaLabel.Location = new System.Drawing.Point(3, 144);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(118, 17);
            adresaLabel.TabIndex = 8;
            adresaLabel.Text = "Adresa:";
            // 
            // gradLabel
            // 
            gradLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            gradLabel.AutoSize = true;
            gradLabel.Location = new System.Drawing.Point(3, 181);
            gradLabel.Name = "gradLabel";
            gradLabel.Size = new System.Drawing.Size(118, 17);
            gradLabel.TabIndex = 10;
            gradLabel.Text = "Grad:";
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
            this.tableLayoutPanel1.Controls.Add(this.dStampaj, 3, 0);
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
            this.dNovi.TabIndex = 15;
            this.dNovi.Text = "Novi nalog";
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
            this.dOtkazi.TabIndex = 14;
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
            this.dSacuvaj.TabIndex = 12;
            this.dSacuvaj.Text = "Sačuvaj";
            this.dSacuvaj.UseVisualStyleBackColor = true;
            this.dSacuvaj.Click += new System.EventHandler(this.dSacuvaj_Click);
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
            this.dStampaj.TabIndex = 13;
            this.dStampaj.Text = "Štampaj";
            this.dStampaj.UseVisualStyleBackColor = true;
            this.dStampaj.Click += new System.EventHandler(this.dStampaj_Click);
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
            this.dObrisi.TabIndex = 16;
            this.dObrisi.Text = "Obriši";
            this.dObrisi.UseVisualStyleBackColor = true;
            this.dObrisi.Click += new System.EventHandler(this.dObrisi_Click);
            // 
            // profaktureDataGridView
            // 
            this.profaktureDataGridView.AllowUserToAddRows = false;
            this.profaktureDataGridView.AllowUserToDeleteRows = false;
            this.profaktureDataGridView.AutoGenerateColumns = false;
            this.profaktureDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.profaktureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profaktureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.PIB,
            this.matBroj,
            this.Adresa,
            this.Grad,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Status,
            this.datumIsplate});
            this.profaktureDataGridView.DataSource = this.profaktureBindingSource;
            this.profaktureDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.profaktureDataGridView.Location = new System.Drawing.Point(0, 598);
            this.profaktureDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profaktureDataGridView.MultiSelect = false;
            this.profaktureDataGridView.Name = "profaktureDataGridView";
            this.profaktureDataGridView.ReadOnly = true;
            this.profaktureDataGridView.RowTemplate.Height = 24;
            this.profaktureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.profaktureDataGridView.Size = new System.Drawing.Size(1407, 204);
            this.profaktureDataGridView.TabIndex = 3;
            this.profaktureDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.profaktureDataGridView_CellEnter);
            this.profaktureDataGridView.SelectionChanged += new System.EventHandler(this.profaktureDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "redniBroj";
            this.dataGridViewTextBoxColumn1.HeaderText = "Redni broj";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 102;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn2.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IDKlijenta";
            this.dataGridViewTextBoxColumn7.HeaderText = "IDKlijenta";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Klijent";
            this.dataGridViewTextBoxColumn8.HeaderText = "Klijent";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // PIB
            // 
            this.PIB.DataPropertyName = "PIB";
            this.PIB.HeaderText = "PIB";
            this.PIB.Name = "PIB";
            this.PIB.ReadOnly = true;
            this.PIB.Visible = false;
            // 
            // matBroj
            // 
            this.matBroj.DataPropertyName = "matBroj";
            this.matBroj.HeaderText = "matBroj";
            this.matBroj.Name = "matBroj";
            this.matBroj.ReadOnly = true;
            this.matBroj.Visible = false;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            this.Adresa.Visible = false;
            // 
            // Grad
            // 
            this.Grad.DataPropertyName = "Grad";
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            this.Grad.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Valuta";
            this.dataGridViewTextBoxColumn3.HeaderText = "Valuta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Roba";
            this.dataGridViewTextBoxColumn4.HeaderText = "Roba";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ukupno";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ukupna cena";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Klauzule";
            this.dataGridViewTextBoxColumn6.HeaderText = "Klauzule";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // datumIsplate
            // 
            this.datumIsplate.DataPropertyName = "datumIsplate";
            this.datumIsplate.HeaderText = "datumIsplate";
            this.datumIsplate.Name = "datumIsplate";
            this.datumIsplate.ReadOnly = true;
            this.datumIsplate.Visible = false;
            // 
            // profaktureBindingSource
            // 
            this.profaktureBindingSource.DataMember = "Profakture";
            this.profaktureBindingSource.DataSource = this.dbSenaCompDataSet;
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
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(4, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(380, 192);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profaktura";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.datumIsplateDateTimePicker, 1, 4);
            this.tableLayoutPanel2.Controls.Add(valutaLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.valutaTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(datumLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.datumDateTimePicker, 1, 1);
            this.tableLayoutPanel2.Controls.Add(redniBrojLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.redniBrojTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(datumIsplateLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.rbPlaceno, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.rbNaCekanju, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.dFaktura, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(374, 173);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // datumIsplateDateTimePicker
            // 
            this.datumIsplateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.datumIsplateDateTimePicker, 2);
            this.datumIsplateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.profaktureBindingSource, "datumIsplate", true));
            this.datumIsplateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumIsplateDateTimePicker.Location = new System.Drawing.Point(127, 143);
            this.datumIsplateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datumIsplateDateTimePicker.Name = "datumIsplateDateTimePicker";
            this.datumIsplateDateTimePicker.Size = new System.Drawing.Size(244, 22);
            this.datumIsplateDateTimePicker.TabIndex = 9;
            // 
            // valutaTextBox
            // 
            this.valutaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.valutaTextBox, 2);
            this.valutaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profaktureBindingSource, "Valuta", true));
            this.valutaTextBox.Location = new System.Drawing.Point(127, 74);
            this.valutaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valutaTextBox.Name = "valutaTextBox";
            this.valutaTextBox.Size = new System.Drawing.Size(244, 22);
            this.valutaTextBox.TabIndex = 5;
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.datumDateTimePicker, 2);
            this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.profaktureBindingSource, "Datum", true));
            this.datumDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDateTimePicker.Location = new System.Drawing.Point(127, 40);
            this.datumDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(244, 22);
            this.datumDateTimePicker.TabIndex = 3;
            // 
            // redniBrojTextBox
            // 
            this.redniBrojTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.redniBrojTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profaktureBindingSource, "redniBroj", true));
            this.redniBrojTextBox.Location = new System.Drawing.Point(127, 6);
            this.redniBrojTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.redniBrojTextBox.Name = "redniBrojTextBox";
            this.redniBrojTextBox.ReadOnly = true;
            this.redniBrojTextBox.Size = new System.Drawing.Size(118, 22);
            this.redniBrojTextBox.TabIndex = 1;
            // 
            // rbPlaceno
            // 
            this.rbPlaceno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbPlaceno.AutoSize = true;
            this.rbPlaceno.Location = new System.Drawing.Point(251, 108);
            this.rbPlaceno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPlaceno.Name = "rbPlaceno";
            this.rbPlaceno.Size = new System.Drawing.Size(120, 21);
            this.rbPlaceno.TabIndex = 6;
            this.rbPlaceno.TabStop = true;
            this.rbPlaceno.Text = "Plaćeno";
            this.rbPlaceno.UseVisualStyleBackColor = true;
            this.rbPlaceno.CheckedChanged += new System.EventHandler(this.rbPlaceno_CheckedChanged);
            // 
            // rbNaCekanju
            // 
            this.rbNaCekanju.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNaCekanju.AutoSize = true;
            this.rbNaCekanju.Location = new System.Drawing.Point(127, 108);
            this.rbNaCekanju.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNaCekanju.Name = "rbNaCekanju";
            this.rbNaCekanju.Size = new System.Drawing.Size(118, 21);
            this.rbNaCekanju.TabIndex = 6;
            this.rbNaCekanju.TabStop = true;
            this.rbNaCekanju.Text = "Na čekanju";
            this.rbNaCekanju.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Status:";
            // 
            // dFaktura
            // 
            this.dFaktura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dFaktura.Location = new System.Drawing.Point(251, 2);
            this.dFaktura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dFaktura.Name = "dFaktura";
            this.dFaktura.Size = new System.Drawing.Size(120, 30);
            this.dFaktura.TabIndex = 12;
            this.dFaktura.Text = "Napravi Fakturu";
            this.dFaktura.UseVisualStyleBackColor = true;
            this.dFaktura.Click += new System.EventHandler(this.dFaktura_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Location = new System.Drawing.Point(4, 295);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(380, 229);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Klijent";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(gradLabel, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.gradTextBox, 1, 5);
            this.tableLayoutPanel3.Controls.Add(adresaLabel, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.adresaTextBox, 1, 4);
            this.tableLayoutPanel3.Controls.Add(matBrojLabel, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.matBrojTextBox, 1, 3);
            this.tableLayoutPanel3.Controls.Add(pIBLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.pIBTextBox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(klijentLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.klijentTextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(iDKlijentaLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.iDKlijentaTextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dOdaberi, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(374, 210);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // gradTextBox
            // 
            this.gradTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.gradTextBox, 2);
            this.gradTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profaktureBindingSource, "Grad", true));
            this.gradTextBox.Location = new System.Drawing.Point(127, 179);
            this.gradTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradTextBox.Name = "gradTextBox";
            this.gradTextBox.Size = new System.Drawing.Size(244, 22);
            this.gradTextBox.TabIndex = 11;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.adresaTextBox, 2);
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profaktureBindingSource, "Adresa", true));
            this.adresaTextBox.Location = new System.Drawing.Point(127, 142);
            this.adresaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(244, 22);
            this.adresaTextBox.TabIndex = 9;
            // 
            // matBrojTextBox
            // 
            this.matBrojTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.matBrojTextBox, 2);
            this.matBrojTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profaktureBindingSource, "matBroj", true));
            this.matBrojTextBox.Location = new System.Drawing.Point(127, 108);
            this.matBrojTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.matBrojTextBox.Name = "matBrojTextBox";
            this.matBrojTextBox.Size = new System.Drawing.Size(244, 22);
            this.matBrojTextBox.TabIndex = 7;
            // 
            // pIBTextBox
            // 
            this.pIBTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.pIBTextBox, 2);
            this.pIBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profaktureBindingSource, "PIB", true));
            this.pIBTextBox.Location = new System.Drawing.Point(127, 74);
            this.pIBTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pIBTextBox.Name = "pIBTextBox";
            this.pIBTextBox.Size = new System.Drawing.Size(244, 22);
            this.pIBTextBox.TabIndex = 5;
            // 
            // klijentTextBox
            // 
            this.klijentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.klijentTextBox, 2);
            this.klijentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profaktureBindingSource, "Klijent", true));
            this.klijentTextBox.Location = new System.Drawing.Point(127, 40);
            this.klijentTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.klijentTextBox.Name = "klijentTextBox";
            this.klijentTextBox.Size = new System.Drawing.Size(244, 22);
            this.klijentTextBox.TabIndex = 3;
            // 
            // iDKlijentaTextBox
            // 
            this.iDKlijentaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iDKlijentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profaktureBindingSource, "IDKlijenta", true));
            this.iDKlijentaTextBox.Location = new System.Drawing.Point(127, 6);
            this.iDKlijentaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iDKlijentaTextBox.Name = "iDKlijentaTextBox";
            this.iDKlijentaTextBox.Size = new System.Drawing.Size(118, 22);
            this.iDKlijentaTextBox.TabIndex = 1;
            // 
            // dOdaberi
            // 
            this.dOdaberi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dOdaberi.Location = new System.Drawing.Point(251, 2);
            this.dOdaberi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dOdaberi.Name = "dOdaberi";
            this.dOdaberi.Size = new System.Drawing.Size(120, 30);
            this.dOdaberi.TabIndex = 12;
            this.dOdaberi.Text = "Odaberi";
            this.dOdaberi.UseVisualStyleBackColor = true;
            this.dOdaberi.Click += new System.EventHandler(this.dOdaberi_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Klijent",
            "Broj profakture",
            "ID Klijenta",
            "Datum"});
            this.cbFilter.Location = new System.Drawing.Point(429, 569);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(143, 24);
            this.cbFilter.TabIndex = 23;
            this.cbFilter.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Filter:";
            // 
            // tbPretraga
            // 
            this.tbPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPretraga.Location = new System.Drawing.Point(79, 570);
            this.tbPretraga.Margin = new System.Windows.Forms.Padding(4);
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.Size = new System.Drawing.Size(300, 22);
            this.tbPretraga.TabIndex = 21;
            this.tbPretraga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPretraga_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 574);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Pretraga:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Location = new System.Drawing.Point(389, 96);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(751, 428);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Artikli";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(745, 409);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.tbArtProfPret, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.dArtUkloni, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.dgvProfArtikli, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.lTotal, 3, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 206);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(739, 201);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // tbArtProfPret
            // 
            this.tbArtProfPret.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbArtProfPret.Location = new System.Drawing.Point(3, 6);
            this.tbArtProfPret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbArtProfPret.Name = "tbArtProfPret";
            this.tbArtProfPret.Size = new System.Drawing.Size(314, 22);
            this.tbArtProfPret.TabIndex = 0;
            this.tbArtProfPret.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbArtProfPret_KeyDown);
            // 
            // dArtUkloni
            // 
            this.dArtUkloni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dArtUkloni.Location = new System.Drawing.Point(323, 2);
            this.dArtUkloni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dArtUkloni.Name = "dArtUkloni";
            this.dArtUkloni.Size = new System.Drawing.Size(69, 30);
            this.dArtUkloni.TabIndex = 1;
            this.dArtUkloni.Text = "Ukoni";
            this.dArtUkloni.UseVisualStyleBackColor = true;
            this.dArtUkloni.Click += new System.EventHandler(this.dArtUkloni_Click);
            // 
            // dgvProfArtikli
            // 
            this.dgvProfArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfArtikli.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProfArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Cena,
            this.PDV,
            this.IzPDV,
            this.Kolicina,
            this.jedinicaMere,
            this.UkupnaCena,
            this.CenaPDV});
            this.tableLayoutPanel6.SetColumnSpan(this.dgvProfArtikli, 4);
            this.dgvProfArtikli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProfArtikli.Location = new System.Drawing.Point(3, 36);
            this.dgvProfArtikli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProfArtikli.Name = "dgvProfArtikli";
            this.dgvProfArtikli.RowTemplate.Height = 24;
            this.dgvProfArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfArtikli.Size = new System.Drawing.Size(733, 163);
            this.dgvProfArtikli.TabIndex = 2;
            this.dgvProfArtikli.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfArtikli_CellEnter);
            this.dgvProfArtikli.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfArtikli_CellValidated);
            this.dgvProfArtikli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProfArtikli_KeyDown);
            // 
            // Naziv
            // 
            this.Naziv.FillWeight = 176.6497F;
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Cena
            // 
            this.Cena.FillWeight = 84.67005F;
            this.Cena.HeaderText = "Cena";
            this.Cena.Name = "Cena";
            // 
            // PDV
            // 
            this.PDV.FillWeight = 84.67005F;
            this.PDV.HeaderText = "PDV";
            this.PDV.Name = "PDV";
            // 
            // IzPDV
            // 
            this.IzPDV.HeaderText = "Iznos PDV";
            this.IzPDV.Name = "IzPDV";
            // 
            // Kolicina
            // 
            this.Kolicina.FillWeight = 84.67005F;
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            // 
            // jedinicaMere
            // 
            this.jedinicaMere.FillWeight = 84.67005F;
            this.jedinicaMere.HeaderText = "Jedinica mere";
            this.jedinicaMere.Name = "jedinicaMere";
            // 
            // UkupnaCena
            // 
            this.UkupnaCena.FillWeight = 84.67005F;
            this.UkupnaCena.HeaderText = "Ukupna Cena";
            this.UkupnaCena.Name = "UkupnaCena";
            // 
            // CenaPDV
            // 
            this.CenaPDV.HeaderText = "CenaPDV";
            this.CenaPDV.Name = "CenaPDV";
            this.CenaPDV.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(398, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "TOTAL:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lTotal
            // 
            this.lTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lTotal.AutoSize = true;
            this.lTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotal.Location = new System.Drawing.Point(570, 4);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(166, 25);
            this.lTotal.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoScroll = true;
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.tableLayoutPanel5.Controls.Add(this.artikliDataGridView, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tbArtPret, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.dArtDodaj, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.tbArtKol, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(739, 200);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // artikliDataGridView
            // 
            this.artikliDataGridView.AllowUserToAddRows = false;
            this.artikliDataGridView.AllowUserToDeleteRows = false;
            this.artikliDataGridView.AutoGenerateColumns = false;
            this.artikliDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.artikliDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artikliDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn12,
            this.IznosPDV,
            this.dataGridViewTextBoxColumn13});
            this.tableLayoutPanel5.SetColumnSpan(this.artikliDataGridView, 4);
            this.artikliDataGridView.DataSource = this.artikliBindingSource;
            this.artikliDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artikliDataGridView.Location = new System.Drawing.Point(3, 36);
            this.artikliDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.artikliDataGridView.MultiSelect = false;
            this.artikliDataGridView.Name = "artikliDataGridView";
            this.artikliDataGridView.ReadOnly = true;
            this.artikliDataGridView.RowTemplate.Height = 24;
            this.artikliDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.artikliDataGridView.Size = new System.Drawing.Size(735, 162);
            this.artikliDataGridView.TabIndex = 2;
            this.artikliDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.artikliDataGridView_CellDoubleClick);
            this.artikliDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.artikliDataGridView_KeyDown);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Sifra";
            this.dataGridViewTextBoxColumn9.FillWeight = 82.31811F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Sifra";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn10.FillWeight = 206.0914F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "jedinicaMere";
            this.dataGridViewTextBoxColumn11.FillWeight = 82.31811F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Jedinica mere";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Usluga";
            this.dataGridViewCheckBoxColumn1.FillWeight = 82.31811F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Usluga";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Cena";
            this.dataGridViewTextBoxColumn14.FillWeight = 82.31811F;
            this.dataGridViewTextBoxColumn14.HeaderText = "Cena";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "PDV";
            this.dataGridViewTextBoxColumn12.FillWeight = 82.31811F;
            this.dataGridViewTextBoxColumn12.HeaderText = "PDV";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // IznosPDV
            // 
            this.IznosPDV.DataPropertyName = "IznosPDV";
            this.IznosPDV.HeaderText = "IznosPDV";
            this.IznosPDV.Name = "IznosPDV";
            this.IznosPDV.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "prodajnaCena";
            this.dataGridViewTextBoxColumn13.FillWeight = 82.31811F;
            this.dataGridViewTextBoxColumn13.HeaderText = "Cena sa PDV-om";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "Artikli";
            this.artikliBindingSource.DataSource = this.dbSenaCompDataSet;
            // 
            // tbArtPret
            // 
            this.tbArtPret.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbArtPret.Location = new System.Drawing.Point(3, 6);
            this.tbArtPret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbArtPret.Name = "tbArtPret";
            this.tbArtPret.Size = new System.Drawing.Size(314, 22);
            this.tbArtPret.TabIndex = 0;
            this.tbArtPret.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbArtPret_KeyDown);
            this.tbArtPret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbArtPret_KeyPress);
            // 
            // dArtDodaj
            // 
            this.dArtDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dArtDodaj.Location = new System.Drawing.Point(418, 2);
            this.dArtDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dArtDodaj.Name = "dArtDodaj";
            this.dArtDodaj.Size = new System.Drawing.Size(69, 30);
            this.dArtDodaj.TabIndex = 1;
            this.dArtDodaj.Text = "Dodaj";
            this.dArtDodaj.UseVisualStyleBackColor = true;
            this.dArtDodaj.Click += new System.EventHandler(this.dArtDodaj_Click);
            // 
            // tbArtKol
            // 
            this.tbArtKol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbArtKol.Location = new System.Drawing.Point(323, 6);
            this.tbArtKol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbArtKol.Name = "tbArtKol";
            this.tbArtKol.Size = new System.Drawing.Size(89, 22);
            this.tbArtKol.TabIndex = 3;
            this.tbArtKol.Text = "1";
            this.tbArtKol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbArtKol_KeyDown);
            this.tbArtKol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbArtKol_KeyPress);
            // 
            // profaktureTableAdapter
            // 
            this.profaktureTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtikliPFOTableAdapter = null;
            this.tableAdapterManager.ArtikliTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FaktureTableAdapter = null;
            this.tableAdapterManager.FirmeTableAdapter = null;
            this.tableAdapterManager.NaloziFTableAdapter = null;
            this.tableAdapterManager.NaloziPTableAdapter = null;
            this.tableAdapterManager.OtpremniceTableAdapter = null;
            this.tableAdapterManager.ProfaktureTableAdapter = this.profaktureTableAdapter;
            this.tableAdapterManager.UpdateOrder = uclib.dbSenaCompDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // ucProfakture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPretraga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.profaktureDataGridView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucProfakture";
            this.Size = new System.Drawing.Size(1407, 802);
            this.Load += new System.EventHandler(this.ucProfakture_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profaktureDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profaktureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSenaCompDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfArtikli)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artikliDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button dNovi;
        private System.Windows.Forms.Button dOtkazi;
        private System.Windows.Forms.Button dSacuvaj;
        private System.Windows.Forms.Button dStampaj;
        private System.Windows.Forms.Button dObrisi;
        private dbSenaCompDataSet dbSenaCompDataSet;
        private System.Windows.Forms.BindingSource profaktureBindingSource;
        private dbSenaCompDataSetTableAdapters.ProfaktureTableAdapter profaktureTableAdapter;
        private dbSenaCompDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView profaktureDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox valutaTextBox;
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private System.Windows.Forms.TextBox redniBrojTextBox;
        private System.Windows.Forms.DateTimePicker datumIsplateDateTimePicker;
        private System.Windows.Forms.RadioButton rbPlaceno;
        private System.Windows.Forms.RadioButton rbNaCekanju;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox gradTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox matBrojTextBox;
        private System.Windows.Forms.TextBox pIBTextBox;
        private System.Windows.Forms.TextBox klijentTextBox;
        private System.Windows.Forms.TextBox iDKlijentaTextBox;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox tbArtProfPret;
        private System.Windows.Forms.Button dArtUkloni;
        private System.Windows.Forms.DataGridView dgvProfArtikli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView artikliDataGridView;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private System.Windows.Forms.TextBox tbArtPret;
        private System.Windows.Forms.Button dArtDodaj;
        private dbSenaCompDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private System.Windows.Forms.Button dFaktura;
        private System.Windows.Forms.Button dOdaberi;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumIsplate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn matBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox tbArtKol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IzPDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosPDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaPDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaCena;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicaMere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
    }
}
