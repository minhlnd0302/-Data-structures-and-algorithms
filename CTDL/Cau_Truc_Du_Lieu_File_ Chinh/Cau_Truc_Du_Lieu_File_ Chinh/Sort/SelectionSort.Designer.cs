namespace Cau_Truc_Du_Lieu_File__Chinh.Sort
{
    partial class SelectionSort
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
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.lbInputNumber = new System.Windows.Forms.Label();
            this.txbInputNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewTab = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Location = new System.Drawing.Point(18, 78);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(75, 23);
            this.btnSelectionSort.TabIndex = 0;
            this.btnSelectionSort.Text = "Sort";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.BtnSelectionSort_Click);
            // 
            // lbInputNumber
            // 
            this.lbInputNumber.AutoSize = true;
            this.lbInputNumber.Location = new System.Drawing.Point(15, 14);
            this.lbInputNumber.Name = "lbInputNumber";
            this.lbInputNumber.Size = new System.Drawing.Size(71, 13);
            this.lbInputNumber.TabIndex = 1;
            this.lbInputNumber.Text = "Input Number";
            // 
            // txbInputNumber
            // 
            this.txbInputNumber.Location = new System.Drawing.Point(18, 43);
            this.txbInputNumber.Name = "txbInputNumber";
            this.txbInputNumber.Size = new System.Drawing.Size(75, 20);
            this.txbInputNumber.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNewTab);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.lbInputNumber);
            this.panel1.Controls.Add(this.btnSelectionSort);
            this.panel1.Controls.Add(this.txbInputNumber);
            this.panel1.Location = new System.Drawing.Point(817, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 197);
            this.panel1.TabIndex = 3;
            // 
            // btnNewTab
            // 
            this.btnNewTab.Location = new System.Drawing.Point(18, 159);
            this.btnNewTab.Name = "btnNewTab";
            this.btnNewTab.Size = new System.Drawing.Size(75, 23);
            this.btnNewTab.TabIndex = 4;
            this.btnNewTab.Text = "New Tab";
            this.btnNewTab.UseVisualStyleBackColor = true;
            this.btnNewTab.Click += new System.EventHandler(this.BtnNewTab_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(18, 119);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SelectionSort
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1075, 549);
            this.Controls.Add(this.panel1);
            this.Name = "SelectionSort";
            this.Text = "SelectionSort";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Label lbInputNumber;
        private System.Windows.Forms.TextBox txbInputNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewTab;
        private System.Windows.Forms.Button btnReset;
    }
}