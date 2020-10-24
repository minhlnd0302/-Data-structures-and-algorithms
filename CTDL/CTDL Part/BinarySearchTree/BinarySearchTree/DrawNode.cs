using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace BinarySearchTree
{
    class DrawNode
    {
        Pen p_black = new Pen(Color.Black, 10);
        Pen p_blue = new Pen(Color.Blue, 3);
        Pen p_orange = new Pen(Color.Orange, 3);
        Pen p_red = new Pen(Color.Red, 3);
        Pen p_white = new Pen(Color.White, 10);
        Pen p_yellow = new Pen(Color.Yellow, 3);
        Font font = new Font("Times New Roman", 12, FontStyle.Bold);

        public void drawNode(int x, int y, Graphics g)
        {
            g.FillEllipse(Brushes.White, x, y, 40, 40);

        }
        public void drawVal(int x, int y, int val, Graphics g)
        {
            if (val > 9)
            {
                if (val > 99)
                {
                    if (val > 999)
                    {
                        g.DrawString(val.ToString(), font, Brushes.Red, x + 3, y + 10);
                    }
                    else
                    {
                        g.DrawString(val.ToString(), font, Brushes.Red, x + 7, y + 10);
                    }
                }
                else
                {
                    g.DrawString(val.ToString(), font, Brushes.Red, x + 10, y + 10);
                }
            }
            else {
                g.DrawString(val.ToString(), font, Brushes.Red, x + 13, y + 10);
            }

        }
        public void DrawArr(int x, int y, int z, int t, Graphics g)
        {
            p_white.EndCap = LineCap.ArrowAnchor;
            p_white.Width = 3;
            if (x > z)
            {
                g.DrawLine(p_white, x, y + 30, z + 30, t);
            }
            else
            {
                g.DrawLine(p_white, x + 38, y + 30, z + 10, t);
            }
            if (y > t)
            {
                g.DrawLine(p_white, x + 20, y, z + 30, t + 30);
            }
        }
       
        public void drawValInFillElipse(int x, int y, int val, Graphics g, string color)
        {
            switch (color)
            {
                case "red":
                if (val > 9)
            {
                if (val > 99)
                {
                    if (val > 999)
                    {
                        g.DrawString(val.ToString(), font, Brushes.Red, x + 3, y + 10);
                    }
                    else
                    {
                        g.DrawString(val.ToString(), font, Brushes.Red, x + 7, y + 10);
                    }
                }
                else
                {
                    g.DrawString(val.ToString(), font, Brushes.Red, x + 10, y + 10);
                }
            }
                else
            {
                g.DrawString(val.ToString(), font, Brushes.Red, x + 13, y + 10);
            }
               break;
                case "white":
                    if (val > 9)
                    {
                        if (val > 99)
                        {
                            if (val > 999)
                            {
                                g.DrawString(val.ToString(), font, Brushes.White, x + 3, y + 10);
                            }
                            else
                            {
                                g.DrawString(val.ToString(), font, Brushes.White, x + 7, y + 10);
                            }
                        }
                        else
                        {
                            g.DrawString(val.ToString(), font, Brushes.White, x + 10, y + 10);
                        }
                    }
                    else
                    {
                        g.DrawString(val.ToString(), font, Brushes.White, x + 13, y + 10);
                    }
                    break;
                case "black":
                    if (val > 9)
                    {
                        if (val > 99)
                        {
                            if (val > 999)
                            {
                                g.DrawString(val.ToString(), font, Brushes.Black, x + 3, y + 10);
                            }
                            else
                            {
                                g.DrawString(val.ToString(), font, Brushes.Black, x + 7, y + 10);
                            }
                        }
                        else
                        {
                            g.DrawString(val.ToString(), font, Brushes.Black, x + 10, y + 10);
                        }
                    }
                    else
                    {
                        g.DrawString(val.ToString(), font, Brushes.Black, x + 13, y + 10);
                    }
                    break;
                case "green":
                    if (val > 9)
                    {
                        if (val > 99)
                        {
                            if (val > 999)
                            {
                                g.DrawString(val.ToString(), font, Brushes.Green, x + 3, y + 10);
                            }
                            else
                            {
                                g.DrawString(val.ToString(), font, Brushes.Green, x + 7, y + 10);
                            }
                        }
                        else
                        {
                            g.DrawString(val.ToString(), font, Brushes.Green, x + 10, y + 10);
                        }
                    }
                    else
                    {
                        g.DrawString(val.ToString(), font, Brushes.Green, x + 13, y + 10);
                    }
                    break;
                    
            } 
        }
        public void drawBorder(int x, int y, Graphics g,string color)
        {
            switch (color)
            {
                //case "white":
                //    g.DrawEllipse(p_white, x+1, y+1, 39, 39);
                //    break;
                //case "black":
                //    g.DrawEllipse(p_black, x+1, y+1, 39, 39);
                //    break;
                //case "red":
                //    g.DrawEllipse(p_red, x+1, y+1, 39, 39);
                //    break;
                //case "orange":
                //    g.DrawEllipse(p_orange, x+1, y+1, 39, 39);
                //    break;
                //case "yellow":
                //    g.DrawEllipse(p_yellow, x+1, y+1, 39, 39);
                //    break;
                case "white":
                    g.DrawEllipse(p_white, x , y , 40, 40);
                    break;
                case "black":
                    g.DrawEllipse(p_black, x, y , 40, 40);
                    break;
                case "red":
                    g.DrawEllipse(p_red, x , y , 40, 40);
                    break;
                case "orange":
                    g.DrawEllipse(p_orange, x , y , 40, 40);
                    break;
                case "yellow":
                    g.DrawEllipse(p_yellow, x , y , 40, 40);
                    break;
            }
            

        }
        public void delBorder(int x, int y, Graphics g,string color)
        {
            switch (color)
            {
                case "white":
                    g.DrawEllipse(p_white, x, y, 40, 40);
                    break;
                case "black":
                    g.DrawEllipse(p_black, x, y, 40, 40);
                    break;
                case "red":
                    g.DrawEllipse(p_red, x, y, 40, 40);
                    break;
                case "orange":
                    g.DrawEllipse(p_orange, x, y, 40, 40);
                    break;
                case "yellow":
                    g.DrawEllipse(p_yellow, x, y, 40, 40);
                    break;
            }

        }
        public void fillNode(int x,int y,Graphics g,string color,int val)
        {
            switch (color)
            {
                case "white-red":
                    g.FillEllipse(Brushes.White, x-1, y-1, 42, 42);
                    drawValInFillElipse(x, y, val, g,"red");
                    break;
                case "orange-white":
                    g.FillEllipse(Brushes.Orange, x-1, y-1, 42, 42);
                    drawValInFillElipse(x, y, val, g,"white");
                    break;
                case "red-white":
                    g.FillEllipse(Brushes.Red, x-1, y-1, 42, 42);
                    drawValInFillElipse(x, y, val, g,"white");
                    break;
                case "white-black":
                    g.FillEllipse(Brushes.White, x-1, y-1, 42, 42);
                    drawValInFillElipse(x, y, val, g,"black");
                    break;
                case "yellow-green":
                    g.FillEllipse(Brushes.Yellow, x-1, y-1, 42, 42);
                    drawValInFillElipse(x, y, val, g, "green");
                    break;
               

            }
        }



    }
}
