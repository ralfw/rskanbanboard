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
            this.treeViewNext = new System.Windows.Forms.TreeView();
            this.treeViewProgress = new System.Windows.Forms.TreeView();
            this.treeViewQs = new System.Windows.Forms.TreeView();
            this.treeViewDone = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeViewNext
            // 
            this.treeViewNext.AllowDrop = true;
            this.treeViewNext.ItemHeight = 32;
            this.treeViewNext.Location = new System.Drawing.Point(13, 61);
            this.treeViewNext.Name = "treeViewNext";
            this.treeViewNext.ShowPlusMinus = false;
            this.treeViewNext.ShowRootLines = false;
            this.treeViewNext.Size = new System.Drawing.Size(221, 380);
            this.treeViewNext.TabIndex = 0;
            this.treeViewNext.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_ItemDrag);
            this.treeViewNext.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
            this.treeViewNext.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView_DragOver);
            // 
            // treeViewProgress
            // 
            this.treeViewProgress.AllowDrop = true;
            this.treeViewProgress.ItemHeight = 32;
            this.treeViewProgress.Location = new System.Drawing.Point(240, 61);
            this.treeViewProgress.Name = "treeViewProgress";
            this.treeViewProgress.ShowPlusMinus = false;
            this.treeViewProgress.ShowRootLines = false;
            this.treeViewProgress.Size = new System.Drawing.Size(260, 380);
            this.treeViewProgress.TabIndex = 0;
            this.treeViewProgress.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_ItemDrag);
            this.treeViewProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
            this.treeViewProgress.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView_DragOver);
            // 
            // treeViewQs
            // 
            this.treeViewQs.AllowDrop = true;
            this.treeViewQs.ItemHeight = 32;
            this.treeViewQs.Location = new System.Drawing.Point(506, 61);
            this.treeViewQs.Name = "treeViewQs";
            this.treeViewQs.ShowPlusMinus = false;
            this.treeViewQs.ShowRootLines = false;
            this.treeViewQs.Size = new System.Drawing.Size(257, 380);
            this.treeViewQs.TabIndex = 0;
            this.treeViewQs.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_ItemDrag);
            this.treeViewQs.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
            this.treeViewQs.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView_DragOver);
            // 
            // treeViewDone
            // 
            this.treeViewDone.AllowDrop = true;
            this.treeViewDone.ItemHeight = 32;
            this.treeViewDone.Location = new System.Drawing.Point(769, 61);
            this.treeViewDone.Name = "treeViewDone";
            this.treeViewDone.ShowPlusMinus = false;
            this.treeViewDone.ShowRootLines = false;
            this.treeViewDone.Size = new System.Drawing.Size(245, 380);
            this.treeViewDone.TabIndex = 0;
            this.treeViewDone.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_ItemDrag);
            this.treeViewDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
            this.treeViewDone.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView_DragOver);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Next";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Progress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "QS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(776, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Done";
            // 
            // BoardPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 453);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeViewDone);
            this.Controls.Add(this.treeViewQs);
            this.Controls.Add(this.treeViewProgress);
            this.Controls.Add(this.treeViewNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BoardPortal";
            this.Text = "BoardPortal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewNext;
        private System.Windows.Forms.TreeView treeViewProgress;
        private System.Windows.Forms.TreeView treeViewQs;
        private System.Windows.Forms.TreeView treeViewDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}