using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BalanceTree
{
    class DrawCode
    {
        string[] s = new string [10];
        Pen p_black = new Pen(Color.Black, 10);
        Pen p_blue = new Pen(Color.Blue, 10);
        Pen p_orange = new Pen(Color.Orange, 3);
        Pen p_red = new Pen(Color.Red, 3);
        Pen p_white = new Pen(Color.White, 3);
        Pen p_yellow = new Pen(Color.Yellow, 10);
        Font font = new Font("Consolas", 30, FontStyle.Bold);
        Font font1 = new Font("Consolas", 8);
        public void setString()
        {
            s[0] = "Insert Node";
            s[1] = "Tree is Unbalance!";
            s[2] = "Tree is Balance!";
            s[3] = "Case Left-Left";
            s[4] = "Case Left-Right";
            s[5] = "Case Right-Right";
            s[6] = "Case Right-Left";
            s[7] = "Rotate Right";
            s[8] = "Rotate Left";
            s[9] = "Delete Node";
        }
        public void DisplayCode(int vt,Graphics g)
        {
            setString();
           
            g.FillRectangle(Brushes.Black, 800, 300, 500, 500);
            if (vt == 0 || vt == 9)
                g.DrawString(s[vt], font, Brushes.White, 800, 300);
            if(vt==2)
                g.DrawString(s[vt], font, Brushes.Lime, 800, 300);
            if(vt==1||vt==3||vt==4||vt==5||vt==6)
                g.DrawString(s[vt], font, Brushes.Red, 800, 300);
            if(vt==7||vt==8)
                g.DrawString(s[vt], font, Brushes.Yellow, 800, 300);
        }
        
    }
}
