using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace StackAnimate
{
    
    class Node
    {
        private int data;
       
        private Node p_Next;
       
        public int mdata
        {
            get { return data; }
            set { data = value; }

        }
       
       
        public Node next { get { return p_Next; } set { p_Next = value; } }
       
        public Node()
        {
            data = 0;
            
            p_Next = null;
            
        }
        public Node(int key)
        {
            data = key;
            p_Next = null;
            
            
        }
    }
    class Stack
    {
        DrawNode drn = new DrawNode();
        DrawCode drc = new DrawCode();
        private Node top;
        public Node mtop
        {
            get; set;
        }

        public Stack()
        {
            top = null;
        }
        public void Push(int key, Graphics g)
        {

            g.FillRectangle(Brushes.SlateBlue, 450, 0, 1000, 1000);
            if (top == null)
            {
                drc.DrawStr(13, g);
                Thread.Sleep(500);
                drc.DrawStr(14, g);
                Thread.Sleep(500);
                drc.DrawStr(15, g);
                Thread.Sleep(500);
                drc.DrawStr(6, g);
                Thread.Sleep(500);
                drc.DrawStr(7, g);
                drn.filltop(300, 50, g);
                Thread.Sleep(500);

                drc.DrawStr(8, g);
               

                
                Thread.Sleep(500);
                top = new Node(key);
                #region scale
                if (top.mdata > 9)
                    if (top.mdata > 99)
                    
                        if (top.mdata > 999)
                            drn.DrawVal(302, 60, g, top.mdata.ToString());
                        else
                            drn.DrawVal(305, 60, g, top.mdata.ToString());
                    else
                        drn.DrawVal(309 , 60, g, top.mdata.ToString());
                else
                    drn.DrawVal(313, 62, g, top.mdata.ToString());
               // drc.DrawStr(1, g);
                #endregion
                Thread.Sleep(500);
                drc.DrawStr(9, g);
                Thread.Sleep(500);
                drc.DrawStr(10, g);
                Thread.Sleep(500);
                drc.DrawStr(16, g);
                drn.DrawVal(305, 30, g, "Top");

            }
            else
            {

                //g.Clear(Color.MediumTurquoise);
                drc.DrawStr(13, g);
                Thread.Sleep(500);
                drc.DrawStr(14, g);
                Thread.Sleep(500);
                drc.DrawStr(18, g);
                Thread.Sleep(500);
                drc.DrawStr(6, g);
                Thread.Sleep(500);
               
               
               
                #region tempNode
                drc.DrawStr(7, g);
                drn.DrawOval(200, 50, g);
                Thread.Sleep(500);
                #region scale
                if (key > 9)
                    if (key > 99)

                        if (key > 999)
                            drn.DrawVal(202, 60, g, key.ToString());
                        else
                            drn.DrawVal(205, 60, g, key.ToString());
                    else
                        drn.DrawVal(209, 60, g, key.ToString());
                else
                    drn.DrawVal(213, 60, g, key.ToString());
                #endregion
                #endregion
                drc.DrawStr(8, g);
                Thread.Sleep(500);
                drc.DrawStr(9, g);
                Thread.Sleep(500);
                drc.DrawStr(10, g);
                Thread.Sleep(500);
                drc.DrawStr(19, g);
                drn.DrawNarr(240, 70, 300, 70,g);
                Thread.Sleep(500);
                g.Clear(Color.SlateBlue);
                drc.DrawStr(20, g);
                Node temp = new Node(key);
                temp.next = top;
                top = temp;
                Node tmp = top;
                int x = 300;
                int y = 50;
                while(tmp!=null)
                {
                    if (tmp != top)
                        drn.DrawOval(x, y, g);
                    else
                    {
                        //drn.DrawVal(280, 50, g, "Top");
                        drn.check_top(x, y, g);
                    }
                    #region scale
                    if (tmp.mdata > 9)
                        if (tmp.mdata > 99)

                            if (tmp.mdata > 999)
                                drn.DrawVal(302, y+10, g, tmp.mdata.ToString());
                            else
                                drn.DrawVal(305, y+10, g, tmp.mdata.ToString());
                        else
                            drn.DrawVal(309, y+10, g, tmp.mdata.ToString());
                    else
                        drn.DrawVal(313, y+10, g, tmp.mdata.ToString());
                    #endregion
                    if (tmp.next!=null)
                        drn.DrawNarr(x + 20, y + 40, x + 20, y + 70,g);
                    tmp = tmp.next;
                    y += 70;

                }
                
                


            }
        }
        public void Pop(Graphics g)
        {
            // g.Clear(Color.SlateBlue);
            g.FillRectangle(Brushes.SlateBlue, 450, 0, 1000, 1000);
            drc.DrawPop(21, g);
            Thread.Sleep(500);
            drc.DrawPop(22, g);
            Thread.Sleep(500);
            if (top == null)
                drc.DrawPop(23, g);
            else
            {
                drc.DrawPop(26, g);
                Thread.Sleep(500);
                drc.DrawPop(27,g);
                Node tmp = top;
                int x = 300;
                int y = 50;
                while (tmp != null)
                {
                    if (tmp != top.next)
                        drn.DrawOval(x, y, g);
                    else
                    {

                        drn.check_top(x, y, g);
                    }
                    #region scale
                    if (tmp.mdata > 9)
                        if (tmp.mdata > 99)

                            if (tmp.mdata > 999)
                                drn.DrawVal(302, y + 10, g, tmp.mdata.ToString());
                            else
                                drn.DrawVal(305, y + 10, g, tmp.mdata.ToString());
                        else
                            drn.DrawVal(309, y + 10, g, tmp.mdata.ToString());
                    else
                        drn.DrawVal(313, y + 10, g, tmp.mdata.ToString());
                    if (tmp.next != null)
                        drn.DrawNarr(x + 20, y + 40, x + 20, y + 70, g);
                    #endregion
                    tmp = tmp.next;
                    y += 70;

                }
                Thread.Sleep(500);
                if (top != null)
                {

                    top = top.next;
                }
                tmp = top;
                x = 300;
                y = 50;
                g.Clear(Color.SlateBlue);
                while (tmp != null)
                {

                    if (tmp != top)
                        drn.DrawOval(x, y, g);
                    else
                    {
                        //drn.DrawVal(280, 50, g, "Top");
                        drn.check_top(x, y, g);
                    }
                    //drn.DrawOval(x, y, g);
                    #region
                    if (tmp.mdata > 9)
                        if (tmp.mdata > 99)

                            if (tmp.mdata > 999)
                                drn.DrawVal(302, y + 10, g, tmp.mdata.ToString());
                            else
                                drn.DrawVal(305, y + 10, g, tmp.mdata.ToString());
                        else
                            drn.DrawVal(309, y + 10, g, tmp.mdata.ToString());
                    else
                        drn.DrawVal(313, y + 10, g, tmp.mdata.ToString());
                    if (tmp.next != null)
                        drn.DrawNarr(x + 20, y + 40, x + 20, y + 70, g);
                    #endregion
                    tmp = tmp.next;
                    y += 70;

                }
                drc.DrawPop(29, g);

            }
        }
       
        public int Size()
        {
            int dem = 0;
            Node tmp = top;
            while (tmp != null)
            {
                tmp = tmp.next;
                dem++;
            }
            return dem;
        }
        public bool IsEmpty()
        {
            if (top == null)
                return true;
            return false;
        }
        public void Peek(Graphics g)
        {
            g.FillRectangle(Brushes.SlateBlue, 450, 0, 1000, 1000);
            drc.DrawTop(30, g);
            Thread.Sleep(500);
            drc.DrawTop(31, g);
            Thread.Sleep(500);
            if (top != null)
            {
                drc.DrawTop(33, g);
                Thread.Sleep(500);
                drc.DrawTop(34, g);
                Thread.Sleep(500);
                drn.Peek(300, 50, g);
                if (top.mdata > 9)
                    if (top.mdata > 99)

                        if (top.mdata > 999)
                            drn.DrawVal(302, 60, g, top.mdata.ToString());
                        else
                            drn.DrawVal(305, 60, g, top.mdata.ToString());
                    else
                        drn.DrawVal(309, 60, g, top.mdata.ToString());
                else
                    drn.DrawVal(313, 60, g, top.mdata.ToString());

            }
            else { drc.DrawTop(32, g);
                Thread.Sleep(500);
            }
        }

    }
}
