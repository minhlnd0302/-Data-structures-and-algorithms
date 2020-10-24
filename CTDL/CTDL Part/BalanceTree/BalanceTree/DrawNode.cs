using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BalanceTree
{
    class DrawNode
    {
        Pen p_black = new Pen(Color.Black, 10);
        Pen p_blue = new Pen(Color.Blue, 10);
        Pen p_orange = new Pen(Color.Orange, 3);
        Pen p_red = new Pen(Color.Red, 3);
        Pen p_white = new Pen(Color.White, 3);
        Pen p_yellow = new Pen(Color.Yellow, 10);
        Font font = new Font("Times New Roman", 12, FontStyle.Bold);
        Font font1 = new Font("Times New Roman", 8);
        public void drawNode(int x, int y, Graphics g)
        {
            g.DrawEllipse(p_white, x, y, 40, 40);
        }
        public void drawNodeAndValue(int x, int y, int val, Graphics g)
        {
            g.DrawEllipse(p_white, x, y, 40, 40);
            if (val > 9)
            {
                if (val > 99)
                {
                    if (val > 999)
                    {
                        g.DrawString(val.ToString(), font, Brushes.White, x + 3, y + 10);
                    }
                    else
                    {
                        g.DrawString(val.ToString(), font, Brushes.White, x + 7, y + 10);
                    }
                }
                else
                {
                    g.DrawString(val.ToString(), font, Brushes.White, x + 10, y + 10);
                }
            }
            else
            {
                g.DrawString(val.ToString(), font, Brushes.White, x + 13, y + 10);
            }
        }
        public void drawArrow(int x, int y, int z, int t, Graphics g)
        {
            p_white.EndCap = LineCap.ArrowAnchor;
            if (x > z)
            {
               g.DrawLine(p_white, x, y+30, z+30, t);
            }
            else
            {
                g.DrawLine(p_white, x+38, y+30, z+10, t);
            }
            if(y>t)
            {
                g.DrawLine(p_white, x+20, y, z + 30, t+30);
            }
        }
        public void drawRedArrow(int x, int y, int z, int t, Graphics g)
        {
            p_yellow.EndCap = LineCap.ArrowAnchor;
            if (x > z)
            {
                g.DrawLine(p_yellow, x, y + 30, z + 30, t);
            }
            else
            {
                g.DrawLine(p_yellow, x + 38, y + 30, z + 10, t);
            }
            if (y > t)
            {
                g.DrawLine(p_yellow, x + 20, y, z + 30, t + 30);
            }
        }
        public void fillAnyPart(int x,int y,int z,int t,Graphics g)
        {
            g.FillRectangle(Brushes.Red, x, y, z, t);
        }
        public void drawLevel(int x,int y,int k,Graphics g)
        {
            g.DrawString(k.ToString(), font1, Brushes.Yellow, x, y);
        }
    }
}
