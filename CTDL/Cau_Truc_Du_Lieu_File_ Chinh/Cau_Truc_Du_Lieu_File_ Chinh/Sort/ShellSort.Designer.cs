namespace Cau_Truc_Du_Lieu_File__Chinh.Sort
{
    partial class ShellSort
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
            this.lblInPut = new System.Windows.Forms.Label();
            this.txbNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(982, 419);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // lblInPut
            // 
            this.lblInPut.AutoSize = true;
            this.lblInPut.Location = new System.Drawing.Point(979, 352);
            this.lblInPut.Name = "lblInPut";
            this.lblInPut.Size = new System.Drawing.Size(71, 13);
            this.lblInPut.TabIndex = 1;
            this.lblInPut.Text = "Input Number";
            // 
            // txbNumber
            // 
            this.txbNumber.Location = new System.Drawing.Point(982, 382);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(68, 20);
            this.txbNumber.TabIndex = 2;
            // 
            // ShellSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.txbNumber);
            this.Controls.Add(this.lblInPut);
            this.Controls.Add(this.btnSort);
            this.Name = "ShellSort";
            this.Text = "ShellSort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblInPut;
        private System.Windows.Forms.TextBox txbNumber;
    }
}