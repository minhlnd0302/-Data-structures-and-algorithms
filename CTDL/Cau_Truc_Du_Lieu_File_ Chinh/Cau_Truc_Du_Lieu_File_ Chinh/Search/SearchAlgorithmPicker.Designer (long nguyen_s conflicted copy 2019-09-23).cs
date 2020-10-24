namespace Cau_Truc_Du_Lieu_File__Chinh.Search
{
    partial class SearchAlgorithmPicker
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
            this.btnLinearSearch = new System.Windows.Forms.Button();
            this.btnBinarySearch = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnLinearSearch);
            this.flowLayoutPanel1.Controls.Add(this.btnBinarySearch);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(53, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(501, 143);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnLinearSearch
            // 
            this.btnLinearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinearSearch.Location = new System.Drawing.Point(40, 40);
            this.btnLinearSearch.Margin = new System.Windows.Forms.Padding(40);
            this.btnLinearSearch.Name = "btnLinearSearch";
            this.btnLinearSearch.Size = new System.Drawing.Size(162, 74);
            this.btnLinearSearch.TabIndex = 0;
            this.btnLinearSearch.Text = "Linear Search";
            this.btnLinearSearch.UseVisualStyleBackColor = true;
            this.btnLinearSearch.Click += new System.EventHandler(this.BtnLinearSearch_Click);
            // 
            // btnBinarySearch
            // 
            this.btnBinarySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinarySearch.Location = new System.Drawing.Point(282, 40);
            this.btnBinarySearch.Margin = new System.Windows.Forms.Padding(40);
            this.btnBinarySearch.Name = "btnBinarySearch";
            this.btnBinarySearch.Size = new System.Drawing.Size(162, 74);
            this.btnBinarySearch.TabIndex = 1;
            this.btnBinarySearch.Text = "Binary Search";
            this.btnBinarySearch.UseVisualStyleBackColor = true;
            this.btnBinarySearch.Click += new System.EventHandler(this.BtnBinarySearch_Click);
            // 
            // SearchAlgorithmPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 218);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SearchAlgorithmPicker";
            this.Text = "SearchAlgorithmPicker";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnLinearSearch;
        private System.Windows.Forms.Button btnBinarySearch;
    }
}