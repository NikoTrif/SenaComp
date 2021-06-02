namespace uclib.Racuni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProfakture));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dNovi = new System.Windows.Forms.Button();
            this.dOtkazi = new System.Windows.Forms.Button();
            this.dSacuvaj = new System.Windows.Forms.Button();
            this.dStampaj = new System.Windows.Forms.Button();
            this.dObrisi = new System.Windows.Forms.Button();
            this.dbSenaCompDataSet = new uclib.dbSenaCompDataSet();
            this.profaktureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profaktureTableAdapter = new uclib.dbSenaCompDataSetTableAdapters.ProfaktureTableAdapter();
            this.tableAdapterManager = new uclib.dbSenaCompDataSetTableAdapters.TableAdapterManager();
            this.profaktureBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.profaktureBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.profaktureDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbSenaCompDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profaktureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profaktureBindingNavigator)).BeginInit();
            this.profaktureBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profaktureDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // 
            // dbSenaCompDataSet
            // 
            this.dbSenaCompDataSet.DataSetName = "dbSenaCompDataSet";
            this.dbSenaCompDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profaktureBindingSource
            // 
            this.profaktureBindingSource.DataMember = "Profakture";
            this.profaktureBindingSource.DataSource = this.dbSenaCompDataSet;
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
            // profaktureBindingNavigator
            // 
            this.profaktureBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.profaktureBindingNavigator.BindingSource = this.profaktureBindingSource;
            this.profaktureBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.profaktureBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.profaktureBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.profaktureBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.profaktureBindingNavigatorSaveItem});
            this.profaktureBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.profaktureBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.profaktureBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.profaktureBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.profaktureBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.profaktureBindingNavigator.Name = "profaktureBindingNavigator";
            this.profaktureBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.profaktureBindingNavigator.Size = new System.Drawing.Size(1407, 27);
            this.profaktureBindingNavigator.TabIndex = 3;
            this.profaktureBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // profaktureBindingNavigatorSaveItem
            // 
            this.profaktureBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.profaktureBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("profaktureBindingNavigatorSaveItem.Image")));
            this.profaktureBindingNavigatorSaveItem.Name = "profaktureBindingNavigatorSaveItem";
            this.profaktureBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.profaktureBindingNavigatorSaveItem.Text = "Save Data";
            this.profaktureBindingNavigatorSaveItem.Click += new System.EventHandler(this.profaktureBindingNavigatorSaveItem_Click);
            // 
            // profaktureDataGridView
            // 
            this.profaktureDataGridView.AutoGenerateColumns = false;
            this.profaktureDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.profaktureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profaktureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.profaktureDataGridView.DataSource = this.profaktureBindingSource;
            this.profaktureDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.profaktureDataGridView.Location = new System.Drawing.Point(0, 522);
            this.profaktureDataGridView.MultiSelect = false;
            this.profaktureDataGridView.Name = "profaktureDataGridView";
            this.profaktureDataGridView.RowTemplate.Height = 24;
            this.profaktureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.profaktureDataGridView.Size = new System.Drawing.Size(1407, 273);
            this.profaktureDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "redniBroj";
            this.dataGridViewTextBoxColumn1.HeaderText = "Redni Broj";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn2.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Valuta";
            this.dataGridViewTextBoxColumn3.HeaderText = "Valuta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Kupac";
            this.dataGridViewTextBoxColumn4.HeaderText = "Kupac";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Roba";
            this.dataGridViewTextBoxColumn5.HeaderText = "Roba";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ukupno";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ukupno";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Klauzule";
            this.dataGridViewTextBoxColumn7.HeaderText = "Klauzule";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // ucProfakture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.profaktureDataGridView);
            this.Controls.Add(this.profaktureBindingNavigator);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucProfakture";
            this.Size = new System.Drawing.Size(1407, 795);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbSenaCompDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profaktureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profaktureBindingNavigator)).EndInit();
            this.profaktureBindingNavigator.ResumeLayout(false);
            this.profaktureBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profaktureDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingNavigator profaktureBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton profaktureBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView profaktureDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}
