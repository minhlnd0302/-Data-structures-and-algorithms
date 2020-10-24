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
    public partial class SelectionSort : Form
    {
        public SelectionSort()
        {
            InitializeComponent();
        }

        private void BtnSelectionSort_Click(object sender, EventArgs e)
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

            
            _selectionSort(grap, par, pointArr, pointStringCode, stringCode, arr);
      

        }
        private void _selectionSort(Graphics grap, parameter par, List<pointStruct> pointStructArr, List<Point> pointStringCode, string[] stringCode, List<int> arr)
        {
            Function function = new Function();
            function._flickerFunction(grap, par, pointStringCode, stringCode, 0, 0);

            int min = new int();
            function._flickerFunction(grap, par, pointStringCode, stringCode, 1, 0);

            function._flickerFunction(grap, par, pointStringCode, stringCode, 2, 10);
             
            for (int i = 0; i < (par.NumberOfElements - 1); i++)
            {
                if (i != 0) { function._flickerFunction(grap, par, pointStringCode, stringCode, 10, -1); }
                
                min = i;
                function._flickerFunction(grap, par, pointStringCode, stringCode, 3, 0);
                grap.DrawLine(par.RedPen, pointStructArr[min].point1, pointStructArr[min].point2);

                function._flickerFunction(grap, par, pointStringCode, stringCode, 4, 11);
               // function._flickerFunction(grap, par, pointStringCode, stringCode, 11);//jgfhgfhg
                for (int j = i + 1; j < par.NumberOfElements; j++)
                {
                    if (j != 1) { function._flickerFunction(grap, par, pointStringCode, stringCode, 11, -1); }

               
                   
                    grap.DrawLine(par.YellowPen, pointStructArr[j].point1, pointStructArr[j].point2);
                    Thread.Sleep(300);

                    

                    grap.DrawLine(par.BlackPen, pointStructArr[j].point1, pointStructArr[j].point2);

                    function._flickerFunction(grap, par, pointStringCode, stringCode, 5, 0);
                    Thread.Sleep(30);
                    if (arr[j] < arr[min])
                    {
                        grap.DrawLine(par.BlackPen, pointStructArr[min].point1, pointStructArr[min].point2);
                        min = j;
                        function._flickerFunction(grap, par, pointStringCode, stringCode, 6, 0);
                        grap.DrawLine(par.RedPen, pointStructArr[j].point1, pointStructArr[j].point2);
                       
                    }

                    Thread.Sleep(30);

                }
                function._flickerFunction(grap, par, pointStringCode, stringCode, 7, 0);
                if (min != i)
                {
                    function._flickerFunction(grap, par, pointStringCode, stringCode, 8, 0);

                    // can fix
                    par.WhitePen.Width = par.BlackPen.Width;
                    grap.DrawLine(par.WhitePen, pointStructArr[i].point1.X, pointStructArr[i].point1.Y + 20, pointStructArr[i].point2.X, pointStructArr[i].point2.Y);
                    grap.DrawLine(par.WhitePen, pointStructArr[min].point1.X, pointStructArr[min].point1.Y + 20, pointStructArr[min].point2.X, pointStructArr[min].point2.Y);
                     
                    function._Swap(arr,pointStructArr, min, i);
                     
                    Thread.Sleep(50);
                    grap.DrawLine(par.GreenPen, pointStructArr[i].point1, pointStructArr[i].point2);
                   // Thread.Sleep(50);
                    grap.DrawLine(par.BlackPen, pointStructArr[min].point1, pointStructArr[min].point2);
                    Thread.Sleep(10);
                     
                    function.veLaiTrongSo(grap, par, arr, pointStructArr, i, min);
 
                }
                else
                {
                    grap.DrawLine(par.GreenPen, pointStructArr[i].point1, pointStructArr[i].point2);
                }
            }
            grap.DrawLine(par.GreenPen, pointStructArr[par.NumberOfElements-1].point1, pointStructArr[par.NumberOfElements-1].point2);
        }

        private string[] _addStringCode()
        {
            string[] stringCode = new string[]
            {
                "void  SelectionSort (int a[ ], int N) {",
                "int min;",
                "for ( int i = 0; i < N - 1;          )",
                "min = i;",
                "for ( int j = i + 1; j < N;          )",
                "if ( a[j] < a[min] )",
                "min = j;",
                "if ( min != i )",
                "Swap( a[min], a[i] );",
                "}",
                " i++",
                " j++"
            };
            return stringCode;
        }


        private static void _drawStringCode(List<Point> pointStringCode, string[] arrStringCode, Graphics grap)
        {
            DrawSort drawCode = new DrawSort();
            Point pointCode = new Point();
            pointCode.X = 700;
            pointCode.Y = 20;
            pointStringCode.Add(pointCode);

            int tmpPointX = new int();

            for (int i = 0 ; i < 12; i++)
            {
                if (i > 9)
                {
                    if (i == 11)
                    {
                        pointCode = pointStringCode[4];
                        pointCode.X += 155;
                        pointStringCode.Add(pointCode);
                        grap.DrawString(arrStringCode[i], drawCode.DrawFont2, drawCode.DrawBlackBrush, pointStringCode[i]);
                    }
                    pointCode = pointStringCode[2];
                    pointCode.X += 155;
                    pointStringCode.Add(pointCode);
                    grap.DrawString(arrStringCode[i], drawCode.DrawFont2, drawCode.DrawBlackBrush, pointStringCode[i]);
                }
                else
                {
                    if (i == 1 || i == 2 || i == 7)
                    {
                        tmpPointX = pointStringCode[0].X + 25;
                    }
                    else if (i == 3 || i == 4 || i == 8)
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
                    else if (i == 9 /*|| i == 0*/)
                    {
                        tmpPointX = pointStringCode[0].X;
                    }

                    pointCode.X = tmpPointX;
                    pointCode.Y = i * 25 + 20;

                    if (i > 0)
                    {
                        pointStringCode.Add(pointCode);

                    }
                    grap.DrawString(arrStringCode[i], drawCode.DrawFont2, drawCode.DrawBlackBrush, pointStringCode[i]);
                }
                
            }
             
        } 
        private void btnReset_Click(object sender, EventArgs e)
        {
            Sort.SelectionSort newForm = new SelectionSort();
            newForm.Show();
            this.Dispose(false);

        }

        private void BtnNewTab_Click(object sender, EventArgs e)
        {
            Sort.SelectionSort newForm = new SelectionSort();
            newForm.Show();
        }
    }
}
