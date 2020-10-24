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
            SimpleSearch.LinearSearch linearSearch = new SimpleSearch.LinearSearch();
            linearSearch.Show();
        }

        private void BtnBinarySearch_Click(object sender, EventArgs e)
        {
            BinarySearch_Version2.BinarySearch_Form bnrf = new BinarySearch_Version2.BinarySearch_Form();
            bnrf.Show();
        }
    }
}
