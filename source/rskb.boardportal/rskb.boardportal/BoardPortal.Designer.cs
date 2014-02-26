namespace rskb.boardportal
{
    partial class BoardPortal
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.treeView3 = new System.Windows.Forms.TreeView();
            this.treeView4 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 61);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(107, 380);
            this.treeView1.TabIndex = 0;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(126, 61);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(107, 380);
            this.treeView2.TabIndex = 0;
            // 
            // treeView3
            // 
            this.treeView3.Location = new System.Drawing.Point(239, 61);
            this.treeView3.Name = "treeView3";
            this.treeView3.Size = new System.Drawing.Size(107, 380);
            this.treeView3.TabIndex = 0;
            // 
            // treeView4
            // 
            this.treeView4.Location = new System.Drawing.Point(352, 61);
            this.treeView4.Name = "treeView4";
            this.treeView4.Size = new System.Drawing.Size(107, 380);
            this.treeView4.TabIndex = 0;
            // 
            // BoardPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 453);
            this.Controls.Add(this.treeView4);
            this.Controls.Add(this.treeView3);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Name = "BoardPortal";
            this.Text = "BoardPortal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TreeView treeView3;
        private System.Windows.Forms.TreeView treeView4;
    }
}