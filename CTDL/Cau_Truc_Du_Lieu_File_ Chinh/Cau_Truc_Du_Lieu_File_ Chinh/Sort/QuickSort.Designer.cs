namespace Cau_Truc_Du_Lieu_File__Chinh.Sort
{
    partial class QuickSort
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
            this.btnSort = new System.Windows.Forms.Button();
            this.txbNumber = new System.Windows.Forms.TextBox();
            this.lbInputNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(14, 54);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // txbNumber
            // 
            this.txbNumber.Location = new System.Drawing.Point(14, 28);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(75, 20);
            this.txbNumber.TabIndex = 1;
            // 
            // lbInputNumber
            // 
            this.lbInputNumber.AutoSize = true;
            this.lbInputNumber.Location = new System.Drawing.Point(11, 12);
            this.lbInputNumber.Name = "lbInputNumber";
            this.lbInputNumber.Size = new System.Drawing.Size(71, 13);
            this.lbInputNumber.TabIndex = 2;
            this.lbInputNumber.Text = "Input Number";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbInputNumber);
            this.panel1.Controls.Add(this.btnSort);
            this.panel1.Controls.Add(this.txbNumber);
            this.panel1.Location = new System.Drawing.Point(822, 539);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 122);
            this.panel1.TabIndex = 3;
            // 
            // QuickSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1075, 661);
            this.Controls.Add(this.panel1);
            this.Name = "QuickSort";
            this.Text = "QuickSort";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TextBox txbNumber;
        private System.Windows.Forms.Label lbInputNumber;
        private System.Windows.Forms.Panel panel1;
    }
}