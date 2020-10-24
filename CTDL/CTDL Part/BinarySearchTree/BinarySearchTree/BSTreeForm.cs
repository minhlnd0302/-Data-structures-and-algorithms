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
using System.Threading;
using System.Collections;
namespace BinarySearchTree
{
    public partial class BSTreeForm : Form
    {
        
        Graphics g;
        Tree tree = new Tree();
        List<int> a = new List<int>();
        DrawCode drc = new DrawCode();
        
        List<int> a1 = new List<int>() { 50,25,75,65,85,90,77,70,15,35,5,20,30,45};
        List<int> a2 = new List<int>() { 41, 20, 65, 50, 91, 72, 99, 11, 29, 32 };
        List<int> a3 = new List<int>() { 16,8,64,5,20,82,29,46,69,84};
        List<int> a4 = new List<int>() { 15, 6, 23, 4, 7, 5, 71, 50 };
        List<int> a5 = new List<int>() { 100, 50, 150, 75, 25, 15, 35, 85, 65, 175, 125, 135, 115, 190, 165 };
        public BSTreeForm()
        {
            InitializeComponent();
           
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            tree.InsertNode(int.Parse(txbVal.Text), g);
            tree.UpdatePosition(tree.root, tree.root, -1);
            g.Clear(Color.DarkGreen);
            tree.UpdateNode(tree.root, tree.root, g);
            a.Add(int.Parse(txbVal.Text));
            txbVal.Clear();
            drc.InsertCode(100, g);

        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRectangle(Brushes.DarkGreen, 700, 0, 700, 700);
            tree.PreorderTraverse(tree.root,tree.root, g);
        }

        private void btnInOrder_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRectangle(Brushes.DarkGreen, 700, 0, 700, 700);
            tree.InorderTraverse(tree.root,tree.root, g);
        }

        private void btnPostOrder_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRectangle(Brushes.DarkGreen, 700, 0, 700, 700);
            tree.PostorderTraverse(tree.root,tree.root, g);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRectangle(Brushes.DarkGreen, 700, 0, 700, 700);
            tree.DeleteNode(int.Parse(txbDelValue.Text),g);
            a.Clear();
            tree.levelUpdate(a);
           // a.Remove(int.Parse(txbDelValue.Text));
            g.Clear(Color.DarkGreen);
            // tree.deleteAll(tree.root);
            // tree.ReUpdate(tree, a);
             tree.UpdateNode(tree.root, tree.root, g);
            //tree.UpdateNode(tree.root, tree.root, g);
           // Tree tmp = new Tree();
            
            //Thread.Sleep(1000);
            g.FillRectangle(Brushes.DarkGreen, 0, 0, 750, 1000);
            tree.deleteAll(tree.root);
            tree.ReUpdate(tree, a);
            tree.UpdatePosition(tree.root, tree.root, -1);
            tree.UpdateNode(tree.root, tree.root, g);
            drc.DelCode(110, g);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.DarkGreen);
            Random rnd = new Random();

            int idx = rnd.Next(1, 5);
            a.Clear();
            switch(idx)
            {
                case 1:
                    a = a1;
                    break;
                case 2:
                    a = a2;
                    break;
                case 3:
                    a = a3;
                    break;
                case 4:
                    a = a4;
                    break;
                case 5:
                    a = a5;
                    break;
            }
            tree.deleteAll(tree.root);
            tree.ReUpdate(tree, a);
            tree.UpdatePosition(tree.root, tree.root, -1);
            tree.UpdateNode(tree.root, tree.root, g);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRectangle(Brushes.DarkGreen, 700, 0, 700, 700);
            tree.Search(tree.root,tree.root,int.Parse(txbSearchValue.Text),g);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.DarkGreen);
            tree.deleteAll(tree.root);
            a.Clear();

        }
    }
}
