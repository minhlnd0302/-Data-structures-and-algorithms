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
    public partial class InsertionSort : Form
    {
        public InsertionSort()
        {
            InitializeComponent();
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

            Function function = new Function();
            parameter par = new parameter(numberOfElements);

            function._ranDumArr(arr, numberOfElements);
            function._drawArr_Weight(grap, par, arr, pointArr);
            _drawStringCode(pointStringCode, stringCode, grap);
            _insertionSort(par, grap, pointArr, pointStringCode, stringCode, arr);
            function._upDateArrGreen(par, grap, pointArr);
        }

        private void _insertionSort(parameter par, Graphics grap, List<pointStruct> pointStructArr, List<Point> pointStringCode, string[] stringCode, List<int> arr)
        {
           
            Function function = new Function();

            function._flickerFunction(grap, par, pointStringCode, stringCode, 0, 0);

            function._flickerFunction(grap, par, pointStringCode, stringCode, 2, 0);
            int pos,i, N = arr.Count;

            function._flickerFunction(grap, par, pointStringCode, stringCode, 3, 0);
            int x;//löu tröõ a[i] traùnh bò ghi ñeø khi dôøi choã caùc phaàn töû.
            int vtr;

            function._flickerFunction(grap, par, pointStringCode, stringCode, 4, 12);
            for (i = 1; i < N; i++) //ñoaïn a[0] ñaõ saép
            {
                grap.DrawLine(par.RedPen, pointStructArr[i].point1, pointStructArr[i].point2);
                Thread.Sleep(100);
                par.WhitePen.Width = par.BlackPen.Width;
                grap.DrawLine(par.WhitePen, pointStructArr[i].point1.X,pointStructArr[i].point1.Y+20, pointStructArr[i].point2.X,pointStructArr[i].point2.Y);
                

                if (i > 1 ) { function._flickerFunction(grap, par, pointStringCode, stringCode, 12, -1); }

                function._flickerFunction(grap, par, pointStringCode, stringCode, 6, 0);
                x = arr[i];
                vtr = i;  

                function._flickerFunction(grap, par, pointStringCode, stringCode, 7, 13);
                for (pos = i; (pos > 0) && (arr[pos - 1] > x); pos--)
                {
                    vtr = pos - 1;  
                    par.WhitePen.Width = par.BlackPen.Width;
                    grap.DrawLine(par.WhitePen, pointStructArr[pos - 1].point1.X, pointStructArr[pos - 1].point1.Y+20, pointStructArr[pos - 1].point2.X, pointStructArr[pos - 1].point2.Y); 
                     
                    _swap(arr, pointStructArr, pos, pos - 1);
                    grap.DrawLine(par.BlackPen, pointStructArr[pos].point1, pointStructArr[pos].point2);
                   
                    if (i!=1) function._flickerFunction(grap, par, pointStringCode, stringCode, 13, -1);
                    function._flickerFunction(grap, par, pointStringCode, stringCode, 8, 0); 
                    arr[pos] = arr[pos - 1];
                    _veLaiTrongSo(grap, par, arr, pointStructArr, pos);
                    Thread.Sleep(100);
                }

                
                function._flickerFunction(grap, par, pointStringCode, stringCode, 9, 0);
                arr[pos] = x;// chèn x vào dãy
                grap.DrawLine(par.BlackPen, pointStructArr[vtr].point1, pointStructArr[vtr].point2);
                _veLaiTrongSo(grap, par, arr, pointStructArr, vtr);
            }

            Thread.Sleep(100);
        }

        

        private void _veLaiTrongSo(Graphics grap, parameter par, List<int> arr, List<pointStruct> pointStructArr, int i)
        {
            if (par.NumberOfElements > 25) return;
            float x1 = pointStructArr[i].point1.X - 5;
            float x2 = pointStructArr[i].point1.X - 9;
            grap.DrawString(arr[i].ToString(), par.DrawFont, par.DrawBlackBrush, arr[i] < 10 ? x1 : x2, pointStructArr[i].point1.Y + 0.45f);
        }
        private void _swap(List<int> a, List<pointStruct> pointStructArr, int l, int r)
        { 
                float k = pointStructArr[r].point2.Y;

                pointStructArr[r].point2.Y = pointStructArr[l].point2.Y;

                pointStructArr[l].point2.Y = k;
             
        }
        private void _drawStringCode(List<Point> pointStringCode, string[] arrStringCode, Graphics grap)
        {
            DrawSort drawCode = new DrawSort();
            Point pointCode = new Point();
            pointCode.X = 700;
            pointCode.Y = 20;
            pointStringCode.Add(pointCode);

            int tmpPointX = new int();

            for (int i = 0; i < 14; i++)
            {
                if (i > 11)
                {
                    if (i == 12)
                    {
                        pointCode = pointStringCode[4];
                        pointCode.X += 125;
                        pointStringCode.Add(pointCode);
                        grap.DrawString(arrStringCode[i], drawCode.DrawFont2, drawCode.DrawBlackBrush, pointStringCode[i]);
                        continue;
                    }

                    pointCode = pointStringCode[7];
                    pointCode.X += 268;
                    pointStringCode.Add(pointCode);
                    grap.DrawString(arrStringCode[i], drawCode.DrawFont2, drawCode.DrawBlackBrush, pointStringCode[i]);


                }
                else if (i == 1 || i == 11)
                {
                    tmpPointX = pointStringCode[0].X;
                }
                else if (i >= 2 && i <= 5 || i == 10)
                {
                    tmpPointX = pointStringCode[0].X + 25;
                }
                else if (i == 6 || i == 7 || i == 9)
                {
                    tmpPointX = pointStringCode[0].X + 50;
                }
                else
                {
                    tmpPointX = pointStringCode[0].X + 75;
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

        private string[] _addStringCode()
        {
            string[] k =
            {
                "void InsertionSort ( int a[ ], int N )",
                "{",
                "int pos ;",
                "int x ;",
                "for ( int i=1 ; i<N ;         )",
                "{",
                "x = a[ i ] ;",
                "for ( pos=i ; (pos>0) && (a[pos-1]>x ) ;            )",
                "a[pos] = a[pos-1] ;",
                "a[pos] = x ;",
                "}",
                "}",
                " i++",
                "pos - -",
            };
            return k;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Sort.InsertionSort newForm = new InsertionSort();
            newForm.Show();
            this.Dispose(false);
        }

        private void BtnNewTab_Click(object sender, EventArgs e)
        {
            Sort.InsertionSort newForm = new InsertionSort();
            newForm.Show();
        }
    }
     
}
 