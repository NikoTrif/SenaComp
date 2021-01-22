namespace uclib.Opcije.Osnovno
{
    partial class ucUredjaji
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
            this.lbUredjaji = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUredjaj = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dUrDodaj = new System.Windows.Forms.Button();
            this.dUrObrisi = new System.Windows.Forms.Button();
            this.lbProizvodjaci = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProizvodjac = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dPrDodaj = new System.Windows.Forms.Button();
            this.dPrObrisi = new System.Windows.Forms.Button();
            this.dApply = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUredjaji
            // 
            this.lbUredjaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUredjaji.FormattingEnabled = true;
            this.lbUredjaji.ItemHeight = 17;
            this.lbUredjaji.Location = new System.Drawing.Point(13, 86);
            this.lbUredjaji.Name = "lbUredjaji";
            this.lbUredjaji.Size = new System.Drawing.Size(183, 378);
            this.lbUredjaji.Sorted = true;
            this.lbUredjaji.TabIndex = 0;
            this.lbUredjaji.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbUredjaji_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uređaj:";
            // 
            // tbUredjaj
            // 
            this.tbUredjaj.Location = new System.Drawing.Point(60, 30);
            this.tbUredjaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUredjaj.Name = "tbUredjaj";
            this.tbUredjaj.Size = new System.Drawing.Size(137, 20);
            this.tbUredjaj.TabIndex = 2;
            this.tbUredjaj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUredjaj_KeyDown);
            this.tbUredjaj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUredjaj_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dUrDodaj, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dUrObrisi, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 53);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(180, 28);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dUrDodaj
            // 
            this.dUrDodaj.Location = new System.Drawing.Point(2, 2);
            this.dUrDodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dUrDodaj.Name = "dUrDodaj";
            this.dUrDodaj.Size = new System.Drawing.Size(86, 23);
            this.dUrDodaj.TabIndex = 0;
            this.dUrDodaj.Text = "Dodaj";
            this.dUrDodaj.UseVisualStyleBackColor = true;
            this.dUrDodaj.Click += new System.EventHandler(this.dUrDodaj_Click);
            // 
            // dUrObrisi
            // 
            this.dUrObrisi.Location = new System.Drawing.Point(92, 2);
            this.dUrObrisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dUrObrisi.Name = "dUrObrisi";
            this.dUrObrisi.Size = new System.Drawing.Size(86, 23);
            this.dUrObrisi.TabIndex = 0;
            this.dUrObrisi.Text = "Obriši";
            this.dUrObrisi.UseVisualStyleBackColor = true;
            this.dUrObrisi.Click += new System.EventHandler(this.dUrObrisi_Click);
            // 
            // lbProizvodjaci
            // 
            this.lbProizvodjaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProizvodjaci.FormattingEnabled = true;
            this.lbProizvodjaci.ItemHeight = 17;
            this.lbProizvodjaci.Location = new System.Drawing.Point(258, 86);
            this.lbProizvodjaci.Name = "lbProizvodjaci";
            this.lbProizvodjaci.Size = new System.Drawing.Size(183, 378);
            this.lbProizvodjaci.Sorted = true;
            this.lbProizvodjaci.TabIndex = 0;
            this.lbProizvodjaci.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbProizvodjaci_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proizvođač:";
            // 
            // tbProizvodjac
            // 
            this.tbProizvodjac.Location = new System.Drawing.Point(325, 30);
            this.tbProizvodjac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbProizvodjac.Name = "tbProizvodjac";
            this.tbProizvodjac.Size = new System.Drawing.Size(116, 20);
            this.tbProizvodjac.TabIndex = 2;
            this.tbProizvodjac.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbProizvodjac_KeyDown);
            this.tbProizvodjac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProizvodjac_KeyPress);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dPrDodaj, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dPrObrisi, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(260, 53);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(180, 28);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // dPrDodaj
            // 
            this.dPrDodaj.Location = new System.Drawing.Point(2, 2);
            this.dPrDodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dPrDodaj.Name = "dPrDodaj";
            this.dPrDodaj.Size = new System.Drawing.Size(86, 23);
            this.dPrDodaj.TabIndex = 0;
            this.dPrDodaj.Text = "Dodaj";
            this.dPrDodaj.UseVisualStyleBackColor = true;
            this.dPrDodaj.Click += new System.EventHandler(this.dPrDodaj_Click);
            // 
            // dPrObrisi
            // 
            this.dPrObrisi.Location = new System.Drawing.Point(92, 2);
            this.dPrObrisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dPrObrisi.Name = "dPrObrisi";
            this.dPrObrisi.Size = new System.Drawing.Size(86, 23);
            this.dPrObrisi.TabIndex = 0;
            this.dPrObrisi.Text = "Obriši";
            this.dPrObrisi.UseVisualStyleBackColor = true;
            this.dPrObrisi.Click += new System.EventHandler(this.dPrObrisi_Click);
            // 
            // dApply
            // 
            this.dApply.Location = new System.Drawing.Point(446, 430);
            this.dApply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dApply.Name = "dApply";
            this.dApply.Size = new System.Drawing.Size(78, 34);
            this.dApply.TabIndex = 7;
            this.dApply.Text = "Primeni";
            this.dApply.UseVisualStyleBackColor = true;
            this.dApply.Click += new System.EventHandler(this.dApply_Click);
            // 
            // ucUredjaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dApply);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tbProizvodjac);
            this.Controls.Add(this.tbUredjaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbProizvodjaci);
            this.Controls.Add(this.lbUredjaji);
            this.Name = "ucUredjaji";
            this.Size = new System.Drawing.Size(532, 483);
            this.Load += new System.EventHandler(this.ucUredjaji_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbUredjaji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUredjaj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button dUrDodaj;
        private System.Windows.Forms.Button dUrObrisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProizvodjac;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button dPrDodaj;
        private System.Windows.Forms.Button dPrObrisi;
        private System.Windows.Forms.Button dApply;
        private System.Windows.Forms.ListBox lbProizvodjaci;
    }
}
