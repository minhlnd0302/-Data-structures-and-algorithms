using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Collections;
using System.Threading;
namespace LinkedListViewer
{
    class DrawNode
    { 
        Pen p_bl = new Pen(Color.Black, 3);
        Pen p_gre = new Pen(Color.Green, 3);
        Pen p_red = new Pen(Color.Red, 3);
        const int dai = 50, rong = 50;
       
        public void UpdateNode(ArrayList a,Graphics g)
        {
            
            int dem = 0;
            
            foreach (Node k in a)
            {
                VeNode(dem*150,g,p_bl);
                //Thread.Sleep(1000);
                //UpdateValue(a, g);
                dem++;

            }
        }
        public void VeNode(int dem,Graphics g,Pen p)
        {
            
            
            Point pt = new Point(dem*150, 200);
            Rectangle hv = new Rectangle(pt.X, pt.Y, dai, rong);
            g.DrawRectangle(p, hv);
            g.DrawRectangle(p, dem*150 + dai, pt.Y, dai, rong);
           


        }
        private void VeNarrow(int dem,Graphics g,Pen p)
        {
            p.EndCap = LineCap.ArrowAnchor;
            g.DrawLine(p, dem * 150 + 100, 225, dem * 150 + 150, 225);
            Thread.Sleep(50);
        }
        public void Search(ArrayList a,int value,Graphics g)
        {
            int dem = 0;
            foreach (Node tmp in a)
            {
                UpdateNode(a, g);
                
                VeNode(dem*150, g, p_gre);
                if (tmp.value == value)
                {
                    Thread.Sleep(500);
                    VeNode(dem*150, g, p_red);
                    break;
                }
                dem++;
                Thread.Sleep(1000);
            }
        }
        public void CreateNode(Graphics g,ArrayList a,int Idx)
        {
            int dem = 0;
            foreach(Node tmp in a)
            {
                if(dem==Idx)
                {
                    VeNode(dem*150, g, p_bl);
                    break;
                }
                dem++;
            }
        }
        public void fill_Addr(Graphics g,int vt)
        {
            Pen p = new Pen(Color.White, 10);
            float tmp = (float)vt;
            g.FillRectangle(Brushes.White, (float)(tmp * 150+52), (float)(200+2), (float)(50 - 2), (float)(50 - 2)); ;
        }
        public void fill_val(Graphics g, int vt)
        {
            Pen p = new Pen(Color.White, 10);
            float tmp = (float)vt;
            g.FillRectangle(Brushes.White, (float)(tmp * 150 + 2), (float)(200 + 2), (float)(50 - 2), (float)(50 - 2)); ;
        }
        public void Check_Node_Drawing(int vt,Graphics g)
        {
            Point pt = new Point(vt * 150, 200);
            g.DrawRectangle(p_red, pt.X, pt.Y, 50, 50);
            g.DrawRectangle(p_red, pt.X+50, pt.Y, 50, 50);
        }
    }
}
