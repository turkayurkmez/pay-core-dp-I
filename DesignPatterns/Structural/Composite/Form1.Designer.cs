namespace Composite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode9 = new TreeNode("Murat Bey");
            TreeNode treeNode10 = new TreeNode("Nihal hanım");
            TreeNode treeNode11 = new TreeNode("Özlük Hakları", new TreeNode[] { treeNode9, treeNode10 });
            TreeNode treeNode12 = new TreeNode("İnsan Kaynakları", new TreeNode[] { treeNode11 });
            treeView1 = new TreeView();
            treeView2 = new TreeView();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeNode9.Name = "Node3";
            treeNode9.Text = "Murat Bey";
            treeNode10.Name = "Node4";
            treeNode10.Text = "Nihal hanım";
            treeNode11.Name = "Node2";
            treeNode11.Text = "Özlük Hakları";
            treeNode12.Name = "Node0";
            treeNode12.Text = "İnsan Kaynakları";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode12 });
            treeView1.Size = new Size(199, 177);
            treeView1.TabIndex = 0;
            // 
            // treeView2
            // 
            treeView2.Location = new Point(14, 211);
            treeView2.Name = "treeView2";
            treeView2.Size = new Size(197, 151);
            treeView2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 530);
            Controls.Add(treeView2);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private TreeView treeView2;
    }
}