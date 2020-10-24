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

namespace QueueAnimater
{
    public partial class Queue_Form : Form
    {
        public Queue_Form()
        {
            InitializeComponent();
        }
        Graphics g;
        Queue queue = new Queue();
        private void BtnEn_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            queue.EndQueue(int.Parse(txbVal.Text.ToString()), g);
        }

        private void BtnDe_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            queue.DeQueue(g);
        }

        private void BtnFr_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            queue.Front(g);
        }
    }
}
