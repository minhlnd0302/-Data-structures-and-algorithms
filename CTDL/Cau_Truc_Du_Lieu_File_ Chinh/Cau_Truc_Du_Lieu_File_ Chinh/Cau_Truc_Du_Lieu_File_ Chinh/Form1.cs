﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau_Truc_Du_Lieu_File__Chinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Search.SearchAlgorithmPicker newForm = new Search.SearchAlgorithmPicker();
            newForm.Show();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Sort.SortAlgorithm newForm = new Sort.SortAlgorithm();
            newForm.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            LinkedListViewer.LinkedList_Form lf = new LinkedListViewer.LinkedList_Form();
            lf.Show();
        }
    }
}
