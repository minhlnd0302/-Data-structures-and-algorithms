namespace LinkedListViewer
{
    partial class LinkedList_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAfterValue = new System.Windows.Forms.TextBox();
            this.txbSearch_Val = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbDel_Value = new System.Windows.Forms.TextBox();
            this.btnDel_Index = new System.Windows.Forms.Button();
            this.txbAddValue = new System.Windows.Forms.TextBox();
            this.btnAddRandom = new System.Windows.Forms.Button();
            this.btnDelTail = new System.Windows.Forms.Button();
            this.txbAddToTail = new System.Windows.Forms.TextBox();
            this.btnAddToTail = new System.Windows.Forms.Button();
            this.btnDelHead = new System.Windows.Forms.Button();
            this.txbAddToHead = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbAfterValue);
            this.groupBox1.Controls.Add(this.txbSearch_Val);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txbDel_Value);
            this.groupBox1.Controls.Add(this.btnDel_Index);
            this.groupBox1.Controls.Add(this.txbAddValue);
            this.groupBox1.Controls.Add(this.btnAddRandom);
            this.groupBox1.Controls.Add(this.btnDelTail);
            this.groupBox1.Controls.Add(this.txbAddToTail);
            this.groupBox1.Controls.Add(this.btnAddToTail);
            this.groupBox1.Controls.Add(this.btnDelHead);
            this.groupBox1.Controls.Add(this.txbAddToHead);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 440);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ở vị trí";
            // 
            // txbAfterValue
            // 
            this.txbAfterValue.Location = new System.Drawing.Point(114, 106);
            this.txbAfterValue.Name = "txbAfterValue";
            this.txbAfterValue.Size = new System.Drawing.Size(50, 20);
            this.txbAfterValue.TabIndex = 14;
            // 
            // txbSearch_Val
            // 
            this.txbSearch_Val.Location = new System.Drawing.Point(295, 108);
            this.txbSearch_Val.Name = "txbSearch_Val";
            this.txbSearch_Val.Size = new System.Drawing.Size(60, 20);
            this.txbSearch_Val.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(192, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txbDel_Value
            // 
            this.txbDel_Value.Location = new System.Drawing.Point(295, 77);
            this.txbDel_Value.Name = "txbDel_Value";
            this.txbDel_Value.Size = new System.Drawing.Size(60, 20);
            this.txbDel_Value.TabIndex = 10;
            // 
            // btnDel_Index
            // 
            this.btnDel_Index.Location = new System.Drawing.Point(192, 77);
            this.btnDel_Index.Name = "btnDel_Index";
            this.btnDel_Index.Size = new System.Drawing.Size(88, 23);
            this.btnDel_Index.TabIndex = 9;
            this.btnDel_Index.Text = "Xóa ở vị trí";
            this.btnDel_Index.UseVisualStyleBackColor = true;
            this.btnDel_Index.Click += new System.EventHandler(this.BtnDel_Index_Click);
            // 
            // txbAddValue
            // 
            this.txbAddValue.Location = new System.Drawing.Point(114, 80);
            this.txbAddValue.Name = "txbAddValue";
            this.txbAddValue.Size = new System.Drawing.Size(50, 20);
            this.txbAddValue.TabIndex = 8;
            // 
            // btnAddRandom
            // 
            this.btnAddRandom.Location = new System.Drawing.Point(6, 77);
            this.btnAddRandom.Name = "btnAddRandom";
            this.btnAddRandom.Size = new System.Drawing.Size(102, 23);
            this.btnAddRandom.TabIndex = 7;
            this.btnAddRandom.Text = "Thêm vào giá trị";
            this.btnAddRandom.UseVisualStyleBackColor = true;
            this.btnAddRandom.Click += new System.EventHandler(this.BtnAddRandom_Click);
            // 
            // btnDelTail
            // 
            this.btnDelTail.Location = new System.Drawing.Point(192, 48);
            this.btnDelTail.Name = "btnDelTail";
            this.btnDelTail.Size = new System.Drawing.Size(88, 23);
            this.btnDelTail.TabIndex = 6;
            this.btnDelTail.Text = "Xóa ở cuối";
            this.btnDelTail.UseVisualStyleBackColor = true;
            this.btnDelTail.Click += new System.EventHandler(this.BtnDelTail_Click);
            // 
            // txbAddToTail
            // 
            this.txbAddToTail.Location = new System.Drawing.Point(114, 50);
            this.txbAddToTail.Name = "txbAddToTail";
            this.txbAddToTail.Size = new System.Drawing.Size(50, 20);
            this.txbAddToTail.TabIndex = 5;
            // 
            // btnAddToTail
            // 
            this.btnAddToTail.Location = new System.Drawing.Point(6, 48);
            this.btnAddToTail.Name = "btnAddToTail";
            this.btnAddToTail.Size = new System.Drawing.Size(102, 23);
            this.btnAddToTail.TabIndex = 4;
            this.btnAddToTail.Text = "Thêm vào cuối";
            this.btnAddToTail.UseVisualStyleBackColor = true;
            this.btnAddToTail.Click += new System.EventHandler(this.BtnAddToTail_Click);
            // 
            // btnDelHead
            // 
            this.btnDelHead.Location = new System.Drawing.Point(192, 19);
            this.btnDelHead.Name = "btnDelHead";
            this.btnDelHead.Size = new System.Drawing.Size(88, 23);
            this.btnDelHead.TabIndex = 2;
            this.btnDelHead.Text = "Xóa ở đầu";
            this.btnDelHead.UseVisualStyleBackColor = true;
            this.btnDelHead.Click += new System.EventHandler(this.BtnDelHead_Click);
            // 
            // txbAddToHead
            // 
            this.txbAddToHead.Location = new System.Drawing.Point(114, 21);
            this.txbAddToHead.Name = "txbAddToHead";
            this.txbAddToHead.Size = new System.Drawing.Size(50, 20);
            this.txbAddToHead.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm vào đầu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LinkedList_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1230, 593);
            this.Controls.Add(this.groupBox1);
            this.Name = "LinkedList_Form";
            this.Text = "Linked List";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbAfterValue;
        private System.Windows.Forms.TextBox txbSearch_Val;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbDel_Value;
        private System.Windows.Forms.Button btnDel_Index;
        private System.Windows.Forms.TextBox txbAddValue;
        private System.Windows.Forms.Button btnAddRandom;
        private System.Windows.Forms.Button btnDelTail;
        private System.Windows.Forms.TextBox txbAddToTail;
        private System.Windows.Forms.Button btnAddToTail;
        private System.Windows.Forms.Button btnDelHead;
        private System.Windows.Forms.TextBox txbAddToHead;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

