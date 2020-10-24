using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StackAnimate
{
    class DrawCode
    {
        Font font = new Font("Consolas", 12,FontStyle.Bold);
        Font font2 = new Font("Consolas", 12, FontStyle.Bold);

      /*  string s1 = "struct Node {";
        string s2 = "     int item;";
        string s3 = "     struct Node *p_Next; }";

        string s4 = "struct Stack {";
        string s5 = "     Node *p_Top }";*/

        string s6 = "Node *CreateNode(int val) {";
        string s7 = "     Node *tmp=new Node ;";
        string s8 = "     tmp->Item = val;";
        string s9 = "     tmp->p_Next=NULL;";
        string s10 = "    return tmp; }";

        string s11 = "void CreateStack(Stack &s) {";
        string s12 = "    s.p_Top=NULL; }";

        string s13 = "void Push(Stack &s,int val) {";
        string s14 = "    if(s.p_Top == NULL) {";
        string s15 = "      Node *p=CreateNode(val);";
        string s16 = "      s.p_Top=p; }";
        string s17 = "    else {";
        string s18 = "      Node *p=CreateNode(val);";
        string s19 = "      p->p_Next=s.p_Top;";
        string s20 = "      s.p_Top=p; }";

        string s21 = "int Pop(Stack &s) {";
        string s22 = "    if(s.p_Top==NULL)";
        string s23 = "      return NULL;";
        
        
        string s26 = "    int Item=s.p_Top.Item;";
        string s27 = "    s.p_Top=p_Top.p_Next;";
        
        string s29 = "    return Item; }";

        string s30 = "int Top(Stack s) {";
        string s31 = "    if(s.Top==NULL)";
        string s32 = "      return NULL;";
        string s33 = "    else";
        string s34 = "      return s.Top->Item; }";
        
        public void DrawStr(int vt,Graphics g)
        {
            
            for (int i = 6; i <= 20; i++)
            {
                switch (i)
                {
                   
                    case 6:
                        g.DrawString(s6, font, Brushes.GreenYellow, 450, 120);
                        break;
                    case 7:
                        g.DrawString(s7, font, Brushes.GreenYellow, 450, 140);
                        break;
                    case 8:
                        g.DrawString(s8, font, Brushes.GreenYellow, 450, 160);
                        break;
                    case 9:
                        g.DrawString(s9, font, Brushes.GreenYellow, 450, 180);
                        break;
                    case 10:
                        g.DrawString(s10, font, Brushes.GreenYellow, 450, 200);
                        break;
                    case 11:
                        g.DrawString(s11, font, Brushes.GreenYellow, 450, 220);
                        break;
                    case 12:
                        g.DrawString(s12, font, Brushes.GreenYellow, 450, 240);
                        break;
                    case 13:
                        g.DrawString(s13, font, Brushes.GreenYellow, 450, 260);
                        break;
                    case 14:
                        g.DrawString(s14, font, Brushes.GreenYellow, 450, 280);
                        break;
                    case 15:
                        g.DrawString(s15, font, Brushes.GreenYellow, 450, 300);
                        break;
                    case 16:
                        g.DrawString(s16, font, Brushes.GreenYellow, 450, 320);
                        break;
                    case 17:
                        g.DrawString(s17, font, Brushes.GreenYellow, 450, 340);
                        break;
                    case 18:
                        g.DrawString(s18, font, Brushes.GreenYellow, 450, 360);
                        break;
                    case 19:
                        g.DrawString(s19, font, Brushes.GreenYellow, 450, 380);
                        break;
                    case 20:
                        g.DrawString(s20, font, Brushes.GreenYellow, 450, 400);
                        break;
                       
                }
            }
            //g.FillRectangle(Brushes.SlateBlue, 450, 0, 1000, 1000);
            
                switch (vt)
                {
                    case 6:
                        g.DrawString(s6, font2, Brushes.Red, 450, 120);
                        break;
                    case 7:
                        g.DrawString(s7, font2, Brushes.Red, 450, 140);
                        break;
                    case 8:
                        g.DrawString(s8, font2, Brushes.Red, 450, 160);
                        break;
                    case 9:
                        g.DrawString(s9, font2, Brushes.Red, 450, 180);
                        break;
                    case 10:
                        g.DrawString(s10, font2, Brushes.Red, 450, 200);
                        break;
                    case 11:
                        g.DrawString(s11, font2, Brushes.Red, 450, 220);
                        break;
                    case 12:
                        g.DrawString(s12, font2, Brushes.Red, 450, 240);
                        break;
                    case 13:
                        g.DrawString(s13, font2, Brushes.Red, 450, 260);
                        break;
                    case 14:
                        g.DrawString(s14, font2, Brushes.Red, 450, 280);
                        break;
                    case 15:
                        g.DrawString(s15, font2, Brushes.Red, 450, 300);
                        break;
                    case 16:
                        g.DrawString(s16, font2, Brushes.Red, 450, 320);
                        break;
                    case 17:
                        g.DrawString(s17, font2, Brushes.Red, 450, 340);
                        break;
                    case 18:
                        g.DrawString(s18, font2, Brushes.Red, 450, 360);
                        break;
                    case 19:
                        g.DrawString(s19, font2, Brushes.Red, 450, 380);
                        break;
                    case 20:
                        g.DrawString(s20, font2, Brushes.Red, 450, 400);
                        break;
                }

            
        }
        public void DrawTop(int vt,Graphics g)
        {
           // g.FillRectangle(Brushes.SlateBlue, 450, 0, 1000, 1000);
            for (int i = 30; i <= 34; i++)
            {
                switch (i)
                {
                    case 30:
                        g.DrawString(s30, font, Brushes.GreenYellow, 450, 280);
                        break;
                    case 31:
                        g.DrawString(s31, font, Brushes.GreenYellow, 450, 300);
                        break;
                    case 32:
                        g.DrawString(s32, font, Brushes.GreenYellow, 450, 320);
                        break;
                    case 33:
                        g.DrawString(s33, font, Brushes.GreenYellow, 450, 340);
                        break;
                    case 34:
                        g.DrawString(s34, font, Brushes.GreenYellow, 450, 360);
                        break;
                }
            }
            
                switch(vt)
                {
                    case 30:
                        g.DrawString(s30, font2, Brushes.Red, 450, 280);
                        break;
                    case 31:
                        g.DrawString(s31, font2, Brushes.Red, 450, 300);
                        break;
                    case 32:
                        g.DrawString(s32, font2, Brushes.Red, 450, 320);
                        break;
                    case 33:
                        g.DrawString(s33, font2, Brushes.Red, 450, 340);
                        break;
                    case 34:
                        g.DrawString(s34, font2, Brushes.Red, 450, 360);
                        break;
                }
            
        }
        public void DrawPop(int vt,Graphics g)
        {
           // g.FillRectangle(Brushes.SlateBlue, 450, 0, 1000, 1000);
            for (int i=21;i<=29;i++)
            {
                switch(i)
                {
                    case 21:
                        g.DrawString(s21, font, Brushes.GreenYellow, 450, 280);
                        break;
                    case 22:
                        g.DrawString(s22, font, Brushes.GreenYellow, 450, 300);
                        break;
                    case 23:
                        g.DrawString(s23, font, Brushes.GreenYellow, 450, 320);
                        break;
                   
                    case 26:
                        g.DrawString(s26, font, Brushes.GreenYellow, 450, 340);
                        break;
                    case 27:
                        g.DrawString(s27, font, Brushes.GreenYellow, 450, 360);
                        break;
                   
                    case 29:
                        g.DrawString(s29, font, Brushes.GreenYellow, 450, 380);
                        break;
                   
                }
            }
            switch(vt)
            {
                case 21:
                    g.DrawString(s21, font2, Brushes.Red, 450, 280);
                    break;
                case 22:
                    g.DrawString(s22, font2, Brushes.Red, 450, 300);
                    break;
                case 23:
                    g.DrawString(s23, font2, Brushes.Red, 450, 320);
                    break;
               
                case 26:
                    g.DrawString(s26, font2, Brushes.Red, 450, 340);
                    break;
                case 27:
                    g.DrawString(s27, font2, Brushes.Red, 450, 360);
                    break;
                
                case 29:
                    g.DrawString(s29, font2, Brushes.Red, 450, 380);
                    break;
            }
        }
    }
}
