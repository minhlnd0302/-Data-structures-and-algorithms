namespace BinarySearchTree
{
    partial class BSTreeForm
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnInOrder = new System.Windows.Forms.Button();
            this.btnPreOrder = new System.Windows.Forms.Button();
            this.btnPostOrder = new System.Windows.Forms.Button();
            this.txbVal = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbDelValue = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearchValue = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.grbox = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.grbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(6, 23);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 25);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnInOrder
            // 
            this.btnInOrder.ForeColor = System.Drawing.Color.Black;
            this.btnInOrder.Location = new System.Drawing.Point(209, 59);
            this.btnInOrder.Name = "btnInOrder";
            this.btnInOrder.Size = new System.Drawing.Size(75, 38);
            this.btnInOrder.TabIndex = 1;
            this.btnInOrder.Text = "InOrder";
            this.btnInOrder.UseVisualStyleBackColor = true;
            this.btnInOrder.Click += new System.EventHandler(this.btnInOrder_Click);
            // 
            // btnPreOrder
            // 
            this.btnPreOrder.ForeColor = System.Drawing.Color.Black;
            this.btnPreOrder.Location = new System.Drawing.Point(209, 103);
            this.btnPreOrder.Name = "btnPreOrder";
            this.btnPreOrder.Size = new System.Drawing.Size(75, 36);
            this.btnPreOrder.TabIndex = 2;
            this.btnPreOrder.Text = "PreOrder";
            this.btnPreOrder.UseVisualStyleBackColor = true;
            this.btnPreOrder.Click += new System.EventHandler(this.btnPreOrder_Click);
            // 
            // btnPostOrder
            // 
            this.btnPostOrder.ForeColor = System.Drawing.Color.Black;
            this.btnPostOrder.Location = new System.Drawing.Point(209, 18);
            this.btnPostOrder.Name = "btnPostOrder";
            this.btnPostOrder.Size = new System.Drawing.Size(75, 35);
            this.btnPostOrder.TabIndex = 3;
            this.btnPostOrder.Text = "PosOrder";
            this.btnPostOrder.UseVisualStyleBackColor = true;
            this.btnPostOrder.Click += new System.EventHandler(this.btnPostOrder_Click);
            // 
            // txbVal
            // 
            this.txbVal.ForeColor = System.Drawing.Color.Black;
            this.txbVal.Location = new System.Drawing.Point(87, 26);
            this.txbVal.Name = "txbVal";
            this.txbVal.Size = new System.Drawing.Size(100, 20);
            this.txbVal.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(6, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txbDelValue
            // 
            this.txbDelValue.ForeColor = System.Drawing.Color.Black;
            this.txbDelValue.Location = new System.Drawing.Point(87, 112);
            this.txbDelValue.Name = "txbDelValue";
            this.txbDelValue.Size = new System.Drawing.Size(100, 20);
            this.txbDelValue.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(6, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearchValue
            // 
            this.txbSearchValue.ForeColor = System.Drawing.Color.Black;
            this.txbSearchValue.Location = new System.Drawing.Point(87, 82);
            this.txbSearchValue.Name = "txbSearchValue";
            this.txbSearchValue.Size = new System.Drawing.Size(100, 20);
            this.txbSearchValue.TabIndex = 8;
            // 
            // btnRandom
            // 
            this.btnRandom.ForeColor = System.Drawing.Color.Black;
            this.btnRandom.Location = new System.Drawing.Point(6, 51);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 9;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // grbox
            // 
            this.grbox.AutoSize = true;
            this.grbox.Controls.Add(this.btnClear);
            this.grbox.Controls.Add(this.txbSearchValue);
            this.grbox.Controls.Add(this.btnRandom);
            this.grbox.Controls.Add(this.btnInsert);
            this.grbox.Controls.Add(this.btnInOrder);
            this.grbox.Controls.Add(this.btnSearch);
            this.grbox.Controls.Add(this.btnPreOrder);
            this.grbox.Controls.Add(this.txbDelValue);
            this.grbox.Controls.Add(this.btnPostOrder);
            this.grbox.Controls.Add(this.btnDelete);
            this.grbox.Controls.Add(this.txbVal);
            this.grbox.ForeColor = System.Drawing.Color.White;
            this.grbox.Location = new System.Drawing.Point(12, 491);
            this.grbox.Name = "grbox";
            this.grbox.Size = new System.Drawing.Size(353, 158);
            this.grbox.TabIndex = 10;
            this.grbox.TabStop = false;
            this.grbox.Text = "Chức năng";
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(87, 51);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 22);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // BSTreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1249, 661);
            this.Controls.Add(this.grbox);
            this.Name = "BSTreeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binary Search Tree";
            this.grbox.ResumeLayout(false);
            this.grbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnInOrder;
        private System.Windows.Forms.Button btnPreOrder;
        private System.Windows.Forms.Button btnPostOrder;
        private System.Windows.Forms.TextBox txbVal;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txbDelValue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbSearchValue;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.GroupBox grbox;
        private System.Windows.Forms.Button btnClear;
    }
}

