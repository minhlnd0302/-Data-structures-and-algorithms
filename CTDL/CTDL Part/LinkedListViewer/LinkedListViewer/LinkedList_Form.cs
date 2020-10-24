using System;
using System.Collections;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace LinkedListViewer
{
    public partial class LinkedList_Form : Form
    {
        //Node a = new Node();
        Random rnd = new Random();
        Graphics g;
        Pen p_bl = new Pen(Color.Black, 3);
        Pen p_blue = new Pen(Color.Blue, 4);
        Font font = new Font("Times New Roman", 12);
        DrawNode drawnode = new DrawNode();
        DrawCode drawcode = new DrawCode();
        DrawNarrow drawNarrow = new DrawNarrow();
        public LinkedList_Form()
        {
            InitializeComponent();
        }
        ArrayList a = new ArrayList();
        private void Button1_Click(object sender, EventArgs e)
        {

            if (a.Count == 0)
            {
                g = this.CreateGraphics();
                g.FillRectangle(Brushes.White, 800, 0, 800, 800);
                Node tmp = new Node();
                tmp.value = int.Parse(txbAddToHead.Text);
                tmp.addr = rnd.Next(0, 999);

                drawcode.drawString(1, g);
                Thread.Sleep(100);
                drawcode.drawString(2, g);
                Thread.Sleep(100);
                drawcode.drawString(3, g);
                Thread.Sleep(100);
                drawcode.drawString(4,g);
                Thread.Sleep(1000);
                CreateNode(0,txbAddToHead.Text);
                drawcode.drawString(5,g);
                Thread.Sleep(1000);
                drawcode.drawString(6, g);
                Thread.Sleep(1000);
                drawcode.drawString(7, g);
                Thread.Sleep(1000);

                a.Insert(0, tmp);
                g.FillRectangle(Brushes.White, 0, 0, 800, 800);
                UpdateNode(0);

               
            }
            else
            {
                g = this.CreateGraphics();
                g.FillRectangle(Brushes.White, 800, 0, 800, 800);
                drawcode.drawString(4, g);
                Thread.Sleep(500);
                g.FillRectangle(Brushes.White, 0, 0, 800, 800);
                drawnode.VeNode(0, g, p_blue);
                drawcode.DrawValue(g,txbAddToHead.Text,0);
                drawcode.DrawAddr(g, "NULL", 0);
               
                Node temp= new Node();
                temp.addr = rnd.Next(0, 999);
                temp.value = int.Parse(txbAddToHead.Text);

                UpdateNode_First(1);
                Application.DoEvents();
                Thread.Sleep(500);
                drawcode.drawString(8, g);
                
                drawNarrow.Draw_Narrow(g, 0, p_bl);
                Thread.Sleep(500);
                drawcode.drawString(9, g);
                a.Insert(0, temp);
                g.FillRectangle(Brushes.White, 0, 0, 800, 800);
                UpdateNode(0);


            }
        }

        private void BtnAddToTail_Click(object sender, EventArgs e)
        {
           if(a.Count==0)
           {
                g = this.CreateGraphics();
                g.FillRectangle(Brushes.White, 800, 0, 800, 800);
                Node tmp = new Node();
                tmp.value = int.Parse(txbAddToTail.Text);
                tmp.addr = rnd.Next(0, 999);
                drawcode.drawString(4, g);
                CreateNode(0, txbAddToTail.Text);
                Application.DoEvents();
                Thread.Sleep(1000);
                drawcode.drawString(10, g);
                Thread.Sleep(500);
                drawcode.drawString(11, g);
                Thread.Sleep(1000);

                a.Insert(a.Count, tmp);
                g.FillRectangle(Brushes.White, 0, 0, 800, 800);
                UpdateNode(0);
                drawcode.drawString(12, g);
                Thread.Sleep(1000);
 
           }
            else
            {
                g = this.CreateGraphics();
                g.FillRectangle(Brushes.White, 800, 0, 800, 800);
                drawcode.drawString(4, g);
                Thread.Sleep(500);

                g.FillRectangle(Brushes.White, 0, 0, 800, 800);
                UpdateNode(0);
                drawnode.VeNode(a.Count, g, p_blue);
                drawcode.DrawValue(g, txbAddToTail.Text, a.Count);
                drawcode.DrawAddr(g, "NULL", a.Count);
                //Thread.Sleep(5000);

                Node temp = new Node();
                temp.addr = rnd.Next(0, 999);
                temp.value = int.Parse(txbAddToTail.Text);

                drawcode.drawString(10, g);
                Thread.Sleep(1000);
                drawcode.drawString(11, g);
                Thread.Sleep(1000);

                UpdateNode(0);
                Thread.Sleep(500);
                drawcode.drawString(13, g);
                drawNarrow.Draw_Narrow(g, a.Count-1, p_bl);
                Thread.Sleep(500);
                drawcode.drawString(14, g);
                a.Insert(a.Count, temp);
                g.FillRectangle(Brushes.White, 0, 0, 800, 800);
                UpdateNode(0);
                Thread.Sleep(500);
            }

        }

        private void BtnAddRandom_Click(object sender, EventArgs e)
        {
            if (int.Parse(txbAfterValue.Text) == 0)
            {
                if (a.Count == 0)
                {
                    g = this.CreateGraphics();
                    g.FillRectangle(Brushes.White, 800, 0, 800, 800);
                    Node tmp = new Node();
                    tmp.value = int.Parse(txbAddValue.Text);
                    tmp.addr = rnd.Next(0, 999);
                    drawcode.drawString(15, g);
                    Thread.Sleep(500);
                    drawcode.drawString(16, g);
                    Thread.Sleep(500);
                    drawcode.drawString(3, g);
                    Thread.Sleep(500);
                    drawcode.drawString(17, g);
                    Thread.Sleep(500);
                   
                    drawcode.drawString(5, g);
                    Thread.Sleep(1000);
                    drawcode.drawString(4, g);
                    CreateNode(0, txbAddValue.Text);
                    Thread.Sleep(1000);
                  
                    drawcode.drawString(5, g);
                    Thread.Sleep(1000);
                    drawcode.drawString(6, g);
                    Thread.Sleep(1000);
                    drawcode.drawString(7, g);
                    Thread.Sleep(1000);
                    a.Insert(0, tmp);
                    g.FillRectangle(Brushes.White, 0, 0, 800, 800);
                    UpdateNode(0);


                }
                else
                {
                    g = this.CreateGraphics();
                    g.FillRectangle(Brushes.White, 800, 0, 800, 800);
                    drawcode.drawString(4, g);
                    Thread.Sleep(500);
                    g.FillRectangle(Brushes.White, 0, 0, 800, 800);
                    drawnode.VeNode(0, g, p_blue);
                    drawcode.DrawValue(g, txbAddValue.Text, 0);
                    drawcode.DrawAddr(g, "NULL", 0);

                    Node temp = new Node();
                    temp.addr = rnd.Next(0, 999);
                    temp.value = int.Parse(txbAddValue.Text);

                    UpdateNode_First(1);
                    Thread.Sleep(500);
                    drawcode.drawString(8, g);

                    drawNarrow.Draw_Narrow(g, 0, p_bl);
                    Thread.Sleep(500);
                    drawcode.drawString(9, g);
                    a.Insert(0, temp);
                    g.FillRectangle(Brushes.White, 0, 0, 800, 800);
                    UpdateNode(0);


                }
            }
            else if(int.Parse(txbAfterValue.Text)>=a.Count+1)
            {
                if (a.Count == 0)
                {

                    g = this.CreateGraphics();
                    Node tmp = new Node();
                    tmp.value = int.Parse(txbAddValue.Text);
                    tmp.addr = rnd.Next(0, 999);

                    g.FillRectangle(Brushes.White, 800, 0, 800, 800);

                    drawcode.Drawstring_AddAT(g, 15);
                    Thread.Sleep(500);
                    drawcode.Drawstring_AddAT(g,16);
                    Thread.Sleep(500);
                    drawcode.Drawstring_AddAT(g,18);
                    Thread.Sleep(500);
                    drawcode.Drawstring_AddAT(g,19);
                    Thread.Sleep(500);
                    drawcode.Drawstring_AddAT(g,20);
                    Thread.Sleep(500);
                    drawcode.Drawstring_AddAT(g, 21);
                    Thread.Sleep(500);
                    drawcode.Drawstring_AddAT(g, 22);
                    Thread.Sleep(500);
                    drawcode.Drawstring_AddAT(g, 23);
                    Thread.Sleep(500);
                    //  AddRand_Check(g, a, int.Parse(txbAfterValue.Text));

                    g.FillRectangle(Brushes.White, 800, 0, 800, 800);

                    drawcode.drawString(4, g);
                    Thread.Sleep(1000);
                    CreateNode(0, txbAddValue.Text);
                    drawcode.drawString(10, g);
                    Thread.Sleep(500);
                    drawcode.drawString(11, g);
                    Thread.Sleep(500);
                    drawcode.drawString(12, g);
                    Thread.Sleep(500);
                    a.Insert(a.Count, tmp);
                    g.FillRectangle(Brushes.White, 0, 0, 800, 800);
                    UpdateNode(0);


                }
                else
                {
                    g = this.CreateGraphics();
                    g.FillRectangle(Brushes.White, 800, 0, 800, 800);
                    drawcode.Drawstring_AddAT(g, 15);
                    Thread.Sleep(500);
                    drawcode.Drawstring_AddAT(g, 16);
                    Thread.Sleep(500);
                    drawcode.Drawstring_AddAT(g, 18);
                    Thread.Sleep(500);
                    drawcode.Drawstring_AddAT(g, 19);
                    Thread.Sleep(500);
                    drawcode.Drawstring_AddAT(g, 20);

                    AddRand_Check(g, a, int.Parse(txbAfterValue.Text));
                    drawcode.Drawstring_AddAT(g, 22);
                    Thread.Sleep(500);
                    drawcode.Drawstring_AddAT(g, 23);
                    Thread.Sleep(500);
                    g.FillRectangle(Brushes.White, 800, 0, 800, 800);

                    drawcode.drawString(4, g);
                    Thread.Sleep(500);

                   // g.FillRectangle(Brushes.White, 0, 0, 800, 800);
                    drawnode.VeNode(a.Count, g, p_blue);
                    drawcode.drawString(10, g);
                    Thread.Sleep(500);
                    drawcode.drawString(11, g);
                    Thread.Sleep(500);
                   
                    drawcode.DrawValue(g, txbAddValue.Text, a.Count);
                    drawcode.DrawAddr(g, "NULL", a.Count);
                    //Thread.Sleep(5000);
                    drawcode.drawString(13, g);
                    Thread.Sleep(500);
                    Node temp = new Node();
                    temp.addr = rnd.Next(0, 999);
                    temp.value = int.Parse(txbAddValue.Text);

                    // UpdateNode_First(1);
                    UpdateNode(0);
                    Thread.Sleep(500);
                    // drawcode.drawString(8, g);
                    drawcode.drawString(13, g);
                    drawNarrow.Draw_Narrow(g, a.Count - 1, p_bl);
                    Thread.Sleep(500);
                    drawcode.drawString(14, g);
                    a.Insert(a.Count, temp);
                    g.FillRectangle(Brushes.White, 0, 0, 800, 800);
                    UpdateNode(0);
                }
            }
            else if (int.Parse(txbAfterValue.Text) < a.Count + 1)
            {
                g = this.CreateGraphics();
                g.FillRectangle(Brushes.White, 800, 0, 800, 800);
               
                drawcode.Drawstring_AddAT(g, 16);
                Thread.Sleep(500);
                drawcode.Drawstring_AddAT(g, 18);
                Thread.Sleep(500);
                drawcode.Drawstring_AddAT(g, 19);
                Thread.Sleep(500);
                drawcode.Drawstring_AddAT(g, 20);
                Thread.Sleep(500);
                //g.FillRectangle(Brushes.White,0,0, 800, 800);
                AddRand_Check(g, a, int.Parse(txbAfterValue.Text));
               // g.FillRectangle(Brushes.White, 0, 0, 800, 800);
                veNode_Mid(g, int.Parse(txbAfterValue.Text));
                Thread.Sleep(2000);
                g.FillRectangle(Brushes.White, 0, 0, 800, 800);
                //Thread.Sleep(1000);
                
                Node tmp = new Node(); 
                tmp.addr = rnd.Next(0, 999);
                tmp.value = int.Parse(txbAddValue.Text);

                a.Insert(int.Parse(txbAfterValue.Text), tmp);
                UpdateNode(0);
              
            }

        }
        private void BtnDelHead_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
           
                g.FillRectangle(Brushes.White, 800, 0, 800, 800);
                drawcode.Drawstring_DelAt(g, 26);
                Thread.Sleep(1000);
                drawcode.Drawstring_DelAt(g, 27);
                Thread.Sleep(1000);
                drawcode.Drawstring_DelAt(g, 28);
                Thread.Sleep(1000);
                drawcode.Drawstring_DelAt(g, 29);
               
                g.DrawRectangle(p_blue, 0, 200, 50, 50);
                g.DrawRectangle(p_blue, 50, 200, 50, 50);
                Thread.Sleep(1000);
               
                g.FillRectangle(Brushes.White, 0, 150, 100, 47);
                Thread.Sleep(3000);
                
                g.FillRectangle(Brushes.White, 150, 150, 800, 400);
                a.RemoveAt(0);
                drawcode.Drawstring_DelAt(g, 30);
                g.FillRectangle(Brushes.White, 102,200, 48, 47);
                UpdateNode_First(1);
                Thread.Sleep(2000);
                //Thread.Sleep(1000);
                g.FillRectangle(Brushes.White, 0, 150, 800, 400);
                drawcode.Drawstring_DelAt(g, 31);
                
                UpdateNode(0);
           
        }

        private void BtnDelTail_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.FillRectangle(Brushes.White, 800, 0, 800, 800);
            drawcode.Drawstring_DelAt(g,32);
            Thread.Sleep(1000);
            drawcode.Drawstring_DelAt(g,33);
            Thread.Sleep(1000);
            if (a.Count==1)
            {
                drawcode.Drawstring_DelAt(g, 34);
                g.FillRectangle(Brushes.White, 800, 0, 800, 800);
                drawcode.Drawstring_DelAt(g, 26);
                Thread.Sleep(1000);
                drawcode.Drawstring_DelAt(g, 27);
                Thread.Sleep(1000);
                drawcode.Drawstring_DelAt(g, 28);
                Thread.Sleep(1000);
                drawcode.Drawstring_DelAt(g, 29);

                g.DrawRectangle(p_blue, 0, 200, 50, 50);
                g.DrawRectangle(p_blue, 50, 200, 50, 50);
                Thread.Sleep(1000);

                g.FillRectangle(Brushes.White, 0, 150, 100, 47);
                Thread.Sleep(3000);

                g.FillRectangle(Brushes.White, 150, 150, 800, 400);
                a.RemoveAt(0);
                drawcode.Drawstring_DelAt(g, 30);
                g.FillRectangle(Brushes.White, 102, 200, 48, 47);
                UpdateNode_First(1);
                Thread.Sleep(2000);
                //Thread.Sleep(1000);
                g.FillRectangle(Brushes.White, 0, 150, 800, 400);
                drawcode.Drawstring_DelAt(g, 31);

                UpdateNode(0);
            }
            else
            {
                
                drawcode.Drawstring_DelAt(g, 35);
                Thread.Sleep(1000);
                g.DrawRectangle(p_blue, 0, 200, 50, 50);
                g.DrawRectangle(p_blue, 50, 200, 50, 50);
                Thread.Sleep(1000);
                drawcode.Drawstring_DelAt(g, 36);
                Thread.Sleep(500);
                drawcode.Drawstring_DelAt(g, 37);
                Search_VT(g, a, a.Count - 2);
                drawcode.Drawstring_DelAt(g, 37);
                Thread.Sleep(1000);
                g.FillRectangle(Brushes.White, (a.Count - 2) * 150 + 51, 202, 47, 47);
                g.FillRectangle(Brushes.White, (a.Count - 1) * 150 - 48, 200, 48, 48);
                drawcode.Drawstring_DelAt(g, 38);
               
                g.DrawString("NULL", font, Brushes.Black,(a.Count-2)*150+50,210);
                Thread.Sleep(5000);
                
                a.RemoveAt(a.Count - 1);
                g.FillRectangle(Brushes.White, 0, 150, (a.Count)*150, 400);
                drawcode.Drawstring_DelAt(g, 39);
                //Thread.Sleep(5000);
                UpdateNode(0);
                Thread.Sleep(1000);
                drawcode.Drawstring_DelAt(g, 40);
                g.FillRectangle(Brushes.White, 0, 150, 800, 400);
                UpdateNode(0);




            }
        }

        private void BtnDel_Index_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.FillRectangle(Brushes.White, 800, 0, 800, 800);
            drawcode.Drawstring_DelIDX(g, 41);
            Thread.Sleep(1000);
            drawcode.Drawstring_DelIDX(g, 42);
            if (int.Parse(txbDel_Value.Text) == 0)
            {
                drawcode.Drawstring_DelIDX(g, 43);
                BtnDelHead_Click(sender, e);
            }
            else
            {
                drawcode.Drawstring_DelIDX(g, 44);
                Thread.Sleep(1000);
                drawcode.Drawstring_DelIDX(g, 45);
                Thread.Sleep(1000);
                drawcode.Drawstring_DelIDX(g, 46);
                Thread.Sleep(1000);
                /*drawcode.Drawstring_DelIDX(g, 47);
                Thread.Sleep(1000);*/
                Searching(g, a, int.Parse(txbDel_Value.Text));
                Application.DoEvents();
                drawcode.Drawstring_DelIDX(g, 50);
                Thread.Sleep(1000);
                if (int.Parse(txbDel_Value.Text) >= a.Count)
                {
                    drawcode.Drawstring_DelIDX(g, 51);
                    BtnDelTail_Click(sender, e);
                }
                else
                {
                    drawcode.Drawstring_DelIDX(g, 52);
                    Thread.Sleep(1000);
                    g.FillRectangle(Brushes.White, int.Parse(txbDel_Value.Text) * 150-48, 119, 197, 200);
                    p_bl.EndCap = LineCap.ArrowAnchor;
                    Thread.Sleep(1000);
                    drawcode.Drawstring_DelIDX(g, 52);
                    g.DrawLine(p_bl, int.Parse(txbDel_Value.Text) * 150 - 50, 225, (int.Parse(txbDel_Value.Text) + 1) * 150, 225);
                    Thread.Sleep(1000);

                    a.RemoveAt(int.Parse(txbDel_Value.Text));
                    g.FillRectangle(Brushes.White, 0, 0, 800, 800);
                    UpdateNode(0);
                }


            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.FillRectangle(Brushes.White, 800, 0, 800, 800);
            drawcode.Drawstring_Search(g, 54);
            Thread.Sleep(1000);
            drawcode.Drawstring_Search(g, 55);
            Thread.Sleep(1000);
            btnsearch(g, a, int.Parse(txbSearch_Val.Text));
            
        }
        public void CreateNode(int vt,string s) 
        {

            drawnode.VeNode(vt, g, p_bl);
            drawcode.DrawAddr(g, "NULL", vt);
            drawcode.DrawValue(g, s, vt);
        }
        public void UpdateNode_First(int vt)
        {
            //g.FillRectangle(Brushes.White, 0, 0, 800, 800);
            int dem = vt;
            int dem3 = 0;
            int count = 0;
            string idx1 = "";
            foreach (Node tmp in a)
            {
                drawnode.VeNode(dem, g, p_bl);
                if (count != a.Count - 1)
                    drawNarrow.Draw_Narrow(g, dem, p_bl);
                if (a.Count == 1)
                {
                    drawcode.DrawAddr(g, "NULL", dem);
                    drawcode.Draw_NodeName("HEAD/TAIL", g, dem);
                    drawcode.DrawValue(g, tmp.value.ToString(), dem);

                }
                else if (a.Count == 2)
                {
                    if (dem3 == 0)
                    {
                        drawcode.Draw_NodeName("HEAD", g, dem);
                        drawcode.DrawValue(g, tmp.value.ToString(), dem);
                        drawcode.DrawAddr(g, "TAIL", dem);

                    }
                    if (dem3 == 1)
                    {
                        drawcode.Draw_NodeName("TAIL", g, dem);
                        drawcode.DrawValue(g, tmp.value.ToString(), dem);
                        drawcode.DrawAddr(g, "NULL", dem);
                    }

                }
                else if(a.Count==3)
                {
                    if (dem3 == 0)
                    {
                        drawcode.Draw_NodeName("HEAD", g, dem);
                        drawcode.DrawValue(g, tmp.value.ToString(), dem);
                        drawcode.DrawAddr(g, tmp.addr.ToString(), dem);
                        idx1 = tmp.addr.ToString();
                    }
                    if (dem3 == 1)
                    {
                        drawcode.Draw_NodeName(idx1, g, dem);
                        drawcode.DrawValue(g, tmp.value.ToString(), dem);
                        drawcode.DrawAddr(g, "TAIL", dem);
                    }
                    if(dem3==2)
                    {
                        drawcode.Draw_NodeName("TAIL", g, dem);
                        drawcode.DrawValue(g, tmp.value.ToString(), dem);
                        drawcode.DrawAddr(g, "NULL", dem);
                    }
                }
                else
                {

                    int dem2 = 0;
                    int vitri = 1;
                    foreach (Node k in a)
                    {
                        if (dem2 == 0)
                        {
                            drawcode.Draw_NodeName("HEAD", g, vitri);
                            drawcode.DrawValue(g, k.value.ToString(), vitri);
                            drawcode.DrawAddr(g, k.addr.ToString(), vitri);
                        }
                        if (dem2 == dem3 + 1 && dem2 != a.Count - 2 && dem2 != a.Count - 1)
                        {
                            drawcode.Draw_NodeName(tmp.addr.ToString(), g, vitri);
                            drawcode.DrawValue(g, k.value.ToString(), vitri);
                            drawcode.DrawAddr(g, k.addr.ToString(), vitri);
                        }
                        if (dem2 == a.Count - 2 && dem2 == dem + 1)
                        {
                            drawcode.Draw_NodeName(tmp.addr.ToString(), g, vitri);
                            drawcode.DrawValue(g, k.value.ToString(), vitri);
                            drawcode.DrawAddr(g, "TAIL", vitri);
                        }
                        if (dem2 == a.Count - 1 && dem2 != dem + 1)
                        {
                            drawcode.Draw_NodeName("TAIL", g, vitri);
                            drawcode.DrawValue(g, k.value.ToString(), vitri);
                            drawcode.DrawAddr(g, "NULL", vitri);
                        }
                        dem2++;
                        vitri++;
                    }
                }
                dem++;
                dem3++;
                count++;
            }
        }
        public void UpdateNode(int vt)
        {
            //g.FillRectangle(Brushes.White, 0, 0, 800, 800);
            int dem = vt;
            int dem3 = 0;
            int count = 0;
            foreach(Node tmp in a)
            {
                drawnode.VeNode(dem, g, p_bl);
                if (count != a.Count - 1)
                    drawNarrow.Draw_Narrow(g, dem, p_bl);
               /* else if(count != a.Count - 2&&a.Count>3)
                {
                    drawNarrow.Draw_Narrow(g, dem, p_bl);
                }*/
                if (a.Count == 1) {
                    drawcode.DrawAddr(g,"NULL",dem);
                    drawcode.Draw_NodeName("HEAD/TAIL", g, dem);
                    drawcode.DrawValue(g, tmp.value.ToString(), dem);

                }
                else if(a.Count==2)
                {
                    if(dem3==0)
                    {
                        drawcode.Draw_NodeName("HEAD", g, dem);
                        drawcode.DrawValue(g, tmp.value.ToString(), dem);
                        drawcode.DrawAddr(g, "TAIL", dem);

                    }
                    if(dem3==1)
                    {
                        drawcode.Draw_NodeName("TAIL", g, dem);
                        drawcode.DrawValue(g, tmp.value.ToString(), dem);
                        drawcode.DrawAddr(g, "NULL", dem);
                    }
                    
                }
                else
                {
                    
                    int dem2 = 0;
                    foreach(Node k in a)
                    {
                        if(dem2==0)
                        {
                            drawcode.Draw_NodeName("HEAD", g, dem2);
                            drawcode.DrawValue(g, k.value.ToString(), dem2);
                            drawcode.DrawAddr(g, k.addr.ToString(), dem2);
                        }
                        if(dem2==dem3+1&&dem2!=a.Count-2&&dem2!=a.Count-1)
                        {
                            drawcode.Draw_NodeName(tmp.addr.ToString(), g, dem2);
                            drawcode.DrawValue(g, k.value.ToString(), dem2);
                            drawcode.DrawAddr(g, k.addr.ToString(), dem2);
                        }
                        if(dem2==a.Count-2&&dem2==dem+1)
                        {
                            drawcode.Draw_NodeName(tmp.addr.ToString(), g, dem2);
                            drawcode.DrawValue(g, k.value.ToString(), dem2);
                            drawcode.DrawAddr(g, "TAIL", dem2);
                        }
                        if(dem2==a.Count-1&&dem2!=dem+1)
                        {
                            drawcode.Draw_NodeName("TAIL", g, dem2);
                            drawcode.DrawValue(g, k.value.ToString(), dem2);
                            drawcode.DrawAddr(g, "NULL", dem2);
                        }
                        dem2++;
                    }
                }
                dem++;
                dem3++;
                count++;
            }
        }
        public void AddRand_Check(Graphics g,ArrayList a,int pter)
        {
            g = this.CreateGraphics();
            int dem1= 0;
            foreach(Node k in a )
            {
                drawcode.Drawstring_AddAT(g,21);
                Thread.Sleep(500);
                g.FillRectangle(Brushes.White, 0, 0, 800, 800);

                Point pt = new Point(dem1 * 150, 200);
                UpdateNode(0);
               
                drawnode.Check_Node_Drawing(dem1, g);
                if (dem1 == pter)
                    break;
                dem1++;
                Thread.Sleep(1000);
            }
   
        }
        void Search_VT(Graphics g,ArrayList a,int vt)
        {
            g = this.CreateGraphics();
            int dem1 = 0;
            foreach (Node k in a)
            {
                
               // g.FillRectangle(Brushes.White, 0, 0, 800, 800);

                Point pt = new Point(dem1 * 150, 200);
                UpdateNode(0);
                Application.DoEvents();

                drawnode.Check_Node_Drawing(dem1, g);
                if (dem1 == vt)
                    break;
                dem1++;
                Thread.Sleep(1000);
            }
        }
        public void veNode_Mid(Graphics g,int vt)
        {
            int dem = 0;
            Node rev = new Node();
            drawcode.Drawstring_AddAT(g,22);
            Thread.Sleep(500);
           
           /* drawcode.Drawstring_AddAT(g,19);
            Thread.Sleep(500);
            drawcode.Drawstring_AddAT(g,20);
            Thread.Sleep(500);*/
            foreach (Node k in a)
            {

                drawcode.Drawstring_AddAT(g,21);
                Point pt = new Point(dem * 150 - 75, 300);
                if(dem==vt-1)
                    rev = k;
                if (dem==vt)
                {
                    g.DrawRectangle(p_blue, pt.X, pt.Y, 50, 50);
                    g.DrawRectangle(p_blue, pt.X+50, pt.Y, 50, 50);
                    g.DrawString(txbAddValue.Text, font, Brushes.Red, pt.X + 5, pt.Y + 5);
                    g.DrawString("NULL", font, Brushes.DarkGray, pt.X + 55, pt.Y + 5);
                   
                    drawLineNarr(g,dem);
                    g.FillRectangle(Brushes.White, pt.X + 51, pt.Y + 1, 48, 48);
                    g.DrawString(rev.addr.ToString(), font, Brushes.DarkGray, pt.X + 55, pt.Y + 5);
                    break;
                }
                dem++;
            }
        }
        public void drawLineNarr(Graphics g,int dem)
        {
            Point pt1 = new Point((dem-1) * 150 + 75, 250);
            Point pt2 = new Point((dem-1) * 150 + 100, 300);
            Point pt3 = new Point(dem*150, 300);
            Point pt4 = new Point(dem * 150 + 25, 250);
            p_bl.StartCap = LineCap.Square;
            p_bl.EndCap = LineCap.ArrowAnchor;
            drawcode.Drawstring_AddAT(g, 24);
            g.DrawLine(p_bl, pt3, pt4);
            Thread.Sleep(1000);
            
           
            drawcode.Drawstring_AddAT(g, 25);
            
            g.FillRectangle(Brushes.White, (dem - 1) * 150 + 102, 200, 47, 48);
            Thread.Sleep(1000);
            g.DrawLine(p_bl, pt1, pt2);
        }
        public void Searching(Graphics g,ArrayList a,int vitri)
        {
            g = this.CreateGraphics();
            int dem1 = 0;
            foreach (Node k in a)
            {
                
               
                drawcode.Drawstring_DelIDX(g, 47);
                Thread.Sleep(500);
                drawcode.Drawstring_DelIDX(g, 48);
                Thread.Sleep(500);
                drawcode.Drawstring_DelIDX(g, 49);
                Thread.Sleep(500);
                g.FillRectangle(Brushes.White, 0, 0, 800, 800);
                Point pt = new Point(dem1 * 150, 200);
                UpdateNode(0);
                Application.DoEvents();

                drawnode.Check_Node_Drawing(dem1, g);
                if (dem1+1 == vitri)
                    break;
                dem1++;
                Thread.Sleep(500);
            }
        }
        void btnsearch(Graphics g, ArrayList a,int giatri)
        {
            g = this.CreateGraphics();
            g.FillRectangle(Brushes.White, 800, 0, 800, 800);
            int dem1 = 0;
            foreach (Node k in a)
            {
                drawcode.Drawstring_Search(g, 56);
                Thread.Sleep(1000);
                drawcode.Drawstring_Search(g, 57);
                Thread.Sleep(1000);


                g.FillRectangle(Brushes.White, 0, 0, 800, 800);
                Point pt = new Point(dem1 * 150, 200);
                UpdateNode(0);

                drawnode.Check_Node_Drawing(dem1, g);
                if (k.value == giatri)
                {
                    drawcode.Drawstring_Search(g, 58);
                    Thread.Sleep(1000);
                    break;
                }
                else if(k.value!=giatri&&dem1==a.Count-1)
                {
                    drawcode.Drawstring_Search(g, 60);
                    Thread.Sleep(1000);
                }
                drawcode.Drawstring_Search(g, 59);
                Thread.Sleep(1000);
                dem1++;
                Thread.Sleep(500);
            }

            
        }
    }
}
