namespace uclib.Ostalo
{
    partial class ucOdabirFirme
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dPretraga = new System.Windows.Forms.Button();
            this.firmeDataGridView = new System.Windows.Forms.DataGridView();
            this.dOK = new System.Windows.Forms.Button();
            this.dOtkazi = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSenaCompDataSet = new uclib.dbSenaCompDataSet();
            this.firmeTableAdapter = new uclib.dbSenaCompDataSetTableAdapters.FirmeTableAdapter();
            this.tableAdapterManager = new uclib.dbSenaCompDataSetTableAdapters.TableAdapterManager();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSenaCompDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pretraga:";
            // 
            // tbPretraga
            // 
            this.tbPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPretraga.Location = new System.Drawing.Point(75, 7);
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.Size = new System.Drawing.Size(177, 20);
            this.tbPretraga.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filter:";
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Sve",
            "ID"});
            this.cbFilter.Location = new System.Drawing.Point(297, 7);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(86, 21);
            this.cbFilter.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.25112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.74888F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbFilter, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPretraga, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dPretraga, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 35);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dPretraga
            // 
            this.dPretraga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dPretraga.Location = new System.Drawing.Point(389, 3);
            this.dPretraga.Name = "dPretraga";
            this.dPretraga.Size = new System.Drawing.Size(37, 29);
            this.dPretraga.TabIndex = 3;
            this.dPretraga.Text = "Pret";
            this.dPretraga.UseVisualStyleBackColor = true;
            this.dPretraga.Click += new System.EventHandler(this.dPretraga_Click);
            // 
            // firmeDataGridView
            // 
            this.firmeDataGridView.AllowUserToAddRows = false;
            this.firmeDataGridView.AllowUserToDeleteRows = false;
            this.firmeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firmeDataGridView.AutoGenerateColumns = false;
            this.firmeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.firmeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firmeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.firmeDataGridView.DataSource = this.firmeBindingSource;
            this.firmeDataGridView.Location = new System.Drawing.Point(3, 44);
            this.firmeDataGridView.Name = "firmeDataGridView";
            this.firmeDataGridView.ReadOnly = true;
            this.firmeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.firmeDataGridView.Size = new System.Drawing.Size(853, 230);
            this.firmeDataGridView.TabIndex = 4;
            this.firmeDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.firmeDataGridView_CellDoubleClick);
            // 
            // dOK
            // 
            this.dOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.dOK.Location = new System.Drawing.Point(3, 280);
            this.dOK.Name = "dOK";
            this.dOK.Size = new System.Drawing.Size(75, 23);
            this.dOK.TabIndex = 5;
            this.dOK.Text = "OK";
            this.dOK.UseVisualStyleBackColor = true;
            this.dOK.Click += new System.EventHandler(this.dOK_Click);
            // 
            // dOtkazi
            // 
            this.dOtkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dOtkazi.Location = new System.Drawing.Point(84, 280);
            this.dOtkazi.Name = "dOtkazi";
            this.dOtkazi.Size = new System.Drawing.Size(75, 23);
            this.dOtkazi.TabIndex = 5;
            this.dOtkazi.Text = "Otkaži";
            this.dOtkazi.UseVisualStyleBackColor = true;
            this.dOtkazi.Click += new System.EventHandler(this.dOtkazi_Click);
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
            this.dataGridViewTextBoxColumn5.HeaderText = "Ulica i broj";
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
            // ucOdabirFirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dOtkazi);
            this.Controls.Add(this.dOK);
            this.Controls.Add(this.firmeDataGridView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucOdabirFirme";
            this.Size = new System.Drawing.Size(859, 306);
            this.Load += new System.EventHandler(this.ucOdabirFirme_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSenaCompDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button dPretraga;
        private dbSenaCompDataSet dbSenaCompDataSet;
        private System.Windows.Forms.BindingSource firmeBindingSource;
        private dbSenaCompDataSetTableAdapters.FirmeTableAdapter firmeTableAdapter;
        private dbSenaCompDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView firmeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button dOK;
        private System.Windows.Forms.Button dOtkazi;
    }
}
