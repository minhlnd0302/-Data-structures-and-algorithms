using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau_Truc_Du_Lieu_File__Chinh.Sort
{
    public partial class SortAlgorithm : Form
    {
        public SortAlgorithm()
        {
            InitializeComponent();
        }

        private void BtnSelectionSort_Click(object sender, EventArgs e)
        {
            SelectionSort newForm = new SelectionSort();
            newForm.Show();
        }

        private void BtnInsertonSort_Click(object sender, EventArgs e)
        {
            Sort.InsertionSort newForm = new InsertionSort();
            newForm.Show();
        }

        private void BtnInterchangeSort_Click(object sender, EventArgs e)
        {
            Sort.InterchangeSort newform = new InterchangeSort();
            newform.Show();
        }

        private void BtnBubbleSort_Click(object sender, EventArgs e)
        {
            Sort.Bubble_Sort newForm = new Bubble_Sort();
            newForm.Show();
        }

        private void BtnHeapSort_Click(object sender, EventArgs e)
        {
            Sort.HeapSort newForm = new HeapSort();
            newForm.Show();
        }

        private void BtnShellSort_Click(object sender, EventArgs e)
        {
            Sort.ShellSort newForm = new ShellSort();
            newForm.Show();
        }

         

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            Sort.QuickSort newForm = new QuickSort();
            newForm.Show();
        }
    }
}
