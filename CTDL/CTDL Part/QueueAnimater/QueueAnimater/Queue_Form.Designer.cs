namespace QueueAnimater
{
    partial class Queue_Form
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
            this.btnEn = new System.Windows.Forms.Button();
            this.btnDe = new System.Windows.Forms.Button();
            this.btnFr = new System.Windows.Forms.Button();
            this.txbVal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEn
            // 
            this.btnEn.Location = new System.Drawing.Point(44, 685);
            this.btnEn.Name = "btnEn";
            this.btnEn.Size = new System.Drawing.Size(75, 23);
            this.btnEn.TabIndex = 0;
            this.btnEn.Text = "EnQueue";
            this.btnEn.UseVisualStyleBackColor = true;
            this.btnEn.Click += new System.EventHandler(this.BtnEn_Click);
            // 
            // btnDe
            // 
            this.btnDe.Location = new System.Drawing.Point(233, 685);
            this.btnDe.Name = "btnDe";
            this.btnDe.Size = new System.Drawing.Size(75, 23);
            this.btnDe.TabIndex = 1;
            this.btnDe.Text = "DeQueue";
            this.btnDe.UseVisualStyleBackColor = true;
            this.btnDe.Click += new System.EventHandler(this.BtnDe_Click);
            // 
            // btnFr
            // 
            this.btnFr.Location = new System.Drawing.Point(314, 685);
            this.btnFr.Name = "btnFr";
            this.btnFr.Size = new System.Drawing.Size(75, 23);
            this.btnFr.TabIndex = 2;
            this.btnFr.Text = "Front";
            this.btnFr.UseVisualStyleBackColor = true;
            this.btnFr.Click += new System.EventHandler(this.BtnFr_Click);
            // 
            // txbVal
            // 
            this.txbVal.Location = new System.Drawing.Point(125, 687);
            this.txbVal.Name = "txbVal";
            this.txbVal.Size = new System.Drawing.Size(100, 20);
            this.txbVal.TabIndex = 3;
            // 
            // Queue_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(834, 729);
            this.Controls.Add(this.txbVal);
            this.Controls.Add(this.btnFr);
            this.Controls.Add(this.btnDe);
            this.Controls.Add(this.btnEn);
            this.Name = "Queue_Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEn;
        private System.Windows.Forms.Button btnDe;
        private System.Windows.Forms.Button btnFr;
        private System.Windows.Forms.TextBox txbVal;
    }
}

