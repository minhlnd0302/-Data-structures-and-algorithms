namespace Cau_Truc_Du_Lieu_File__Chinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBinarySearchTree = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search Algorithm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sort Algorithm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.Location = new System.Drawing.Point(192, 100);
            this.btnQueue.Margin = new System.Windows.Forms.Padding(20);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(132, 40);
            this.btnQueue.TabIndex = 2;
            this.btnQueue.Text = "Queue";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(536, 20);
            this.button4.Margin = new System.Windows.Forms.Padding(20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Single Linked List";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnStack
            // 
            this.btnStack.Location = new System.Drawing.Point(20, 100);
            this.btnStack.Margin = new System.Windows.Forms.Padding(20);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(132, 40);
            this.btnStack.TabIndex = 4;
            this.btnStack.Text = "Stack";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(364, 20);
            this.button6.Margin = new System.Windows.Forms.Padding(20);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 40);
            this.button6.TabIndex = 5;
            this.button6.Text = "AVL Tree";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.btnStack);
            this.flowLayoutPanel1.Controls.Add(this.btnQueue);
            this.flowLayoutPanel1.Controls.Add(this.btnBinarySearchTree);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 34);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(722, 163);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnBinarySearchTree
            // 
            this.btnBinarySearchTree.Location = new System.Drawing.Point(364, 100);
            this.btnBinarySearchTree.Margin = new System.Windows.Forms.Padding(20);
            this.btnBinarySearchTree.Name = "btnBinarySearchTree";
            this.btnBinarySearchTree.Size = new System.Drawing.Size(132, 40);
            this.btnBinarySearchTree.TabIndex = 6;
            this.btnBinarySearchTree.Text = " Binary Search Tree";
            this.btnBinarySearchTree.UseVisualStyleBackColor = true;
            this.btnBinarySearchTree.Click += new System.EventHandler(this.btnBinarySearchTree_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 234);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu Trúc Dữ Liệu";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnStack;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnBinarySearchTree;
    }
}

