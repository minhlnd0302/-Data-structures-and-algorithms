namespace Cau_Truc_Du_Lieu_File__Chinh.Sort
{
    partial class InterchangeSort
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txbInputNumber = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbInput = new System.Windows.Forms.Label();
            this.btnNewTab = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbInput);
            this.flowLayoutPanel1.Controls.Add(this.txbInputNumber);
            this.flowLayoutPanel1.Controls.Add(this.btnSort);
            this.flowLayoutPanel1.Controls.Add(this.btnReset);
            this.flowLayoutPanel1.Controls.Add(this.btnNewTab);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(843, 344);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(102, 193);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txbInputNumber
            // 
            this.txbInputNumber.Location = new System.Drawing.Point(8, 37);
            this.txbInputNumber.Margin = new System.Windows.Forms.Padding(8);
            this.txbInputNumber.Name = "txbInputNumber";
            this.txbInputNumber.Size = new System.Drawing.Size(75, 20);
            this.txbInputNumber.TabIndex = 3;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(8, 73);
            this.btnSort.Margin = new System.Windows.Forms.Padding(8);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(8, 112);
            this.btnReset.Margin = new System.Windows.Forms.Padding(8);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(8, 8);
            this.lbInput.Margin = new System.Windows.Forms.Padding(8);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(71, 13);
            this.lbInput.TabIndex = 2;
            this.lbInput.Text = "Input Number";
            // 
            // btnNewTab
            // 
            this.btnNewTab.Location = new System.Drawing.Point(8, 151);
            this.btnNewTab.Margin = new System.Windows.Forms.Padding(8);
            this.btnNewTab.Name = "btnNewTab";
            this.btnNewTab.Size = new System.Drawing.Size(75, 23);
            this.btnNewTab.TabIndex = 4;
            this.btnNewTab.Text = "New Tab";
            this.btnNewTab.UseVisualStyleBackColor = true;
            this.btnNewTab.Click += new System.EventHandler(this.BtnNewTab_Click);
            // 
            // InterchangeSort
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1075, 549);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "InterchangeSort";
            this.Text = "InterchangeSort";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txbInputNumber;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Button btnNewTab;
    }
}