﻿namespace _58.TreeView_and_ImageList
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Mohamed");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Elsaid");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Boys", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Asmaa", 0, 0);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Mahasen", 0, 0);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Girls", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "woman.png");
            this.imageList1.Images.SetKeyName(1, "delivery-boy.png");
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImageIndex = 1;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(90, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "childMohamed";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Mohamed";
            treeNode2.Name = "childElsaid";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Elsaid";
            treeNode3.Name = "nodeBoys";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "Boys";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "childAsmaa";
            treeNode4.SelectedImageIndex = 0;
            treeNode4.Text = "Asmaa";
            treeNode5.ImageIndex = 0;
            treeNode5.Name = "childMahasen";
            treeNode5.SelectedImageIndex = 0;
            treeNode5.Text = "Mahasen";
            treeNode6.ImageIndex = 0;
            treeNode6.Name = "nodeGirls";
            treeNode6.SelectedImageIndex = 0;
            treeNode6.Text = "Girls";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(623, 426);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

