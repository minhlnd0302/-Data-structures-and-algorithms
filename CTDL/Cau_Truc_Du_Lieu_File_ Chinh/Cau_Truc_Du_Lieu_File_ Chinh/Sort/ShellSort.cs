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
    public partial class ShellSort : Form
    {
        public ShellSort()
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
            Int32.TryParse(txbNumber.Text, out numberOfElements);
            if (numberOfElements == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng phần tử hợp lệ !", "Lưu ý !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            parameter par = new parameter(numberOfElements);
            Function function = new Function();
            function._ranDumArr(arr, numberOfElements);
            function._drawArr_Weight(grap, par, arr, pointArr);
            _drawStringCode(grap, pointStringCode, stringCode);
            _shellSort(grap, par, pointArr, pointStringCode, stringCode, arr);
            function._upDateArrGreen(par, grap, pointArr);
            //int k = 0;
        }

        private bool checkSNT (int n)
        {
            if (n == 1) return true;
            if (n < 3) return false;
            for(int i=2; i*i<=n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        private List<int> createArrLen(int n)
        {
            List<int> arr = new List<int>();
            for(int i=1; i<n; i++)
            {
                if (checkSNT(i))
                {
                    if (i <= (n * 0.75))
                    {
                        arr.Add(i);
                    }
                }
            }
            arr.Reverse();
            return arr; 
        }

        private void _shellSort(Graphics grap, parameter par, List<pointStruct> pointStructArr, List<Point> pointStringCode, string[] stringCode, List<int> arr)
        {
            int N = arr.Count;
            List<int> h = createArrLen(N);
            int k = h.Count; 
            
            Function function = new Function();

            function._flickerFunction(grap, par, pointStringCode, stringCode, 0, 0);
            function._flickerFunction(grap, par, pointStringCode, stringCode, 1, 0);

            function._flickerFunction(grap, par, pointStringCode, stringCode, 3, 0);
            int step, i, pos, x, len;

            function._flickerFunction(grap, par, pointStringCode, stringCode, 4, 16);
            for (step = 0; step < k; step++)
            {
                if (step != 0) { function._flickerFunction(grap, par, pointStringCode, stringCode, 16, -1); }

                len = h[step]; //khoaûng caùch 2 phaàn töû lieân tieáp cuûa daõy con
                function._flickerFunction(grap, par, pointStringCode, stringCode, 6, 0);

                function._flickerFunction(grap, par, pointStringCode, stringCode, 7, 17);
                for (i = len; i < N; i++)
                {
                    
                    
                    if (i != len) function._flickerFunction(grap, par, pointStringCode, stringCode,17 , -1);

                    x = arr[i];
                    function._flickerFunction(grap, par, pointStringCode, stringCode, 9, 0);


                    function._flickerFunction(grap, par, pointStringCode, stringCode, 10, 18);
 
                     

                    for (pos = i; (pos - len >= 0) && (x < arr[pos - len]); pos -= len)
                    {
                        int tmp;

                        if (pos != i) function._flickerFunction(grap, par, pointStringCode, stringCode, 18, -1);

                        grap.DrawLine(par.RedPen, pointStructArr[pos].point1, pointStructArr[pos].point2);
                        grap.DrawLine(par.RedPen, pointStructArr[pos - len].point1, pointStructArr[pos - len].point2);

                        Thread.Sleep(300);

                        par.WhitePen.Width = par.BlackPen.Width;
                        grap.DrawLine(par.WhitePen, pointStructArr[pos].point1.X, pointStructArr[pos].point1.Y + 20, pointStructArr[pos].point2.X, pointStructArr[pos].point2.Y);
                        grap.DrawLine(par.WhitePen, pointStructArr[pos-len].point1.X, pointStructArr[pos-len].point1.Y + 20, pointStructArr[pos-len].point2.X, pointStructArr[pos-len].point2.Y);

                        function._SwapPointArr(pointStructArr, pos, pos - len);
                        tmp = arr[pos];
                        arr[pos] = arr[pos - len];
                        function._flickerFunction(grap, par, pointStringCode, stringCode, 11, 0);

                        grap.DrawLine(par.BlackPen, pointStructArr[pos].point1, pointStructArr[pos].point2);
                        veSo(grap, par, arr, pointStructArr, tmp, pos - len);
                         
                        grap.DrawLine(par.BlackPen, pointStructArr[pos - len].point1, pointStructArr[pos - len].point2);
                        veSo(grap, par, arr, pointStructArr, arr[pos-len], pos);
                    
                    }
                      
                    arr[pos] = x; 
                    function._flickerFunction(grap, par, pointStringCode, stringCode, 12, 0);

                    grap.DrawLine(par.BlackPen, pointStructArr[i].point1, pointStructArr[i].point2);
                    grap.DrawLine(par.BlackPen, pointStructArr[i - len].point1, pointStructArr[i - len].point2);
                }
            } 
        }

        private void veSo (Graphics grap, parameter par, List<int> arr, List<pointStruct> pointStructArr, int t, int vtri )
        {
            if (par.NumberOfElements > 25) return;

            float x1 = pointStructArr[vtri].point1.X - 5;
            float x2 = pointStructArr[vtri].point1.X - 9;
           
            grap.DrawString(t.ToString(), par.DrawFont, par.DrawBlackBrush, t < 10 ? x1 : x2, pointStructArr[vtri].point1.Y + 0.45f);
           
        }
         
        private void _drawStringCode(Graphics grap, List<Point> pointStringCode, string[] stringCode)
        {
            DrawSort drawCode = new DrawSort();
            Point pointCode = new Point();
            pointCode.X = 700;
            pointCode.Y = 20;
            pointStringCode.Add(pointCode);

            int tmpPointX = new int();
            for (int i = 0; i < 19; i++)
            {
                if(i>15)
                {
                    if (i == 16)
                    {
                        pointCode = pointStringCode[4];
                        pointCode.X += 168;
                    }
                    else if(i == 17)
                    {
                        pointCode = pointStringCode[7];
                        pointCode.X += 132;
                    }
                    else if (i == 18)
                    {
                        pointCode = pointStringCode[10];
                        pointCode.X += 380;
                    }
                    pointStringCode.Add(pointCode);
                }
                else
                {
                    if (i == 1 || i == 2 || i == 15)
                    {
                        tmpPointX = pointStringCode[0].X;
                    }
                    else if (i >= 3 && i <= 5 || i == 14)
                    {
                        tmpPointX = pointStringCode[0].X + 25;
                    }
                    else if (i >= 6 && i <= 8 || i == 13)
                    {
                        tmpPointX = pointStringCode[0].X + 50;
                    }
                    else if (i == 9 || i == 10 || i == 12)
                    {
                        tmpPointX = pointStringCode[0].X + 75;
                    }
                    else if (i == 11)
                    {
                        tmpPointX = pointStringCode[0].X + 100;
                    }
                     
                    pointCode.X = tmpPointX;
                    pointCode.Y = i * 25 + 20;

                    if (i > 0) { pointStringCode.Add(pointCode); }
                     
                }
                grap.DrawString(stringCode[i], drawCode.DrawFont2, drawCode.DrawBlackBrush, pointStringCode[i]); 
            }
        }
        private string[] _addStringCode()
        {
            string[] k = new string[]
            {
                "int h [ MAXK ] , k ",                "void ShellSort ( int a [ ] , int N)",                "{",
                "int step, i, pos, x, len ;",
                "for ( step = 0 ; step < k ;              )",
                "{",
                "len = h [ step ] ;",
                "for ( i = len ; i < N ;         )",
                "{",
                "x = a [ i ]",
                "for ( pos = i ; ( pos - len >= 0 ) && ( x < a [ pos-len ] );                    )",
                "a [ pos ] = a [ pos-len ] ;",
                "a [ pos ] = x;",
                "}",
                "}",
                "}",
                "step ++",
                "i++",
                "pos - = len"
            };
            return k;
        } 
    }
}
