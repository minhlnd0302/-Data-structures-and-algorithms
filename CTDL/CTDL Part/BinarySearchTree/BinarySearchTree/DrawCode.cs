using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BinarySearchTree
{
    class DrawCode
    {
        string[] s = new string[50];
        Pen p_black = new Pen(Color.Black, 10);
        Pen p_blue = new Pen(Color.Blue, 3);
        Pen p_orange = new Pen(Color.Orange, 3);
        Pen p_red = new Pen(Color.Red, 3);
        Pen p_white = new Pen(Color.White, 10);
        Pen p_yellow = new Pen(Color.Yellow, 3);
        Font font = new Font("Consolas", 15);
        Font font1 = new Font("Consolas", 13);
        public void setString()
        {
            s[0] = "  if(value < node.Key) {";
            s[1] = "else if(value > node.Key) {";
            s[2] = "    Insert(node.Left,value);";
            s[3] = "    Insert(node.Right,value);";
            s[4] = "    Find(node.Left, value); \n  }";
            s[5] = "    Find(node.Right, value); \n   }";
            s[6] = "  else {";
            s[7] = "    InOrderTravel(node.Left);";
            s[8] = "    InOrderTravle(node.Right) \n};";
            s[9] = "    PreOrderTravel(node.Left);";
            s[10] = "   PreOrderTravel(node.Right) \n};";
            s[11] = "   PosOrderTravel(node.Left);";
            s[12] = "   PosOrderTravel(node.Right);";
            s[13] = "   < Do something with this value! >";
            s[14] = "Delete this node";
            s[15] = "     if(node.Left == null) {";
            s[16] = "     else if(node.Right == NULL) {";
            s[17] = "else {";
            s[18] = "Find the replace node";
            s[19] = "BeDeletedNode.Key=ReplaceNode.Key";
            s[20] = "Delete(ReplaceNode)";
            s[21] = "Delete this node";
            s[22] = "InOrderTravel(Node node) {";
            s[23] = "PreOrderTravel(Node node) {";
            s[24] = "PosOrderTravel(Node node) {";
            s[25] = "    < Do something with this value! >\n}";
            s[26] = "Find(Node node,int value) {";
            s[27] = "InsertNode(Node node, int value) {";
            s[28] = "   If(node!=null) {";
            s[29] = "else {";
            s[30] = "   node = CreateNode(value); \n}";
            s[31] = "DeleteNode(Node node, int value) {";
            s[32] = "     DeleteNode(node.Left ,value); \n}";
            s[33] = "     DeleteNode(node.Right ,value); \n}";
            s[34] = "       node = node.Left;";
            s[35] = "       node = node.Right;";
            s[36] = "       Node replaceNode = find_Min(node.right);";
            s[37] = "       node.key = replaceNode.key;";
            s[38] = "       DeleteNode(node.Right, replaceNode.Key); \n}";
            s[39] = "   if(node == NULL)";
            s[40] = "       return ;";
            s[41] = "else {";
            //s[22] = "";

        }
        public void InOrderCode(int vt,Graphics g)
        {
            setString();
           // g.FillRectangle(Brushes.DarkGreen, 700, 0, 700, 700);
            g.DrawString(s[22], font, Brushes.Black, 700, 150);
            g.DrawString(s[7], font, Brushes.Black, 700, 200);
            g.DrawString(s[13], font, Brushes.Black, 700, 250);
            g.DrawString(s[8], font, Brushes.Black, 700, 300);
            if(vt==22)
                g.DrawString(s[22], font, Brushes.Yellow, 700, 150);
            if (vt==7)
                g.DrawString(s[7], font, Brushes.Yellow, 700, 200);
            if(vt==13)
                g.DrawString(s[13], font, Brushes.Yellow, 700, 250);
            if(vt==8)
                g.DrawString(s[8], font, Brushes.Yellow, 700, 300);
        }
        public void PreOrderCode(int vt, Graphics g)
        {
            setString();
           // g.FillRectangle(Brushes.DarkGreen, 700, 0, 700, 700);
            g.DrawString(s[23], font, Brushes.Black, 700, 150);
            g.DrawString(s[13], font, Brushes.Black, 700, 200);
            g.DrawString(s[9], font, Brushes.Black, 700, 250);
            g.DrawString(s[10], font, Brushes.Black, 700, 300);
            if (vt == 23)
                g.DrawString(s[23], font, Brushes.Yellow, 700, 150);
            if (vt == 13)
                g.DrawString(s[13], font, Brushes.Yellow, 700, 200);
            if (vt == 9)
                g.DrawString(s[9], font, Brushes.Yellow, 700, 250);
            if (vt == 10)
                g.DrawString(s[10], font, Brushes.Yellow, 700, 300);

        }
        public void PosOrderCode(int vt,Graphics g)
        {
            setString();
            //g.FillRectangle(Brushes.DarkGreen, 700, 0, 700, 700);
            g.DrawString(s[24], font, Brushes.Black, 700, 150);
            g.DrawString(s[11], font, Brushes.Black, 700, 200);
            g.DrawString(s[12], font, Brushes.Black, 700, 250);
            g.DrawString(s[25], font, Brushes.Black, 700, 300);
            if (vt == 24)
                g.DrawString(s[24], font, Brushes.Yellow, 700, 150);
            if (vt == 11)
                g.DrawString(s[11], font, Brushes.Yellow, 700, 200);
            if (vt == 12)
                g.DrawString(s[12], font, Brushes.Yellow, 700, 250);
            if (vt == 25)
                g.DrawString(s[25], font, Brushes.Yellow, 700, 300);
        }
        public void FindCode(int vt,Graphics g)
        {
            setString();
            
            g.DrawString(s[26], font, Brushes.White, 700, 150);
            g.DrawString(s[0], font, Brushes.White, 700, 190);
            g.DrawString(s[4], font, Brushes.White, 700, 220);
            g.DrawString(s[1], font, Brushes.White, 700, 270);
            g.DrawString(s[5], font, Brushes.White, 700, 300);
            g.DrawString(s[6], font, Brushes.White, 700, 350);
            g.DrawString(s[25], font, Brushes.White, 700, 390);
            if (vt == 26)
                g.DrawString(s[26], font, Brushes.Yellow, 700, 150);
            if (vt == 0)
                g.DrawString(s[0], font, Brushes.Yellow, 700, 190);
            if (vt == 4)
                g.DrawString(s[4], font, Brushes.Yellow, 700, 220);
            if (vt == 1)
                g.DrawString(s[1], font, Brushes.Yellow, 700, 270);
            if (vt == 5)
                g.DrawString(s[5], font, Brushes.Yellow, 700, 300);
            if (vt == 6)
                g.DrawString(s[6], font, Brushes.Yellow, 700, 350);
            if (vt == 25)
                g.DrawString(s[25], font, Brushes.Yellow, 700, 390);
        }
        public void InsertCode(int vt,Graphics g)
        {
            setString();

            g.DrawString(s[27], font, Brushes.White, 700, 150);
            g.DrawString(s[28], font, Brushes.White, 700, 190);
            g.DrawString(s[30], font, Brushes.White, 700, 220);
            g.DrawString(s[29], font, Brushes.White, 700, 270);
            g.DrawString(s[0], font, Brushes.White, 700, 300);
            g.DrawString(s[2], font, Brushes.White, 700, 350);
            g.DrawString(s[6], font, Brushes.White, 700, 390);
            g.DrawString(s[3], font, Brushes.White, 700, 430);
            if (vt == 27)
                g.DrawString(s[27], font, Brushes.Yellow, 700, 150);
            if (vt == 28)
                g.DrawString(s[28], font, Brushes.Yellow, 700, 190);
            if (vt == 30)
                g.DrawString(s[30], font, Brushes.Yellow, 700, 220);
            if (vt == 29)
                g.DrawString(s[29], font, Brushes.Yellow, 700, 270);
            if (vt == 0)
                g.DrawString(s[0], font, Brushes.Yellow, 700, 300);
            if (vt == 2)
                g.DrawString(s[2], font, Brushes.Yellow, 700, 350);
            if (vt == 6)
                g.DrawString(s[6], font, Brushes.Yellow, 700, 390);
            if (vt == 3)
                g.DrawString(s[3], font, Brushes.Yellow, 700, 430);
        }
        public void DelCode(int vt,Graphics g)
        {
            setString();
            

            g.DrawString(s[31], font1, Brushes.White, 700+50, 80);
            g.DrawString(s[39], font1, Brushes.White, 700 + 50, 110);
            g.DrawString(s[40], font1, Brushes.White, 700 + 50, 140);
            g.DrawString(s[17], font1, Brushes.White, 700 + 50, 170);
            g.DrawString(s[0], font1, Brushes.White, 700 + 50, 200);
            g.DrawString(s[32], font1, Brushes.White, 700 + 50, 230);
            g.DrawString(s[6], font1, Brushes.White, 700 + 50, 260);
            g.DrawString(s[33], font1, Brushes.White, 700 + 50, 290);

            g.DrawString(s[29], font1, Brushes.White, 700 + 50, 320);
            //g.DrawString(s[39], font1, Brushes.White, 700, 350);
            g.DrawString(s[15], font1, Brushes.White, 700 + 50, 380-30);
            g.DrawString(s[35], font1, Brushes.White, 700 + 50, 410 - 30);
            g.DrawString(s[16], font1, Brushes.White, 700 + 50, 440 - 30);
            g.DrawString(s[34], font1, Brushes.White, 700 + 50, 470 - 30);
            g.DrawString(s[41], font1, Brushes.White, 700 + 50, 500 - 30);
            g.DrawString(s[36], font1, Brushes.White, 700 + 50, 530 - 30);

            g.DrawString(s[37], font1, Brushes.White, 700 + 50, 560 - 30);
            g.DrawString(s[38], font1, Brushes.White, 700 + 50, 590 - 30);
           
            if (vt == 31)
                g.DrawString(s[31], font1, Brushes.Yellow, 700 + 50, 80);
            if (vt == 39)
                g.DrawString(s[39], font1, Brushes.Yellow, 700 + 50, 110);
            if (vt == 40)
                g.DrawString(s[40], font1, Brushes.Yellow, 700 + 50, 140);
            if (vt == 17)
                g.DrawString(s[17], font1, Brushes.Yellow, 700 + 50, 170);
            if (vt == 0)
                g.DrawString(s[0], font1, Brushes.Yellow, 700 + 50, 200);
            if (vt == 32)
                g.DrawString(s[32], font1, Brushes.Yellow, 700 + 50, 230);
            if (vt == 6)
                g.DrawString(s[6], font1, Brushes.Yellow, 700 + 50, 260);
            if (vt == 33)
                g.DrawString(s[33], font1, Brushes.Yellow, 700 + 50, 290);
            if (vt == 29)
                g.DrawString(s[29], font1, Brushes.Yellow, 700 + 50, 320);
          //  if (vt == 39)
               // g.DrawString(s[39], font1, Brushes.Yellow, 700, 350);
            if (vt == 15)
                g.DrawString(s[15], font1, Brushes.Yellow, 700 + 50, 380 - 30);
            if (vt == 35)
                g.DrawString(s[35], font1, Brushes.Yellow, 700 + 50, 410 - 30);
            if (vt == 16)
                g.DrawString(s[16], font1, Brushes.Yellow, 700 + 50, 440 - 30);
            if (vt == 34)
                g.DrawString(s[34], font1, Brushes.Yellow, 700 + 50, 470 - 30);
            if (vt == 41)
                g.DrawString(s[41], font1, Brushes.Yellow, 700 + 50, 500 - 30);
            if (vt == 36)
                g.DrawString(s[36], font1, Brushes.Yellow, 700 + 50, 530 - 30);
            if (vt == 37)
                g.DrawString(s[37], font1, Brushes.Yellow, 700 + 50, 560 - 30);
            if (vt == 38)
                g.DrawString(s[38], font1, Brushes.Yellow, 700 + 50, 590 - 30);

        }
    }
}
