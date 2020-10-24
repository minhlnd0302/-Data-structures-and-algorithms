using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BalanceTree
{
    public partial class AVL_Form : Form
    {
        public AVL_Form()
        {
            InitializeComponent();
        }
        AVLTree tree = new AVLTree();
        Graphics g;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            tree.Add(int.Parse(txbAdd.Text),g);
            txbAdd.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            tree.Delete(int.Parse(txbDel.Text), g);
            txbDel.Clear();
        }
    }
}
