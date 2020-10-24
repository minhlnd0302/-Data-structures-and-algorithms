using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace QueueAnimater
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
    class Queue
    {
        private Node front;
        DrawNode drn = new DrawNode();
        DrawCode drc = new DrawCode();
        public Node mfront
        {
            get; set;
        }

        public Queue()
        {
            front = null;
        }
        public void EndQueue(int key,Graphics g)
        {
            drc.EnQu(6, g);
            Thread.Sleep(1000);
            drc.EnQu(7, g);
            Thread.Sleep(1000);
            



            if (front == null)
            {
                drc.EnQu(1, g);
                Thread.Sleep(1000);
                drc.EnQu(2, g);
                drn.fillfront(300, 50, g);
                Application.DoEvents();
                Thread.Sleep(1000);
                front = new Node(key);
                drc.EnQu(3, g);
                #region scale
                if (front.mdata > 9)
                    if (front.mdata > 99)

                        if (front.mdata > 999)
                            drn.DrawVal(302, 60, g, front.mdata.ToString());
                        else
                            drn.DrawVal(305, 60, g, front.mdata.ToString());
                    else
                        drn.DrawVal(309, 60, g, front.mdata.ToString());
                else
                    drn.DrawVal(313, 62, g, front.mdata.ToString());

                #endregion
                Thread.Sleep(500);
                drc.EnQu(4, g);

                Thread.Sleep(500);
                drc.EnQu(5, g);

                Thread.Sleep(500);
                drc.EnQu(8, g);

                Thread.Sleep(500);
                drc.EnQu(9, g);


                Application.DoEvents();

                drn.DrawVal(300, 30, g, "Front");
                drn.DrawVal(300, 90, g, "Rear");
              //  Thread.Sleep(500);

            }
            else
            {
                Node tmp = front;
                Node k = front;
                int x = 300;
                int y = 50;
                Application.DoEvents();
                drn.DrawOval(200, 330, g);
                drc.EnQu(1, g);
                Thread.Sleep(1000);
                drc.EnQu(2, g);
               // drn.fillfront(300, 50, g);
                Thread.Sleep(500);
                drc.EnQu(3, g);
                #region scale
                if (key > 9)
                    if (key > 99)

                        if (key > 999)
                            drn.DrawVal(202, 340, g, key.ToString());
                        else
                            drn.DrawVal(205, 340, g, key.ToString());
                    else
                        drn.DrawVal(209, 340, g, key.ToString());
                else
                    drn.DrawVal(213, 340, g, key.ToString());
                #endregion
                Thread.Sleep(1000);
                drc.EnQu(4, g);
                Thread.Sleep(1000);
                drc.EnQu(5, g);
                Thread.Sleep(1000);
                #region tmp
                //while (tmp!=null)
                //{
                //    // drn.DrawOval(x, y - 70, g);
                //    if (tmp != front)
                //    {
                //        if (tmp == front.next || tmp == null)
                //            drn.de_red(x, y - 70, g);
                //        else
                //            drn.de_green(x, y - 70, g);

                //    }
                //    drn.duyet(x, y, g);
                //    y += 70;
                //    tmp = tmp.next;
                //    Application.DoEvents();
                //    Thread.Sleep(1000);
                //}
                #endregion


                x = 300;
                y = 50;
                Node temp = front;
                while (temp.next != null)
                {
                    temp = temp.next;
                    y += 70;
                }
                temp.next = new Node(key);
                drc.EnQu(11, g);
                #region scale
                switch((int)(y/70))
                {
                    case 0:
                        drn.DrawNarr(305, y + 30, 230, 340, g);
                        break;
                    case 1:
                        drn.DrawNarr(308, y + 30, 233, 343, g);
                        break;
                    case 2:
                        drn.DrawNarr(311, y + 33, 236, 346, g);
                        break;
                    case 3:
                        drn.DrawNarr(311, y + 35, 240, 350, g);
                        break;
                    case 4:
                        drn.DrawNarr(305, y + 25, 240, 350, g);
                        break;
                    case 5:
                        drn.DrawNarr(300, y + 20, 240, 350, g);
                        break;
                    case 6:
                        drn.DrawNarr(300, y + 20, 238, 365, g);
                        break;
                    case 7:
                        drn.DrawNarr(300, y + 20, 236, 363, g);
                        break;
                    case 8:
                        drn.DrawNarr(300, y + 20, 233, 360, g);
                        break;

                }





                #endregion
                
                Application.DoEvents();
                Thread.Sleep(1000);
                 tmp = front;
                y = 50;
                g.Clear(Color.SlateBlue);
                drc.EnQu(12, g);
                while (tmp != null)
                {
                    if (tmp != front)
                        drn.DrawOval(x, y, g);
                    else
                    {
                        //drn.DrawVal(280, 50, g, "Top");
                        drn.check_front(x, y, g);
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
                    #endregion
                    if (tmp.next != null)
                    {
                        drn.DrawNarr(x + 20, y + 40, x + 20, y + 70, g);
                    }
                    else
                    {
                        drn.fillfront(x, y, g);
                        drn.DrawVal(x + 10, y + 50, g, "Rear");
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
                    #endregion
                    tmp = tmp.next;
                    y += 70;

                }
            }
        }
        public void DeQueue(Graphics g)
        {
            
            
            int x = 300;
            int y = 50;
            g.FillRectangle(Brushes.SlateBlue, 450, 0, 1000, 1000);
            drc.DeQu(13, g);
            Thread.Sleep(1000);
            drc.DeQu(14, g);
            Thread.Sleep(1000);
            g.Clear(Color.SlateBlue);
            Node tmp = front;
            drc.DeQu(15, g);
            while (tmp != null)
            {
                if (tmp != front.next)
                    drn.DrawOval(x, y, g);
                else 
                {
                    drn.check_front(x, y, g);
                }
                #region scale
                if (tmp.next == null)
                {
                    drn.fillfront(x, y, g);
                    drn.DrawVal(x + 10, y + 50, g, "Rear");

                }
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
            
            tmp = front;
            Application.DoEvents();
            Thread.Sleep(1000);
           
            if (front != null)
            {
                while(tmp.next!=null)
                {
                    tmp = tmp.next;
                    y += 70;
                }

                front = front.next;

            }
            tmp = front;
            x = 300;
            y = 50;
            drc.DeQu(16, g);
            Thread.Sleep(1000);
            g.Clear(Color.SlateBlue);
            drc.DeQu(18, g);
            while (tmp != null)
            {
                if (tmp != front)
                    drn.DrawOval(x, y, g);
                else
                {
                    //drn.DrawVal(280, 50, g, "Top");
                    drn.check_front(x, y, g);
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
                #endregion
                if (tmp.next != null)
                {
                    drn.DrawNarr(x + 20, y + 40, x + 20, y + 70, g);
                }
                else 
                {
                    drn.fillfront(x, y, g);
                    drn.DrawVal(x + 10, y + 50, g, "Rear");
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
                #endregion
                tmp = tmp.next;
                y += 70;

            }
            Thread.Sleep(1000);
           


        }

        public bool IsEmpty()
        {
            if (front == null)
                return true;
            return false;
        }
        public void Front(Graphics g)
        {
            g.FillRectangle(Brushes.SlateBlue, 450, 0, 1000, 1000);
            drc.Frnt(19, g);
            Thread.Sleep(1000);
            drc.Frnt(20, g);
            Thread.Sleep(1000);
            if (front != null)
            {
                drc.Frnt(21, g);
                drn.front(300, 50, g);
                if (front.mdata > 9)
                    if (front.mdata > 99)

                        if (front.mdata > 999)
                            drn.DrawVal(302, 50 + 10, g, front.mdata.ToString());
                        else
                            drn.DrawVal(305, 50 + 10, g, front.mdata.ToString());
                    else
                        drn.DrawVal(309, 50 + 10, g, front.mdata.ToString());
                else
                    drn.DrawVal(313, 50 + 10, g, front.mdata.ToString());
            }
            else
                drc.Frnt(22, g);
        }

    }
}
