using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace StackAnimate
{
    class DrawNode
    {
        Pen p_black = new Pen(Color.Black, 3);
        Pen p_blue = new Pen(Color.Blue, 3);
        Pen p_red = new Pen(Color.Red, 3);
        Pen p_green = new Pen(Color.Green, 3);
        Pen p_yellow = new Pen(Color.Yellow, 3);
        Pen p_white = new Pen(Color.White, 3);
        Font font = new Font("Times New Roman",12,FontStyle.Bold);
        public void DrawOval(int x,int y,Graphics g)
        {
            g.FillEllipse(Brushes.DarkGreen, x, y, 40, 40);

        }
        public void DrawNarr(int x,int y,int z,int t,Graphics g)
        {
            p_white.EndCap = LineCap.ArrowAnchor;
            g.DrawLine(p_white, x, y, z, t);
        }
        public void DrawVal(int x,int y,Graphics g, string s)
        {
            g.DrawString(s, font, Brushes.White, x, y);
        }
        public void check_top(int x, int y, Graphics g)
        {
            g.FillEllipse(Brushes.OrangeRed, x, y, 40, 40);
            g.DrawString("Top", font, Brushes.White, x + 5, y - 20);
        }
        public void filltop(int x, int y, Graphics g)
        {
            g.FillEllipse(Brushes.OrangeRed, x, y, 40, 40);
           
        }
        public void Peek(int x,int y,Graphics g)
        {
            g.FillEllipse(Brushes.CornflowerBlue, x, y, 40, 40);
        }
    }
}
