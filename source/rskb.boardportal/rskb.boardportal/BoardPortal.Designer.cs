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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
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
            this.treeViewProgress.Location = new System.Drawing.Point(258, 61);
            this.treeViewProgress.Name = "treeViewProgress";
            this.treeViewProgress.ShowPlusMinus = false;
            this.treeViewProgress.ShowRootLines = false;
            this.treeViewProgress.Size = new System.Drawing.Size(242, 380);
            this.treeViewProgress.TabIndex = 0;
            this.treeViewProgress.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_ItemDrag);
            this.treeViewProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
            this.treeViewProgress.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView_DragOver);
            // 
            // treeViewQs
            // 
            this.treeViewQs.AllowDrop = true;
            this.treeViewQs.ItemHeight = 32;
            this.treeViewQs.Location = new System.Drawing.Point(526, 61);
            this.treeViewQs.Name = "treeViewQs";
            this.treeViewQs.ShowPlusMinus = false;
            this.treeViewQs.ShowRootLines = false;
            this.treeViewQs.Size = new System.Drawing.Size(237, 380);
            this.treeViewQs.TabIndex = 0;
            this.treeViewQs.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_ItemDrag);
            this.treeViewQs.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
            this.treeViewQs.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView_DragOver);
            // 
            // treeViewDone
            // 
            this.treeViewDone.AllowDrop = true;
            this.treeViewDone.ItemHeight = 32;
            this.treeViewDone.Location = new System.Drawing.Point(792, 61);
            this.treeViewDone.Name = "treeViewDone";
            this.treeViewDone.ShowPlusMinus = false;
            this.treeViewDone.ShowRootLines = false;
            this.treeViewDone.Size = new System.Drawing.Size(222, 380);
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
            this.label2.Location = new System.Drawing.Point(255, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Progress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "QS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(789, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Done";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(738, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(986, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::rskb.boardportal.Properties.Resources.refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(16, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // BoardPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 453);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnRefresh;
    }
}