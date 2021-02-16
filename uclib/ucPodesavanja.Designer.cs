namespace uclib
{
    partial class ucPodesavanja
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Oprema");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Uređaji");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Osnovno", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Podaci Firme");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Klauzula");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Baza");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pOptMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "nOprema";
            treeNode1.Text = "Oprema";
            treeNode2.Name = "nUredjaji";
            treeNode2.Text = "Uređaji";
            treeNode3.Checked = true;
            treeNode3.Name = "nOsnovno";
            treeNode3.Text = "Osnovno";
            treeNode4.Name = "nFirma";
            treeNode4.Text = "Podaci Firme";
            treeNode5.Name = "nKlauzula";
            treeNode5.Text = "Klauzula";
            treeNode6.Name = "nBaza";
            treeNode6.Text = "Baza";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(170, 483);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // pOptMain
            // 
            this.pOptMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pOptMain.Location = new System.Drawing.Point(173, 0);
            this.pOptMain.Margin = new System.Windows.Forms.Padding(2);
            this.pOptMain.Name = "pOptMain";
            this.pOptMain.Size = new System.Drawing.Size(532, 483);
            this.pOptMain.TabIndex = 1;
            // 
            // ucPodesavanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pOptMain);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucPodesavanja";
            this.Size = new System.Drawing.Size(705, 483);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.Panel pOptMain;
    }
}
