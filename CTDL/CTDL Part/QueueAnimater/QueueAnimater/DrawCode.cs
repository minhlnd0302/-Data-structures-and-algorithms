using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace QueueAnimater
{
    class DrawCode
    {
        string s1 = "Node *CreateNode(int key) {";
        string s2 = "     Node *tmp;";
        string s3 = "     tmp->item=key;";
        string s4 = "     tmp->p_Next=NULL;";
        string s5 = "     return tmp; }" ;

        string s6 = "void EnQueue(Queue &q,int key) {";
        string s7 = "     Node *p=new Node(key);";
        string s8 = "     if(q.front==NULL) {";
        string s9 = "         q.front = q.rear = p ;";
        string s10 = "    else {";
        string s11 = "        q.rear->p_Next = p;";
        string s12 = "        q.rear = p; }";

        string s13 = "Node *DeQueue(Queue &q) {";
        string s14 = "    if(q.front != NULL) {";
        string s15 = "        Node *p = q.front;";
        string s16 = "        q.front = p->p_Next ;";
        string s18 = "        return p; } }";

        string s19 = "Node *Front(Queue q) {";
        string s20 = "    if(q.front!=NULL) {";
        string s21 = "        return q.front; }";
        string s22 = "    return NULL; }";
        Font font = new Font("Consolas", 12, FontStyle.Bold);
        Font font2 = new Font("Consolas", 12, FontStyle.Bold);
        public void EnQu(int vt,Graphics g)
        {
            for(int i=1;i<=12;i++)
            {
                switch(i)
                {
                    case 1:
                        g.DrawString(s1, font, Brushes.Yellow, 450, 200);
                        break;
                    case 2:
                        g.DrawString(s2, font, Brushes.Yellow, 450, 220);
                        break;
                    case 3:
                        g.DrawString(s3, font, Brushes.Yellow, 450, 240);
                        break;
                    case 4:
                        g.DrawString(s4, font, Brushes.Yellow, 450, 260);
                        break;
                    case 5:
                        g.DrawString(s5, font, Brushes.Yellow, 450, 280);
                        break;
                    case 6:
                        g.DrawString(s6, font, Brushes.Yellow, 450, 300);
                        break;
                    case 7:
                        g.DrawString(s7, font, Brushes.Yellow, 450, 320);
                        break;
                    case 8:
                        g.DrawString(s8, font, Brushes.Yellow, 450, 340);
                        break;
                    case 9:
                        g.DrawString(s9, font, Brushes.Yellow, 450, 360);
                        break;
                    case 10:
                        g.DrawString(s10, font, Brushes.Yellow, 450, 380);
                        break;
                    case 11:
                        g.DrawString(s11, font, Brushes.Yellow, 450, 400);
                        break;
                    case 12:
                        g.DrawString(s12, font, Brushes.Yellow, 450, 420);
                        break;


                }
                switch (vt)
                {

                    case 1:
                        g.DrawString(s1, font, Brushes.Blue, 450, 200);
                        break;
                    case 2:
                        g.DrawString(s2, font, Brushes.Blue, 450, 220);
                        break;
                    case 3:
                        g.DrawString(s3, font, Brushes.Blue, 450, 240);
                        break;
                    case 4:
                        g.DrawString(s4, font, Brushes.Blue, 450, 260);
                        break;
                    case 5:
                        g.DrawString(s5, font, Brushes.Blue, 450, 280);
                        break;
                    case 6:
                        g.DrawString(s6, font, Brushes.Blue, 450, 300);
                        break;
                    case 7:
                        g.DrawString(s7, font, Brushes.Blue, 450, 320);
                        break;
                    case 8:
                        g.DrawString(s8, font, Brushes.Blue, 450, 340);
                        break;
                    case 9:
                        g.DrawString(s9, font, Brushes.Blue, 450, 360);
                        break;
                    case 10:
                        g.DrawString(s10, font, Brushes.Blue, 450, 380);
                        break;
                    case 11:
                        g.DrawString(s11, font, Brushes.Blue, 450, 400);
                        break;
                    case 12:
                        g.DrawString(s12, font, Brushes.Blue, 450, 420);
                        break;
                }
            }
        }
        public void DeQu(int vt,Graphics g)
        {
            for(int i=13;i<=18;i++)
            {
                switch(i)
                {
                    
                    case 13:
                        g.DrawString(s13, font, Brushes.Yellow, 450, 300);
                        break;
                    case 14:
                        g.DrawString(s14, font, Brushes.Yellow, 450, 320);
                        break;
                    case 15:
                        g.DrawString(s15, font, Brushes.Yellow, 450, 340);
                        break;
                    case 16:
                        g.DrawString(s16, font, Brushes.Yellow, 450, 360);
                        break;
                    
                    case 18:
                        g.DrawString(s18, font, Brushes.Yellow, 450, 400);
                        break;
                    
                }
                switch (vt)
                {
                    
                    case 13:
                        g.DrawString(s13, font, Brushes.Blue, 450, 300);
                        break;
                    case 14:
                        g.DrawString(s14, font, Brushes.Blue, 450, 320);
                        break;
                    case 15:
                        g.DrawString(s15, font, Brushes.Blue, 450, 340);
                        break;
                    case 16:
                        g.DrawString(s16, font, Brushes.Blue, 450, 360);
                        break;
                   
                    case 18:
                        g.DrawString(s18, font, Brushes.Blue, 450, 400);
                        break;

                }
            }
        }
        public void Frnt(int vt, Graphics g)
        {
            for(int i=19;i<=22;i++)
            {
                switch(i)
                {
                    case 19:
                        g.DrawString(s19, font, Brushes.Yellow, 450, 300);
                        break;
                    case 20:
                        g.DrawString(s20, font, Brushes.Yellow, 450, 320);
                        break;
                    case 21:
                        g.DrawString(s21, font, Brushes.Yellow, 450, 340);
                        break;
                    case 22:
                        g.DrawString(s22, font, Brushes.Yellow, 450, 360);
                        break;

                }
                switch (vt)
                {
                    case 19:
                        g.DrawString(s19, font, Brushes.Blue, 450, 300);
                        break;
                    case 20:
                        g.DrawString(s20, font, Brushes.Blue, 450, 320);
                        break;
                    case 21:
                        g.DrawString(s21, font, Brushes.Blue, 450, 340);
                        break;
                    case 22:
                        g.DrawString(s22, font, Brushes.Blue, 450, 360);
                        break;

                }
            }
        }
       
    }
}
