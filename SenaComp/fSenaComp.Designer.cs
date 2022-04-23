namespace SenaComp
{
    partial class fSenaComp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pMain = new System.Windows.Forms.Panel();
            this.pMenu = new System.Windows.Forms.Panel();
            this.dPodesavanja = new System.Windows.Forms.Button();
            this.dPoslovni = new System.Windows.Forms.Button();
            this.dOtp = new System.Windows.Forms.Button();
            this.dFirme = new System.Windows.Forms.Button();
            this.dFakt = new System.Windows.Forms.Button();
            this.dArtikli = new System.Windows.Forms.Button();
            this.dProfakt = new System.Windows.Forms.Button();
            this.dPrivatni = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tMenu = new System.Windows.Forms.Timer(this.components);
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.dMenu = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Margin = new System.Windows.Forms.Padding(2);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1055, 646);
            this.pMain.TabIndex = 1;
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pMenu.Controls.Add(this.dPodesavanja);
            this.pMenu.Controls.Add(this.dPoslovni);
            this.pMenu.Controls.Add(this.dOtp);
            this.pMenu.Controls.Add(this.dFirme);
            this.pMenu.Controls.Add(this.dFakt);
            this.pMenu.Controls.Add(this.dArtikli);
            this.pMenu.Controls.Add(this.dProfakt);
            this.pMenu.Controls.Add(this.dPrivatni);
            this.pMenu.Controls.Add(this.label3);
            this.pMenu.Controls.Add(this.label2);
            this.pMenu.Controls.Add(this.label1);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(0, 646);
            this.pMenu.TabIndex = 2;
            // 
            // dPodesavanja
            // 
            this.dPodesavanja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dPodesavanja.BackgroundImage = global::SenaComp.Properties.Resources.settings;
            this.dPodesavanja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dPodesavanja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dPodesavanja.FlatAppearance.BorderSize = 0;
            this.dPodesavanja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dPodesavanja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.dPodesavanja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dPodesavanja.ForeColor = System.Drawing.Color.White;
            this.dPodesavanja.Location = new System.Drawing.Point(-56, 590);
            this.dPodesavanja.Margin = new System.Windows.Forms.Padding(2);
            this.dPodesavanja.Name = "dPodesavanja";
            this.dPodesavanja.Size = new System.Drawing.Size(46, 46);
            this.dPodesavanja.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dPodesavanja, "Podešavanja");
            this.dPodesavanja.UseVisualStyleBackColor = true;
            this.dPodesavanja.Click += new System.EventHandler(this.dPodesavanja_Click);
            // 
            // dPoslovni
            // 
            this.dPoslovni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dPoslovni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dPoslovni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dPoslovni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dPoslovni.ForeColor = System.Drawing.Color.White;
            this.dPoslovni.Location = new System.Drawing.Point(3, 160);
            this.dPoslovni.MaximumSize = new System.Drawing.Size(154, 27);
            this.dPoslovni.Name = "dPoslovni";
            this.dPoslovni.Size = new System.Drawing.Size(154, 27);
            this.dPoslovni.TabIndex = 1;
            this.dPoslovni.Text = "Poslovni Korisnici";
            this.dPoslovni.UseVisualStyleBackColor = false;
            this.dPoslovni.Click += new System.EventHandler(this.dPoslovni_Click);
            // 
            // dOtp
            // 
            this.dOtp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dOtp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dOtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dOtp.ForeColor = System.Drawing.Color.White;
            this.dOtp.Location = new System.Drawing.Point(3, 308);
            this.dOtp.MaximumSize = new System.Drawing.Size(154, 27);
            this.dOtp.Name = "dOtp";
            this.dOtp.Size = new System.Drawing.Size(154, 27);
            this.dOtp.TabIndex = 1;
            this.dOtp.Text = "Otpremnice";
            this.dOtp.UseVisualStyleBackColor = true;
            this.dOtp.Visible = false;
            this.dOtp.Click += new System.EventHandler(this.dOtp_Click);
            // 
            // dFirme
            // 
            this.dFirme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dFirme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dFirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dFirme.ForeColor = System.Drawing.Color.White;
            this.dFirme.Location = new System.Drawing.Point(3, 423);
            this.dFirme.MaximumSize = new System.Drawing.Size(154, 27);
            this.dFirme.Name = "dFirme";
            this.dFirme.Size = new System.Drawing.Size(154, 27);
            this.dFirme.TabIndex = 1;
            this.dFirme.Text = "Firme";
            this.dFirme.UseVisualStyleBackColor = true;
            this.dFirme.Click += new System.EventHandler(this.dFirme_Click);
            // 
            // dFakt
            // 
            this.dFakt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dFakt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dFakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dFakt.ForeColor = System.Drawing.Color.White;
            this.dFakt.Location = new System.Drawing.Point(3, 275);
            this.dFakt.MaximumSize = new System.Drawing.Size(154, 27);
            this.dFakt.Name = "dFakt";
            this.dFakt.Size = new System.Drawing.Size(154, 27);
            this.dFakt.TabIndex = 1;
            this.dFakt.Text = "Fakture";
            this.dFakt.UseVisualStyleBackColor = true;
            this.dFakt.Visible = false;
            this.dFakt.Click += new System.EventHandler(this.dFakt_Click);
            // 
            // dArtikli
            // 
            this.dArtikli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dArtikli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dArtikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dArtikli.ForeColor = System.Drawing.Color.White;
            this.dArtikli.Location = new System.Drawing.Point(3, 390);
            this.dArtikli.MaximumSize = new System.Drawing.Size(154, 27);
            this.dArtikli.Name = "dArtikli";
            this.dArtikli.Size = new System.Drawing.Size(154, 27);
            this.dArtikli.TabIndex = 1;
            this.dArtikli.Text = "Artikli";
            this.dArtikli.UseVisualStyleBackColor = true;
            this.dArtikli.Visible = false;
            this.dArtikli.Click += new System.EventHandler(this.dArtikli_Click);
            // 
            // dProfakt
            // 
            this.dProfakt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dProfakt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dProfakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dProfakt.ForeColor = System.Drawing.Color.White;
            this.dProfakt.Location = new System.Drawing.Point(3, 242);
            this.dProfakt.MaximumSize = new System.Drawing.Size(154, 27);
            this.dProfakt.Name = "dProfakt";
            this.dProfakt.Size = new System.Drawing.Size(154, 27);
            this.dProfakt.TabIndex = 1;
            this.dProfakt.Text = "Profakture";
            this.dProfakt.UseVisualStyleBackColor = true;
            this.dProfakt.Visible = false;
            this.dProfakt.Click += new System.EventHandler(this.dProfakt_Click);
            // 
            // dPrivatni
            // 
            this.dPrivatni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dPrivatni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dPrivatni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dPrivatni.ForeColor = System.Drawing.Color.White;
            this.dPrivatni.Location = new System.Drawing.Point(3, 127);
            this.dPrivatni.MaximumSize = new System.Drawing.Size(154, 27);
            this.dPrivatni.Name = "dPrivatni";
            this.dPrivatni.Size = new System.Drawing.Size(154, 27);
            this.dPrivatni.TabIndex = 1;
            this.dPrivatni.Text = "Privatni Korisnici";
            this.dPrivatni.UseVisualStyleBackColor = true;
            this.dPrivatni.Click += new System.EventHandler(this.dPrivatni_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 363);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Baze";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Računi";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nalozi";
            // 
            // tMenu
            // 
            this.tMenu.Interval = 20;
            this.tMenu.Tick += new System.EventHandler(this.tMenu_Tick);
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.ImageLocation = "";
            this.pbLogo.Location = new System.Drawing.Point(857, 126);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(175, 189);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 9;
            this.pbLogo.TabStop = false;
            // 
            // dMenu
            // 
            this.dMenu.BackgroundImage = global::SenaComp.Properties.Resources.menu;
            this.dMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dMenu.FlatAppearance.BorderSize = 0;
            this.dMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.dMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dMenu.Location = new System.Drawing.Point(11, 11);
            this.dMenu.Margin = new System.Windows.Forms.Padding(2);
            this.dMenu.Name = "dMenu";
            this.dMenu.Size = new System.Drawing.Size(46, 46);
            this.dMenu.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dMenu, "Menu");
            this.dMenu.UseVisualStyleBackColor = true;
            this.dMenu.Click += new System.EventHandler(this.dMenu_Click);
            // 
            // fSenaComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 646);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.dMenu);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.pMain);
            this.Name = "fSenaComp";
            this.Text = "SenaComp";
            this.Load += new System.EventHandler(this.fSenaComp_Load);
            this.pMenu.ResumeLayout(false);
            this.pMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dMenu;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button dPoslovni;
        private System.Windows.Forms.Button dPrivatni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dPodesavanja;
        private System.Windows.Forms.Button dOtp;
        private System.Windows.Forms.Button dFirme;
        private System.Windows.Forms.Button dFakt;
        private System.Windows.Forms.Button dArtikli;
        private System.Windows.Forms.Button dProfakt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tMenu;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

