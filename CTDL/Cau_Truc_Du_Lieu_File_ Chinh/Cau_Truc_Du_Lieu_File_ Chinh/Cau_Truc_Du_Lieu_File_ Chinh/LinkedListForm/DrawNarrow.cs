using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace LinkedListViewer
{
    class DrawNarrow
    {
        public void Draw_Narrow(Graphics g,int vt,Pen p)
        {
            Point pt = new Point(vt * 150 + 100, 225);
            p.EndCap = LineCap.ArrowAnchor;
            g.DrawLine(p, pt.X,pt.Y, pt.X + 50, pt.Y);
        }
    }
}
