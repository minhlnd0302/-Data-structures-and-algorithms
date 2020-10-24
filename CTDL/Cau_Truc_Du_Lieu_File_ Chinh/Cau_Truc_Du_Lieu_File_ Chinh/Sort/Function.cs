using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace Cau_Truc_Du_Lieu_File__Chinh.Sort
{
    class Function
    {
        // hàm  ramdom số
        public void _ranDumArr(List<int> arr, int k)
        {
            Random rnd = new Random();
            for (int i = 0; i < k; i++)
            {
                arr.Add(rnd.Next(1, k + 1));
            }

        }

        // hoán dổi vtri
        public void _Swap(List<int> a, List<pointStruct> pointStructArr, int l, int r)
        {
            int tmp = a[l];
            a[l] = a[r];
            a[r] = tmp;

            float k = pointStructArr[r].point2.Y;

            pointStructArr[r].point2.Y = pointStructArr[l].point2.Y;

            pointStructArr[l].point2.Y = k;  
        }

        public void _SwapPointArr(List<pointStruct> pointStructArr, int l, int r)
        { 
            float k = pointStructArr[r].point2.Y;

            pointStructArr[r].point2.Y = pointStructArr[l].point2.Y;

            pointStructArr[l].point2.Y = k;
        }


        // hàm nhấp nháy
        public void _flickerFunction(Graphics g, parameter par, List<Point> pointStringCode, string[] stringCode, int k, int n)
        {
            par.WhitePen.Width = 20;

            g.DrawLine(par.WhitePen, pointStringCode[k].X, pointStringCode[k].Y + 8, n < 0 ? pointStringCode[k].X + 37 : 1500, pointStringCode[k].Y + 8);

            g.DrawString(stringCode[k], par.DrawFont2, Brushes.Red, pointStringCode[k]);

            if (n > 0)
            {
                g.DrawString(stringCode[n], par.DrawFont2, Brushes.Red, pointStringCode[n]);
            }

            Thread.Sleep(500);

            g.DrawLine(par.WhitePen, pointStringCode[k].X, pointStringCode[k].Y + 8, n < 0 ? pointStringCode[k].X + 37 : 1500, pointStringCode[k].Y + 8);
            
            g.DrawString(stringCode[k], par.DrawFont2, par.DrawBlackBrush, pointStringCode[k]);
            if (n > 0)
            {
                g.DrawString(stringCode[n], par.DrawFont2, par.DrawBlackBrush, pointStringCode[n]);
            }
        }

        //  vẽ mảng
        public void _drawArr_Weight(Graphics grap, parameter par, List<int> arr, List<pointStruct> pointArr)
        {
            par.BlackPen.Width = par.WhitePen.Width = par.RedPen.Width = par.GreenPen.Width = par.YellowPen.Width = par.SizePen;
 
            foreach (int n in arr)
            {
                pointStruct pointStructArr = new pointStruct();

                pointStructArr.point1.X = 40 + par.DistanceCount;
                pointStructArr.point1.Y = par.NumberOfElements / par.Rate;

                pointStructArr.point2.X = 40 + par.DistanceCount;
                pointStructArr.point2.Y = (par.NumberOfElements / par.Rate) - (n / par.Rate);

                pointArr.Add(pointStructArr);

                
                grap.DrawLine(par.BlackPen, pointStructArr.point1, pointStructArr.point2);

                if (par.NumberOfElements < 50)
                {
                    Thread.Sleep(15);
                }
                 
                veTrongSo(grap, par, n);
                  
                par.DistanceCount += (1 / par.Rate);
            }
        }

        public void veTrongSo(Graphics grap, parameter par, int n)
        {
            if (par.NumberOfElements > 25) return;
            PointF pointDrawString1 = new PointF();
            PointF pointDrawString2 = new PointF();
            pointDrawString2.Y = pointDrawString1.Y = par.NumberOfElements / par.Rate;

            pointDrawString1.X = 40 + (par.DistanceCount - (1 / par.Rate) / 2) + 1;
            pointDrawString2.X = 40 + par.DistanceCount - 5;
            grap.DrawString(n.ToString(), par.DrawFont, par.DrawBlackBrush, (n < 10 ? pointDrawString2 : pointDrawString1));
        }

        public void veLaiTrongSo(Graphics grap, parameter par, List<int> arr, List<pointStruct> pointStructArr, int i, int min)
        {
            if (par.NumberOfElements > 25) return;
            float x1 = pointStructArr[i].point1.X - 5;
            float x2 = pointStructArr[i].point1.X - 9;
            float x3 = pointStructArr[min].point1.X - 5;
            float x4 = pointStructArr[min].point1.X - 9;
            grap.DrawString(arr[i].ToString(), par.DrawFont, par.DrawBlackBrush, arr[i] < 10 ? x1 : x2, pointStructArr[i].point1.Y + 0.45f);
            grap.DrawString(arr[min].ToString(), par.DrawFont, par.DrawBlackBrush, arr[min] < 10 ? x3 : x4, pointStructArr[min].point1.Y + 0.45f);
        }

        public void _upDateArrGreen(parameter par, Graphics grap, List<pointStruct> pointStructArr)
        {
            for(int i=0; i < pointStructArr.Count; i++)
            {
                grap.DrawLine(par.GreenPen, pointStructArr[i].point1, pointStructArr[i].point2);
                Thread.Sleep(30);
            }
        }

        public void _drawStringCode_Tho(Graphics grap, List<Point> pointStringCode, string[] stringCode, int k)
        {
            DrawSort drawCode = new DrawSort();
            Point tmp = new Point(700, 20);
            for (int i = 0; i <= k; i++)
            {
                pointStringCode.Add(tmp);
                grap.DrawString(stringCode[i], drawCode.DrawFont2, drawCode.DrawBlackBrush, pointStringCode[i]);
                tmp.Y += 25;
            }
        }

    }
}    
