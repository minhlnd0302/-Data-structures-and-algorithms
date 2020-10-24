using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau_Truc_Du_Lieu_File__Chinh.Search
{
    public partial class SearchAlgorithmPicker : Form
    {
        public SearchAlgorithmPicker()
        {
            InitializeComponent();
        }
        
        private void BtnLinearSearch_Click(object sender, EventArgs e)
        {
            SimpleSearch.LinearSearch newForm = new SimpleSearch.LinearSearch();
            newForm.Show();

        }

        private void BtnBinarySearch_Click(object sender, EventArgs e)
        {
            BinarySearchReproduce.BNS_Form newForm = new BinarySearchReproduce.BNS_Form();
            newForm.Show();

        }

        private void btnBinarySearchTree_Click(object sender, EventArgs e)
        {
            BinarySearchTree.BSTreeForm newForm = new BinarySearchTree.BSTreeForm();
            newForm.Show();
        }

      
    }
}
