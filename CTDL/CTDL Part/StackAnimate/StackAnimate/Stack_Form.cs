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

namespace StackAnimate
{
    public partial class Stack_Form : Form
    {
        public Stack_Form()
        {
            InitializeComponent();
        }
        Stack stack = new Stack();
        Graphics g;
        private void Button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            stack.Push(int.Parse(txbvalue.Text.ToString()), g);
        }

        private void BtnPop_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            stack.Pop(g);
        }

        private void BtnPeek_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            stack.Peek(g);
        }
    }
}
