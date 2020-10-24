using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;
using System.Threading;


namespace LinkedListViewer
{
    class DrawCode
    {
        #region KhoiTaoString
        string a1 = "struct Node{\n" +
                    "     int x;\n" +
                    "     struct Node* p_next;};";
        string a2 = "struct List{\n"
                   + "     Node *head;\n" +
                    "     Node *tail;}";
        string a3 = "void CreateList(List &l) {\n" +
                    "   l.head = NULL;\n" +
                    "   l.tail = NULL;}";
        string a4 = "Node* CreateNode(int value){\n" +
                    "     Node* p = new Node;\n" +
                    "     if (p == NULL) { return NULL; }\n" +
                    "     p->x = value;\n" +
                    "     p->pNext = NULL;\n" +
                    "     return p; }"
;
        string a5 = "void AddToHead(List& l,Node *p) {\n";

        string a6 = "   if (l.head == NULL)";
        string a7 = "       {	l.tail = l.head = x;	}";
        string a8 = "   else { x->pNext = l.tail;";
        string a9 = "          l.head = x;  }";
        string a10 = "void AddToTail(List& l, Node* p){";
        string a11 = "   if (l.tail == NULL)";
        string a12 = "      {	l.tail = l.head = x;	}";
        string a13 = "  else{ l.tail->pNext = p;";
        string a14 = "l.tail = p;	}   }";
        string a15 = "void AddAt(List& l,Node* p,int k) {";
        string a16 = "    if(k==0||l.head==null){";
        string a17 = "        AddToHead(l,p); }";
        string a18 = "    else {";
        string a19 = "        int count=1; Node *res = l.head;";
        string a20 = "        While(res != null && count != k) { ";
        string a21 = "            count++; res=res->pNext; }";
        string a22 = "        if(count!=k) {";
        string a23 = "            AddToTail(l,res); }";
        string a24 = "        else { p->pNext = res->pNext;";
        string a25 = "               res->pNext =p ; } } }";

        string a26 = "void DelHead(List &l) {";
        string a27 = "    Node *p;";
        string a28 = "    if(l.head!=NULL) {";
        string a29 = "        p=l.head;";
        string a30 = "        l.head=l.head->pNext; }";
        string a31 = "    delete p; }";
        string a32 = "void Del_Tail(List &l) {";
        string a33 = "    if(l.head==l.tail) {";
        string a34 = "        DelHead(l); } ";
        string a35 = "    else { Node *p=l.head;";
        string a36 = "    While(p->pNext->pNext!=NULL)";
        string a37 = "        p=p->pNext";
        string a38 = "    p->pNext=NULL;";
        string a39 = "    l.tail=p;";
        string a40 = "    delete p; } }";
        string a41 = "void Del_At(List &l, int vitri) {";
        string a42 = "    if(vitri==0) {";
        string a43 = "        Del_Head; ";
        string a44 = "    } else {";
        string a45 = "        int k=1;";
        string a46 = "        Node *p=l.head;";
        string a47 = "        While(p->pNext->pNext!=NULL&&k!=vitri) {";
        string a48 = "            p=p->pNext;";
        string a49 = "            k++; }";
        string a50 = "        if(k!=vitri) {";
        string a51 = "            Del_Tail(l);";
        string a52 = "        } else {";
        string a53 = "            p-pNext=p->pNext->pNext; } } }";
        string a54 = "int Search(List l,int value) {";
        string a55 = "    int vitri=0;";
        string a56 = "    for(Node *p=l.head;p!=NULL;p=p->pNext) {";
        string a57 = "        if(p->data==value)";
        string a58 = "           return vitri; }";
        string a59 = "        vitri++;";
        string a60 = "    return -1; }";
        #endregion
        Font font = new Font("Times New Roman", 13, FontStyle.Bold);
        Font conso = new Font("Consolas", 13, FontStyle.Bold);
        Pen pt = new Pen(Color.Black, 10);
        DrawNode drawNd = new DrawNode();

        public void DrawValue(Graphics g, string a, int vt)
        {
            Point pt = new Point(vt * 150 + 10, 210);

            g.DrawString(a, font, Brushes.Black, pt);

        }
        public void DrawAddr(Graphics g, string a, int vt)
        {
            Point pt = new Point(vt * 150 + 50, 210);

            g.DrawString(a, font, Brushes.Red, pt);
        }
        public void Draw_NodeName(string a, Graphics g, int vt)
        {
            //int dem1 = 0;

            Point pt = new Point(vt * 150 + 20, 160);
            g.DrawString(a, font, Brushes.Blue, pt);

        }
        public void drawString(int vt, Graphics g)
        {
            Font k = new Font("Consolas", 12, FontStyle.Bold);
            for (int i = 1; i <= 14; i++)
            {
                if (i == 1)
                    g.DrawString(a1, k, Brushes.Black, 800, 20);
                if (i == 2)
                    g.DrawString(a2, k, Brushes.Black, 800, 80);
                if (i == 3)
                    g.DrawString(a3, k, Brushes.Black, 800, 140);
                if (i == 4)
                    g.DrawString(a4, k, Brushes.Black, 800, 200);
                if (i == 5)
                    g.DrawString(a5, k, Brushes.Black, 800, 320);
                if (i == 6)
                    g.DrawString(a6, k, Brushes.Black, 800, 340);
                if (i == 7)
                    g.DrawString(a7, k, Brushes.Black, 800, 360);
                if (i == 8)
                    g.DrawString(a8, k, Brushes.Black, 800, 380);
                if (i == 9)
                    g.DrawString(a9, k, Brushes.Black, 800, 400);
                if (i == 10)
                    g.DrawString(a10, k, Brushes.Black, 800, 420);
                if (i == 11)
                    g.DrawString(a11, k, Brushes.Black, 800, 440);
                if (i == 12)
                    g.DrawString(a12, k, Brushes.Black, 800, 460);
                if (i == 13)
                    g.DrawString(a13, k, Brushes.Black, 800, 480);
                if (i == 14)
                    g.DrawString(a14, k, Brushes.Black, 800, 500);
                switch (vt)
                {
                    case 1:
                        g.DrawString(a1, k, Brushes.Red, 800, 20);
                        break;
                    case 2:
                        g.DrawString(a2, k, Brushes.Red, 800, 80);
                        break;
                    case 3:
                        g.DrawString(a3, k, Brushes.Red, 800, 140);
                        break;
                    case 4:
                        g.DrawString(a4, k, Brushes.Red, 800, 200);
                        break;
                    case 5:
                        g.DrawString(a5, k, Brushes.Red, 800, 320);
                        break;
                    case 6:
                        g.DrawString(a6, k, Brushes.Red, 800, 340);
                        break;
                    case 7:
                        g.DrawString(a7, k, Brushes.Red, 800, 360);
                        break;
                    case 8:
                        g.DrawString(a8, k, Brushes.Red, 800, 380);
                        break;
                    case 9:
                        g.DrawString(a9, k, Brushes.Red, 800, 400);
                        break;
                    case 10:
                        g.DrawString(a10, k, Brushes.Red, 800, 420);
                        break;
                    case 11:
                        g.DrawString(a11, k, Brushes.Red, 800, 440);
                        break;
                    case 12:
                        g.DrawString(a12, k, Brushes.Red, 800, 460);
                        break;
                    case 13:
                        g.DrawString(a13, k, Brushes.Red, 800, 480);
                        break;
                    case 14:
                        g.DrawString(a14, k, Brushes.Red, 800, 500);
                        break;

                }

            }
            Thread.Sleep(200);
        }
        public void DrawnodenameALL(ArrayList a, Graphics g, int sl)
        {
            int dem1 = sl;

            string tmp = "Head";
            foreach (Node k in a)
            {
                Point pt = new Point(dem1 * 150 + 20, 160);
                int dem2 = 0;
                if (a.Count == 1)
                {
                    g.DrawString("Head/Tail", font, Brushes.Red, pt);
                }
                else if (dem1 == a.Count - 1)
                {
                    g.DrawString("Tail", font, Brushes.Red, pt);
                }
                else if (dem1 == 0)
                {
                    g.DrawString("Head", font, Brushes.Red, pt);
                }
                else
                {
                    foreach (Node m in a)
                    {
                        if (dem2 == dem1 - 1)
                        {
                            tmp = m.addr.ToString();
                            break;
                        }
                        dem2++;
                    }
                    g.DrawString(tmp, font, Brushes.Red, pt);
                }
                dem1++;

            }

        }
        public void UpdateAll(Graphics g, ArrayList a)
        {
            int dem = 0;
            foreach (Node p in a)
            {
                drawNd.fill_Addr(g, dem);
                drawNd.fill_val(g, dem);
                DrawValue(g, p.value.ToString(), dem);

                if (dem == a.Count)
                {
                    DrawAddr(g, "NULL", dem);
                }
                else if (dem == 0 && a.Count == 1)
                {
                    DrawAddr(g, "TAIL", dem);
                }
                else
                {
                    DrawAddr(g, p.addr.ToString(), dem);
                }
                dem++;

            }
        }
        public void Drawstring_AddAT(Graphics g, int vt)
        {
            Font k = new Font("Consolas", 12, FontStyle.Bold);
            for (int i = 4; i <= 25; i++)
            {
                if (i == 4)
                    g.DrawString(a4, k, Brushes.Black, 800, 20);
                if (i == 5)
                    g.DrawString(a5, k, Brushes.Black, 800, 140);
                if (i == 6)
                    g.DrawString(a6, k, Brushes.Black, 800, 160);
                if (i == 7)
                    g.DrawString(a7, k, Brushes.Black, 800, 180);
                if (i == 8)
                    g.DrawString(a8, k, Brushes.Black, 800, 200);
                if (i == 9)
                    g.DrawString(a9, k, Brushes.Black, 800, 220);
                if (i == 10)
                    g.DrawString(a10, k, Brushes.Black, 800, 240);
                if (i == 11)
                    g.DrawString(a11, k, Brushes.Black, 800, 260);
                if (i == 12)
                    g.DrawString(a12, k, Brushes.Black, 800, 280);
                if (i == 13)
                    g.DrawString(a13, k, Brushes.Black, 800, 300);
                if (i == 14)
                    g.DrawString(a14, k, Brushes.Black, 800, 320);
                if (i == 15)
                    g.DrawString(a15, k, Brushes.Black, 800, 340);
                if (i == 16)
                    g.DrawString(a16, k, Brushes.Black, 800, 360);
                if (i == 17)
                    g.DrawString(a17, k, Brushes.Black, 800, 380);
                if (i == 18)
                    g.DrawString(a18, k, Brushes.Black, 800, 400);
                if (i == 19)
                    g.DrawString(a19, k, Brushes.Black, 800, 420);
                if (i == 20)
                    g.DrawString(a20, k, Brushes.Black, 800,440);
                if (i == 21)
                    g.DrawString(a21, k, Brushes.Black, 800, 460);
                if (i == 22)
                    g.DrawString(a22, k, Brushes.Black, 800, 480);
                if (i == 23)
                    g.DrawString(a23, k, Brushes.Black, 800, 500);
                if (i == 24)
                    g.DrawString(a24, k, Brushes.Black, 800, 520);
                if (i == 25)
                    g.DrawString(a25, k, Brushes.Black, 800, 540);
                switch (vt)
                {
                    case 4:
                        g.DrawString(a4, k, Brushes.Red, 800, 20);
                        break;
                    case 5:
                        g.DrawString(a5, k, Brushes.Red, 800, 140);
                        break;
                    case 6:
                        g.DrawString(a6, k, Brushes.Red, 800, 160);
                        break;
                    case 7:
                        g.DrawString(a7, k, Brushes.Red, 800, 180);
                        break;
                    case 8:
                        g.DrawString(a8, k, Brushes.Red, 800, 200);
                        break;
                    case 9:
                        g.DrawString(a9, k, Brushes.Red, 800, 220);
                        break;
                    case 10:
                        g.DrawString(a10, k, Brushes.Red, 800, 240);
                        break;
                    case 11:
                        g.DrawString(a11, k, Brushes.Red, 800, 260);
                        break;
                    case 12:
                        g.DrawString(a12, k, Brushes.Red, 800, 280);
                        break;
                    case 13:
                        g.DrawString(a13, k, Brushes.Red, 800, 300);
                        break;
                    case 14:
                        g.DrawString(a14, k, Brushes.Red, 800, 320);
                        break;
                    case 15:
                        g.DrawString(a15, k, Brushes.Red, 800, 340);
                        break;
                    case 16:
                        g.DrawString(a16, k, Brushes.Red, 800, 360);
                        break;
                    case 17:
                        g.DrawString(a17, k, Brushes.Red, 800, 380);
                        break;
                    case 18:
                        g.DrawString(a18, k, Brushes.Red, 800, 400);
                        break;
                    case 19:
                        g.DrawString(a19, k, Brushes.Red, 800, 420);
                        break;
                    case 20:
                        g.DrawString(a20, k, Brushes.Red, 800, 440);
                        break;
                    case 21:
                        g.DrawString(a21, k, Brushes.Red, 800, 460);
                        break;
                    case 22:
                        g.DrawString(a22, k, Brushes.Red, 800, 480);
                        break;
                    case 23:
                        g.DrawString(a23, k, Brushes.Red, 800, 500);
                        break;
                    case 24:
                        g.DrawString(a24, k, Brushes.Red, 800, 520);
                        break;
                    case 25:
                        g.DrawString(a25, k, Brushes.Red, 800, 540);
                        break;

                }
            }
        }
        public void Drawstring_DelAt(Graphics g,int vt)
        {
            for(int i=25;i<=40;i++)
            {
                switch (i)
                {
                    case 25:
                        g.DrawString(a4, conso, Brushes.Black, 800, 20);
                        break;
                    case 26:
                        g.DrawString(a26, conso, Brushes.Black, 800, 140);
                        break;
                    case 27:
                        g.DrawString(a27, conso, Brushes.Black, 800, 160);
                        break;
                    case 28:
                        g.DrawString(a28, conso, Brushes.Black, 800, 180);
                        break;
                    case 29:
                        g.DrawString(a29, conso, Brushes.Black, 800, 200);
                        break;
                    case 30:
                        g.DrawString(a30, conso, Brushes.Black, 800, 220);
                        break;
                    case 31:
                        g.DrawString(a31, conso, Brushes.Black, 800, 240);
                        break;
                    case 32:
                        g.DrawString(a32, conso, Brushes.Black, 800, 260);
                        break;
                    case 33:
                        g.DrawString(a33, conso, Brushes.Black, 800, 280);
                        break;
                    case 34:
                        g.DrawString(a34, conso, Brushes.Black, 800, 300);
                        break;
                    case 35:
                        g.DrawString(a35, conso, Brushes.Black, 800, 320);
                        break;
                    case 36:
                        g.DrawString(a36, conso, Brushes.Black, 800, 340);
                        break;
                    case 37:
                        g.DrawString(a37, conso, Brushes.Black, 800, 360);
                        break;
                    case 38:
                        g.DrawString(a38, conso, Brushes.Black, 800, 380);
                        break;
                    case 39:
                        g.DrawString(a39, conso, Brushes.Black, 800, 400);
                        break;
                    case 40:
                        g.DrawString(a40, conso, Brushes.Black, 800, 420);
                        break;
                }
                switch (vt)
                {
                    case 25:
                        g.DrawString(a4, conso, Brushes.Red, 800, 20);
                        break;
                    case 26:
                        g.DrawString(a26, conso, Brushes.Red, 800, 140);
                        break;
                    case 27:
                        g.DrawString(a27, conso, Brushes.Red, 800, 160);
                        break;
                    case 28:
                        g.DrawString(a28, conso, Brushes.Red, 800, 180);
                        break;
                    case 29:
                        g.DrawString(a29, conso, Brushes.Red, 800, 200);
                        break;
                    case 30:
                        g.DrawString(a30, conso, Brushes.Red, 800, 220);
                        break;
                    case 31:
                        g.DrawString(a31, conso, Brushes.Red, 800, 240);
                        break;
                    case 32:
                        g.DrawString(a32, conso, Brushes.Red, 800, 260);
                        break;
                    case 33:
                        g.DrawString(a33, conso, Brushes.Red, 800, 280);
                        break;
                    case 34:
                        g.DrawString(a34, conso, Brushes.Red, 800, 300);
                        break;
                    case 35:
                        g.DrawString(a35, conso, Brushes.Red, 800, 320);
                        break;
                    case 36:
                        g.DrawString(a36, conso, Brushes.Red, 800, 340);
                        break;
                    case 37:
                        g.DrawString(a37, conso, Brushes.Red, 800, 360);
                        break;
                    case 38:
                        g.DrawString(a38, conso, Brushes.Red, 800, 380);
                        break;
                    case 39:
                        g.DrawString(a39, conso, Brushes.Red, 800, 400);
                        break;
                    case 40:
                        g.DrawString(a40, conso, Brushes.Red, 800, 420);
                        break;
                }
            }
        }
        public void Drawstring_DelIDX(Graphics g,int vt)
        {
            for(int i=41; i<=53;i++)
            {
                switch(i)
                {
                    case 41:
                        g.DrawString(a41, conso, Brushes.Black, 800, 20);
                        break;
                    case 42:
                        g.DrawString(a42, conso, Brushes.Black, 800, 40);
                        break;
                    case 43:
                        g.DrawString(a43, conso, Brushes.Black, 800, 60);
                        break;
                    case 44:
                        g.DrawString(a44, conso, Brushes.Black, 800, 80);
                        break;
                    case 45:
                        g.DrawString(a45, conso, Brushes.Black, 800, 100);
                        break;
                    case 46:
                        g.DrawString(a46, conso, Brushes.Black, 800, 120);
                        break;
                    case 47:
                        g.DrawString(a47, conso, Brushes.Black, 800, 140);
                        break;
                    case 48:
                        g.DrawString(a48, conso, Brushes.Black, 800, 160);
                        break;
                    case 49:
                        g.DrawString(a49, conso, Brushes.Black, 800, 180);
                        break;
                    case 50:
                        g.DrawString(a50, conso, Brushes.Black, 800, 200);
                        break;
                    case 51:
                        g.DrawString(a51, conso, Brushes.Black, 800, 220);
                        break;
                    case 52:
                        g.DrawString(a52, conso, Brushes.Black, 800, 240);
                        break;
                    case 53:
                        g.DrawString(a53, conso, Brushes.Black, 800, 260);
                        break;


                }
                switch (vt)
                {
                    case 41:
                        g.DrawString(a41, conso, Brushes.Red, 800, 20);
                        break;
                    case 42:
                        g.DrawString(a42, conso, Brushes.Red, 800, 40);
                        break;
                    case 43:
                        g.DrawString(a43, conso, Brushes.Red, 800, 60);
                        break;
                    case 44:
                        g.DrawString(a44, conso, Brushes.Red, 800, 80);
                        break;
                    case 45:
                        g.DrawString(a45, conso, Brushes.Red, 800, 100);
                        break;
                    case 46:
                        g.DrawString(a46, conso, Brushes.Red, 800, 120);
                        break;
                    case 47:
                        g.DrawString(a47, conso, Brushes.Red, 800, 140);
                        break;
                    case 48:
                        g.DrawString(a48, conso, Brushes.Red, 800, 160);
                        break;
                    case 49:
                        g.DrawString(a49, conso, Brushes.Red, 800, 180);
                        break;
                    case 50:
                        g.DrawString(a50, conso, Brushes.Red, 800, 200);
                        break;
                    case 51:
                        g.DrawString(a51, conso, Brushes.Red, 800, 220);
                        break;
                    case 52:
                        g.DrawString(a52, conso, Brushes.Red, 800, 240);
                        break;
                    case 53:
                        g.DrawString(a53, conso, Brushes.Red, 800, 260);
                        break;


                }

            }
        }
        public void Drawstring_Search(Graphics g,int vt)
        {
            for(int i=54;i<=60;i++)
            {
                switch(i)
                {
                    case 54:
                        g.DrawString(a54, conso, Brushes.Black, 800, 100);
                        break;
                    case 55:
                        g.DrawString(a55, conso, Brushes.Black, 800, 120);
                        break;
                    case 56:
                        g.DrawString(a56, conso, Brushes.Black, 800, 140);
                        break;
                    case 57:
                        g.DrawString(a57, conso, Brushes.Black, 800, 160);
                        break;
                    case 58:
                        g.DrawString(a58, conso, Brushes.Black, 800, 180);
                        break;
                    case 59:
                        g.DrawString(a59, conso, Brushes.Black, 800, 200);
                        break;
                    case 60:
                        g.DrawString(a60, conso, Brushes.Black, 800, 220);
                        break;
                    
                }
                switch (vt)
                {
                    case 54:
                        g.DrawString(a54, conso, Brushes.Red, 800, 100);
                        break;
                    case 55:
                        g.DrawString(a55, conso, Brushes.Red, 800, 120);
                        break;
                    case 56:
                        g.DrawString(a56, conso, Brushes.Red, 800, 140);
                        break;
                    case 57:
                        g.DrawString(a57, conso, Brushes.Red, 800, 160);
                        break;
                    case 58:
                        g.DrawString(a58, conso, Brushes.Red, 800, 180);
                        break;
                    case 59:
                        g.DrawString(a59, conso, Brushes.Red, 800, 200);
                        break;
                    case 60:
                        g.DrawString(a60, conso, Brushes.Red, 800, 220);
                        break;

                }

            }
        }
    }
}
