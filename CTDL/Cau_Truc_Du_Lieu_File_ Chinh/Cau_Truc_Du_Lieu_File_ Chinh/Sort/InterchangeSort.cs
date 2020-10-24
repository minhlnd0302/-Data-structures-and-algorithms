using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Cau_Truc_Du_Lieu_File__Chinh.Sort
{
    public partial class InterchangeSort : Form
    {
        public InterchangeSort()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Sort.InterchangeSort newForm = new InterchangeSort();
            newForm.Show();
            this.Dispose(false);
        }

        private void BtnNewTab_Click(object sender, EventArgs e)
        {

            Sort.InterchangeSort newForm = new InterchangeSort();
            newForm.Show();
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            Graphics grap = CreateGraphics();
            List<int> arr = new List<int>();
            List<Point> pointStringCode = new List<Point>();
            List<pointStruct> pointArr = new List<pointStruct>();

            string[] stringCode = _addStringCode();

            int numberOfElements;
            Int32.TryParse(txbInputNumber.Text, out numberOfElements);
            if (numberOfElements == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng phần tử hợp lệ !", "Lưu ý !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            parameter par = new parameter(numberOfElements);
            Function function = new Function();
            function._ranDumArr(arr, numberOfElements);
            function._drawArr_Weight(grap, par, arr, pointArr);
            _drawStringCode(pointStringCode, stringCode, grap);
            _InterchangeSort(grap, par, pointArr, pointStringCode, stringCode, arr);
        }
        

        private void _InterchangeSort(Graphics grap, parameter par, List<pointStruct> pointStructArr, List<Point> pointStringCode, string[] stringCode, List<int> arr)
        {
            Function function = new Function();

            int N = arr.Count;
            function._flickerFunction(grap, par, pointStringCode, stringCode, 0, 0);
            
            function._flickerFunction(grap, par, pointStringCode, stringCode, 2, 0);
            int i, j;

            function._flickerFunction(grap, par, pointStringCode, stringCode, 3, 8);
            for (i = 0; i < N - 1; i++)
            {
                grap.DrawLine(par.RedPen, pointStructArr[i].point1, pointStructArr[i].point2);
                if (i > 0) { function._flickerFunction(grap, par, pointStringCode, stringCode, 8, -1); }

                function._flickerFunction(grap, par, pointStringCode, stringCode, 4, 9);
                for (j = i + 1; j < N; j++)
                {
                    Thread.Sleep(30);
                    grap.DrawLine(par.YellowPen, pointStructArr[j].point1, pointStructArr[j].point2);
                    Thread.Sleep(80);
                    
                    if (j > 1) { function._flickerFunction(grap, par, pointStringCode, stringCode, 9, -1); }

                    function._flickerFunction(grap, par, pointStringCode, stringCode, 5, 0);
                    if (arr[j] < arr[i])
                    {
                        grap.DrawLine(par.RedPen, pointStructArr[j].point1, pointStructArr[j].point2);
                        Thread.Sleep(100);

                        par.WhitePen.Width = par.BlackPen.Width;
                        grap.DrawLine(par.WhitePen, pointStructArr[i].point1.X, pointStructArr[i].point1.Y + 20, pointStructArr[i].point2.X, pointStructArr[i].point2.Y);
                        grap.DrawLine(par.WhitePen, pointStructArr[j].point1.X, pointStructArr[j].point1.Y + 20, pointStructArr[j].point2.X, pointStructArr[j].point2.Y);

                        function._flickerFunction(grap, par, pointStringCode, stringCode, 6, 0);
                        function._Swap(arr, pointStructArr, i, j);
                        grap.DrawLine(par.RedPen, pointStructArr[i].point1, pointStructArr[i].point2);
                        grap.DrawLine(par.BlackPen, pointStructArr[j].point1, pointStructArr[j].point2);

                        if(par.NumberOfElements<=25)  function.veLaiTrongSo(grap, par, arr, pointStructArr, i, j);

                    }
                    else
                    {
                        grap.DrawLine(par.BlackPen, pointStructArr[j].point1, pointStructArr[j].point2);
                    }
                }
                grap.DrawLine(par.GreenPen, pointStructArr[i].point1, pointStructArr[i].point2);
            }
            grap.DrawLine(par.GreenPen, pointStructArr[N-1].point1, pointStructArr[N-1].point2);
        }

        private void _drawStringCode(List<Point> pointStringCode, string[] stringCode, Graphics grap)
        {
            DrawSort drawCode = new DrawSort();
            Point pointCode = new Point();
            pointCode.X = 700;
            pointCode.Y = 20;
            pointStringCode.Add(pointCode);

            int tmpPointX = new int();

            for(int i=0; i<10; i++)
            {
                if (i > 7)
                {
                    if (i == 8)
                    {
                        pointCode = pointStringCode[3];
                        pointCode.X += 130;
                        pointStringCode.Add(pointCode);
                        grap.DrawString(stringCode[i], drawCode.DrawFont2, drawCode.DrawBlackBrush, pointStringCode[i]);
                    }
                     
                        pointCode = pointStringCode[4];
                        pointCode.X += 125;
                        pointStringCode.Add(pointCode);
                        grap.DrawString(stringCode[i], drawCode.DrawFont2, drawCode.DrawBlackBrush, pointStringCode[i]);
                    

                }
                else if (i == 2 || i == 3)
                {
                    tmpPointX = pointStringCode[0].X + 25; 
                }
                else if (i == 4)
                {
                    tmpPointX = pointStringCode[0].X + 50;
                }
                else if (i == 5)
                {
                    tmpPointX = pointStringCode[0].X + 75;
                }
                else if (i == 6)
                {
                    tmpPointX = pointStringCode[0].X + 100;
                }
                else if(i==1||i==7)
                {
                    tmpPointX = pointStringCode[0].X;
                }

                pointCode.X = tmpPointX;
                pointCode.Y = i * 25 + 20;

                if (i > 0)
                {
                    pointStringCode.Add(pointCode);

                }
                grap.DrawString(stringCode[i], drawCode.DrawFont2, drawCode.DrawBlackBrush, pointStringCode[i]); 
            }

        }
        private string[] _addStringCode()
        {
            string[]  stringCode = new string[]
            {
                "void InterchangeSort ( int a[ ] , int N )",
                "{",
                "int i , j ;",
                "for ( i = 0 ; i < N-1 ;         )",
                "for ( j =i+1 ; j < N ;         )",
                "if ( a[ j ]< a [ i ] )",
                "Swap( a [ i ] , a [ j ] );",
                "}",
                " i++",
                " j++" 
            };
            return stringCode;
        }
    }
}
