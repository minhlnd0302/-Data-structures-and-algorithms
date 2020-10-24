namespace Cau_Truc_Du_Lieu_File__Chinh.Sort
{
    partial class SortAlgorithm
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
            this.btnInsertonSort = new System.Windows.Forms.Button();
            this.btnInterchangeSort = new System.Windows.Forms.Button();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnHeapSort = new System.Windows.Forms.Button();
            this.btnShellSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Location = new System.Drawing.Point(29, 55);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(109, 35);
            this.btnSelectionSort.TabIndex = 0;
            this.btnSelectionSort.Text = "Selection Sort";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.BtnSelectionSort_Click);
            // 
            // btnInsertonSort
            // 
            this.btnInsertonSort.Location = new System.Drawing.Point(177, 55);
            this.btnInsertonSort.Name = "btnInsertonSort";
            this.btnInsertonSort.Size = new System.Drawing.Size(109, 35);
            this.btnInsertonSort.TabIndex = 1;
            this.btnInsertonSort.Text = "Insertion Sort";
            this.btnInsertonSort.UseVisualStyleBackColor = true;
            this.btnInsertonSort.Click += new System.EventHandler(this.BtnInsertonSort_Click);
            // 
            // btnInterchangeSort
            // 
            this.btnInterchangeSort.Location = new System.Drawing.Point(328, 55);
            this.btnInterchangeSort.Name = "btnInterchangeSort";
            this.btnInterchangeSort.Size = new System.Drawing.Size(109, 35);
            this.btnInterchangeSort.TabIndex = 2;
            this.btnInterchangeSort.Text = "Interchange Sort";
            this.btnInterchangeSort.UseVisualStyleBackColor = true;
            this.btnInterchangeSort.Click += new System.EventHandler(this.BtnInterchangeSort_Click);
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(479, 55);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(109, 35);
            this.btnBubbleSort.TabIndex = 3;
            this.btnBubbleSort.Text = "Bubble Sort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.BtnBubbleSort_Click);
            // 
            // btnHeapSort
            // 
            this.btnHeapSort.Location = new System.Drawing.Point(328, 114);
            this.btnHeapSort.Name = "btnHeapSort";
            this.btnHeapSort.Size = new System.Drawing.Size(100, 35);
            this.btnHeapSort.TabIndex = 4;
            this.btnHeapSort.Text = "Heap Sort";
            this.btnHeapSort.UseVisualStyleBackColor = true;
            this.btnHeapSort.Click += new System.EventHandler(this.BtnHeapSort_Click);
            // 
            // btnShellSort
            // 
            this.btnShellSort.Location = new System.Drawing.Point(29, 115);
            this.btnShellSort.Name = "btnShellSort";
            this.btnShellSort.Size = new System.Drawing.Size(109, 35);
            this.btnShellSort.TabIndex = 5;
            this.btnShellSort.Text = "Shell Sort";
            this.btnShellSort.UseVisualStyleBackColor = true;
            this.btnShellSort.Click += new System.EventHandler(this.BtnShellSort_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(177, 115);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(109, 34);
            this.btnQuickSort.TabIndex = 6;
            this.btnQuickSort.Text = "Quick Sort ";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // SortAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 185);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnShellSort);
            this.Controls.Add(this.btnHeapSort);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.btnInterchangeSort);
            this.Controls.Add(this.btnInsertonSort);
            this.Controls.Add(this.btnSelectionSort);
            this.Name = "SortAlgorithm";
            this.Text = "SortAlgorithm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnInsertonSort;
        private System.Windows.Forms.Button btnInterchangeSort;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnHeapSort;
        private System.Windows.Forms.Button btnShellSort;
        private System.Windows.Forms.Button btnQuickSort;
    }
}