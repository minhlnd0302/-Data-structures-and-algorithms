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
    public partial class HeapSort : Form
    {
        public HeapSort()
        {
            InitializeComponent();
        }

        List<int> arr /*= new List<int>()*/;


        List<Point> pointStringCodeShift = new List<Point>();
        List<Point> pointStringCodeCreateHeap = new List<Point>();
        List<Point> pointStringCodeHeapSort = new List<Point>();

        List<Point> pointLineArr = new List<Point>();  // lưu mảng vãng ngang
        List<Point> pointLineArrbd = new List<Point>();
        List<Point> pointTreeArr = new List<Point>();  // luu mảng cây
        List<pointStruct> pointArrow = new List<pointStruct>();

        public string[] stringCodeShift = new string[] { };
        public string[] stringCodeCreateHeap = new string[] { };
        public string[] stringCodeHeapSort = new string[] { };

        //List<Point> copyPointLineArr(List<Point> arr)
        //{

        //}
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            parameter par = new parameter();
            Graphics grap = CreateGraphics();

            arr = _ranDomArr();

            stringCodeShift = _addStringCodeShift();
            stringCodeCreateHeap = _addStringCodeCreateHeap();
            stringCodeHeapSort = _addStringCodeHeapSort();

            //par.RedPen.Width = 5;
            //grap.FillEllipse(par.DrawRedBrush, rnd.Next(0,500), rnd.Next(0, 500), 40, 40);
            
            _drawLineArr(grap, pointLineArr, arr);
           
            

            _drawTreeArr(grap, pointTreeArr, arr);
            _drawArrow(pointTreeArr, pointArrow, grap);

            //Thread.Sleep(15000);
            __heapSort(arr, 11, grap, par);

         

        }

        private void __heapSort(List<int> a, int N, Graphics grap, parameter par)
        {
            int max = 10;
            for(int i=0; i<a.Count; i++)
            {
                grap.FillEllipse(Brushes.White, pointLineArr[i].X, pointLineArr[i].Y, 40, 40);
            }

            _drawArrBD(grap, arr);

            par.WhitePen.Color = Color.MediumSeaGreen; // doi mau but

            _drawStringCodeFuntionHeapSort(grap);
            Function function = new Function();
            function._flickerFunction(grap, par, pointStringCodeHeapSort, stringCodeHeapSort, 0, 0);


            int right;
            function._flickerFunction(grap, par, pointStringCodeHeapSort, stringCodeHeapSort, 2, 0);


            function._flickerFunction(grap, par, pointStringCodeHeapSort, stringCodeHeapSort, 3, 0);

            _DeleteCode(grap);
            __CreateHeap(a, N, grap, par); //saép xeáp daõy a thanh heap

            _drawStringCodeFuntionHeapSort(grap);

            right = N - 1; // right laø vò trí ñuùng cho phaàn töû lôùn nhaát
            function._flickerFunction(grap, par, pointStringCodeHeapSort, stringCodeHeapSort, 4, 0);

            function._flickerFunction(grap, par, pointStringCodeHeapSort, stringCodeHeapSort, 5, 0);
            while (right > 0)
            {
                Thread.Sleep(1000);
                __Swap(arr, 0, right);
                function._flickerFunction(grap, par, pointStringCodeHeapSort, stringCodeHeapSort, 7, 0);

                grap.FillEllipse(Brushes.Red, pointTreeArr[0].X, pointTreeArr[0].Y, 40, 40);

                grap.FillEllipse(Brushes.Red, pointTreeArr[right].X, pointTreeArr[right].Y, 40, 40);

                Thread.Sleep(300);
                 
                grap.FillEllipse(Brushes.White, pointTreeArr[0].X, pointTreeArr[0].Y, 40, 40);
                _drawValue(grap, _editValue(pointTreeArr[0], arr[0]), arr[0]);


                Thread.Sleep(200);

                grap.FillEllipse(Brushes.Yellow, pointLineArr[max].X, pointLineArr[max].Y, 40, 40);
                _drawValue(grap,_editValue(pointLineArr[max],arr[right]), arr[right]);

                // can lam

                grap.FillEllipse(Brushes.MediumSeaGreen, pointTreeArr[right].X, pointTreeArr[right].Y, 40, 40);
                
                Pen newPen = new Pen(Brushes.MediumSeaGreen, 5);

                grap.DrawEllipse(newPen, pointTreeArr[right].X, pointTreeArr[right].Y, 40, 40);
                grap.DrawLine(newPen, pointArrow[right - 1].point1, pointArrow[right - 1].point2);

                max--;
               

                right--;
                function._flickerFunction(grap, par, pointStringCodeHeapSort, stringCodeHeapSort, 8, 0);

                function._flickerFunction(grap, par, pointStringCodeHeapSort, stringCodeHeapSort, 9, 0);
               // _DeleteCode(grap);
                // _drawStringCodeFunctionShift(grap);
                __Shift(a, 0, right, grap, par);
                //_drawStringCodeFuntionHeapSort(grap);

            }

            grap.FillEllipse(Brushes.Yellow, pointLineArr[max].X, pointLineArr[max].Y, 40, 40);
            _drawValue(grap, _editValue(pointLineArr[0], arr[right]), arr[0]);
 

        }

        private void __Swap(List<int> arr, int k, int right)
        {
            int tmp;
            tmp = arr[k];
            arr[k] = arr[right];
            arr[right] = tmp;
        }

        private void __Shift(List<int> arr, int left, int right, Graphics grap, parameter par)
        {
           
            int tmp = new int();
            int tmp2 = new int();
            DrawSort drawSort = new DrawSort();
            drawSort.RedPen.Width = 4; 
            drawSort.WhitePen.Width = 4;


            int x, curr, joint;
            curr = left; joint = 2 * curr + 1;
            x = arr[curr];
             

            while (joint <= right)
            {
                List<int> tmpArr = new List<int>(arr);
                if (joint < right)
                {
                    if (arr[joint] < arr[joint + 1])
                    {
                        joint = joint + 1;
                        tmp = joint;
                        tmp2 = curr;
                       

                    }
                }
                if (arr[joint] < x) {
                    
                    break;
                }


               
                int k = arr[joint];
                arr[curr] = arr[joint];

                if (!ktMangTrung(arr, tmpArr))
                {
                    grap.DrawEllipse(drawSort.RedPen, pointTreeArr[joint].X, pointTreeArr[joint].Y, 40, 40);
                    grap.DrawEllipse(drawSort.RedPen, pointTreeArr[curr].X, pointTreeArr[curr].Y, 40, 40);

                    // ra roi
                    Thread.Sleep(1000);

                    grap.DrawEllipse(drawSort.WhitePen, pointTreeArr[curr].X, pointTreeArr[curr].Y, 40, 40);
                    grap.FillEllipse(Brushes.White, pointTreeArr[curr].X, pointTreeArr[curr].Y, 40, 40);
                    _drawValue(grap, _editValue(pointTreeArr[curr], arr[curr]), arr[curr]);

                    grap.DrawEllipse(drawSort.WhitePen, pointTreeArr[joint].X, pointTreeArr[joint].Y, 40, 40);
                    grap.FillEllipse(Brushes.White, pointTreeArr[joint].X, pointTreeArr[joint].Y, 40, 40);
                   
                    _drawValue(grap, _editValue(pointTreeArr[joint], x), x);
                     

                }

                Thread.Sleep(500);

                curr = joint;
                joint = 2 * curr + 1; 
                 
            }

           

            arr[curr] = x;

            
        }

        private bool ktMangTrung(List<int>a, List<int> b)
        {
            for(int i=0; i<a.Count; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true;
        }
         

        private void __CreateHeap(List<int> arr, int N, Graphics grap, parameter par)
        {
            _DeleteCode(grap);
            _drawStringCodeFunctionCreateHeap(grap);
            Thread.Sleep(500);
            Function function = new Function();
            function._flickerFunction(grap, par, pointStringCodeCreateHeap, stringCodeCreateHeap, 0, 0);

            int left;
            function._flickerFunction(grap, par, pointStringCodeCreateHeap, stringCodeCreateHeap, 2, 0);

            //left: vị trí phần tử cần ghép thêm
            function._flickerFunction(grap, par, pointStringCodeCreateHeap, stringCodeCreateHeap, 3, 6);
            for (left = (N - 1) / 2; left >= 0; left--)
            {
                //_drawStringCodeFunctionCreateHeap(grap);
                if (left != (N - 1) / 2) { function._flickerFunction(grap, par, pointStringCodeCreateHeap, stringCodeCreateHeap, 3, 6); }

                function._flickerFunction(grap, par, pointStringCodeCreateHeap, stringCodeCreateHeap, 4, 0);
                Thread.Sleep(300);
               // _DeleteCode(grap);

                __Shift(arr, left, N - 1, grap, par);

            }
            _DeleteCode(grap);
        }


        private void _drawArrow(List<Point> pointTreeArr, List<pointStruct> pointStructArrow, Graphics grap)
        {
            int tmp = 1;
            parameter par = new parameter();
            par.BlackPen.Width = 2;
            pointStruct k = new pointStruct();

            for (int i = 0; i < 5; i++)
            {
                k = _editArrow(pointTreeArr[i], pointTreeArr[tmp]);
                grap.DrawLine(par.BlackPen, k.point1, k.point2);
                pointStructArrow.Add(k);

                k = _editArrow(pointTreeArr[i], pointTreeArr[tmp + 1]);
                grap.DrawLine(par.BlackPen, k.point1, k.point2);
                pointStructArrow.Add(k);

                tmp += 2;
            }
        }

        private pointStruct _editArrow(Point k, Point h)
        {
            if (k.X > h.X)
            {
                k.Y += 40 - 4;
                k.X += 4;
                h.X += 40 - 4;
                h.Y += 4;
            }
            else
            {
                k.Y += 40 - 5;
                k.X += 40 - 5;
                h.Y += 4;
                h.X += 4;
            }
            pointStruct m = new pointStruct(k, h);
            return m;
        }
        private void _drawValue(Graphics grap, PointF k, int i)
        {
            parameter par = new parameter();
            grap.DrawString(i.ToString(), par.DrawFont, par.DrawBlackBrush, k);
        }

        private void _drawLineArr(Graphics grap, List<Point> pointLineArr, List<int> arr)
        {
            Point k = new Point(40, 30);

            for (int i = 0; i < 11; i++)
            {
                pointLineArr.Add(k);
                grap.FillEllipse(Brushes.White, pointLineArr[i].X, pointLineArr[i].Y, 40, 40);

                _drawValue(grap, _editValue(pointLineArr[i], arr[i]), arr[i]);
                k.X += 50;
            } 
        }

        private void _drawArrBD(Graphics grap, List<int> arr)
        {
            Point tmp = new Point(); 

            for(int i=0; i<pointLineArr.Count; i++)
            {
                tmp = pointLineArr[i];

                tmp.Y += 430;

                grap.FillEllipse(Brushes.White, tmp.X, tmp.Y, 40, 40);

                _drawValue(grap, _editValue(tmp, arr[i]), arr[i]);
            }
        }

        private void _drawTreeArr(Graphics grap, List<Point> pointTreeArr, List<int> arr)
        {
            Point tmp = new Point(400, 100);
            pointTreeArr.Add(tmp);
            grap.FillEllipse(Brushes.White, tmp.X, tmp.Y, 40, 40);
            _drawValue(grap, _editValue(pointTreeArr[0], arr[0]), arr[0]);

            for (int i = 1; i < 11; i++)
            {
                switch (i)
                {
                    case 1:
                        tmp.X = pointTreeArr[0].X - 140;
                        tmp.Y = pointTreeArr[0].Y + 90;
                        break;
                    case 2:
                        tmp.X = pointTreeArr[0].X + 140;
                        break;
                    case 3:
                        tmp.X = pointTreeArr[1].X - 120;
                        tmp.Y = pointTreeArr[1].Y + 90;
                        break;
                    case 4:
                        tmp.X = pointTreeArr[1].X + 120;
                        break;
                    case 5:
                        tmp.X = pointTreeArr[2].X - 75;
                        tmp.Y = pointTreeArr[2].Y + 80;
                        break;
                    case 6:
                        tmp.X = pointTreeArr[2].X + 75;
                        break;
                    case 7:
                        tmp.X = pointTreeArr[3].X - 80;
                        tmp.Y = pointTreeArr[3].Y + 90;
                        break;
                    case 8:
                        tmp.X = pointTreeArr[3].X + 80;
                        break;
                    case 9:
                        tmp.X = pointTreeArr[4].X - 80;
                        break;
                    case 10:
                        tmp.X = pointTreeArr[4].X + 80;
                        break;
                }
                pointTreeArr.Add(tmp);
                grap.FillEllipse(Brushes.White, pointTreeArr[i].X, pointTreeArr[i].Y, 40, 40);
                _drawValue(grap, _editValue(pointTreeArr[i], arr[i]), arr[i]);
            }
        }

        private PointF _editValue(PointF k, int i)
        {
            k.X = (i < 10 ? 15 : 12) + k.X;
            k.Y += 12;
            return k;
        }

        private List<int> _ranDomArr()
        {
            List<int> arr = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 11; i++)
            {
                arr.Add(rnd.Next(1, 100));
            }
            return arr;
        }

        private void _drawStringCodeFunctionCreateHeap(Graphics grap)
        {
            DrawSort drawCode = new DrawSort();

            if (pointStringCodeCreateHeap.Count == 0)
            {
                Point pointCode = new Point();
                pointCode.X = 750;
                pointCode.Y = 20;
                pointStringCodeCreateHeap.Add(pointCode);

                int tmpPointX = new int();

                for (int i = 0; i < 7; i++)
                {
                    if (i > 5)
                    {
                        pointCode = pointStringCodeCreateHeap[3];
                        pointCode.X += 220;
                        pointStringCodeCreateHeap.Add(pointCode);
                    }
                    else
                    {
                        if (i == 1 || i == 5)
                        {
                            tmpPointX = pointStringCodeCreateHeap[0].X;
                        }
                        else if (i == 2 || i == 3)
                        {
                            tmpPointX = pointStringCodeCreateHeap[0].X + 25;
                        }
                        else if (i == 4)
                        {
                            tmpPointX = pointStringCodeCreateHeap[0].X + 50;
                        }

                        pointCode.X = tmpPointX;
                        pointCode.Y = i * 25 + 20;

                        if (i > 0) { pointStringCodeCreateHeap.Add(pointCode); }
                    }

                }

            }
            for (int i = 0; i < 7; i++)
            {
                grap.DrawString(stringCodeCreateHeap[i], drawCode.DrawFont2, drawCode.DrawBlackBrush, pointStringCodeCreateHeap[i]);
            }
        }

        private void _drawStringCodeFunctionShift(/*List<Point> pointStringCode, string[] arrStringCode,*/ Graphics grap)
        {
            DrawSort drawCode = new DrawSort();

            if (pointStringCodeShift.Count == 0)
            {
                Point pointCode = new Point();
                pointCode.X = 750;
                pointCode.Y = 20;
                pointStringCodeShift.Add(pointCode);

                int tmpPointX = new int();

                for (int i = 0; i < 17; i++)
                {
                    if (i == 1 || i == 16)
                    {
                        tmpPointX = pointStringCodeShift[0].X;
                    }
                    else if (i >= 2 && i <= 6 || i == 14 || i == 15)
                    {
                        tmpPointX = pointStringCodeShift[0].X + 25;
                    }
                    else if (i == 7 || i >= 10 && i <= 13)
                    {
                        tmpPointX = pointStringCodeShift[0].X + 50;
                    }
                    else if (i == 8)
                    {
                        tmpPointX = pointStringCodeShift[0].X + 75;
                    }
                    else if (i == 9)
                    {
                        tmpPointX = pointStringCodeShift[0].X + 100;
                    }
                    pointCode.X = tmpPointX;
                    pointCode.Y = i * 25 + 20;

                    if (i > 0)
                    {
                        pointStringCodeShift.Add(pointCode);

                    }
                }
            }

            for (int i = 0; i < 17; i++)
            {
                grap.DrawString(stringCodeShift[i], drawCode.DrawFont2, drawCode.DrawBlackBrush, pointStringCodeShift[i]);
            }
        }

        private void _drawStringCodeFuntionHeapSort(Graphics grap)
        {
            DrawSort drawCode = new DrawSort();

            if (pointStringCodeHeapSort.Count == 0)
            {
                Point pointCode = new Point();
                pointCode.X = 750;
                pointCode.Y = 20;
                pointStringCodeHeapSort.Add(pointCode);

                int tmpPointX = new int();

                for (int i = 0; i < 12; i++)
                {
                    if (i == 1 || i == 11)
                    {
                        tmpPointX = pointStringCodeHeapSort[0].X;
                    }
                    else if (2 <= i && i <= 6 || i == 10)
                    {
                        tmpPointX = pointStringCodeHeapSort[0].X + 25;
                    }
                    else if (i < 10 && i > 6)
                    {
                        tmpPointX = pointStringCodeHeapSort[0].X + 50;
                    }

                    pointCode.X = tmpPointX;
                    pointCode.Y = i * 25 + 20;

                    if (i > 0)
                    {
                        pointStringCodeHeapSort.Add(pointCode);
                    }
                }
            }

            for (int i = 0; i < 12; i++)
            {
                grap.DrawString(stringCodeHeapSort[i], drawCode.DrawFont2, drawCode.DrawBlackBrush, pointStringCodeHeapSort[i]);
            }
        }

        private string[] _addStringCodeCreateHeap()
        {
            string[] stringCode = new string[]
            {
                "void CreateHeap ( int a [ ], int N )",
                "{",
                "int left ;",
                "for ( left = ( N-1 ) / 2 ; left >= 0 ;            )",
                "Shift ( a, left, N-1);",
                "}",
                "left - -"
            };
            return stringCode;
        }

        private string[] _addStringCodeShift()
        {
            string[] stringCode = new string[]
            {
                "void Shift ( int a [ ], int left, int right)",
                "{",
                "int x, curr, joint;",
                "curr = left;   joint =2*curr+1;",
                "x = a [ curr ] ;",
                "while ( joint <= right )",
                "{",
                "if ( joint < right )",
                "if ( a [ joint ] < a [ joint + 1] )",
                "joint = joint + 1;",
                "if ( a [ joint ] < x) break;",
                "a [ curr ] = a [ joint ] ;",
                "curr = joint ;",
                "joint = 2 * curr + 1 ;",
                "}",
                "a [ curr ] = x ;",
                "}"
            };
            return stringCode;
        }

        private string[] _addStringCodeHeapSort()
        {
            string[] k = new string[]
            {
                "void HeapSort ( int a [ ] , int N)",
                "{",
                "int right ;",
                "CreateHeap ( a , N ) ;",
                "right = N - 1 ;",
                "while ( right > 0 )",
                "{",
                "Swap ( a [ 0 ] , a [ right ] ) ;",
                "right - -;",
                "Shift ( a, 0, right ) ;",
                "}",
                "}"
            };
            return k;
        }

        private void _DeleteCode(Graphics grap)
        {
            grap.FillRectangle(Brushes.MediumSeaGreen, 750, 15, 300, 480);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            HeapSort f = new HeapSort();
            f.Show();
            this.Dispose(false);
        }
    }
}
