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
    public partial class QuickSort : Form
    {
        public QuickSort()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
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
            _drawStringCode(grap, par, pointStringCode, stringCode);
            _quickSort(grap, par, arr, 0, arr.Count - 1,pointArr, pointStringCode, stringCode);
            function._upDateArrGreen(par, grap,pointArr);

        }

        private void _quickSort(Graphics grap, parameter par,List<int> arr, int left, int right, List<pointStruct> pointStruct, List<Point> pointStringCode, string[] stringCode)
        {
            Function function = new Function();

           

            PointF tmp = new PointF();

            function._flickerFunction(grap, par, pointStringCode, stringCode, 0, 0); 

            int i, j, x;
            function._flickerFunction(grap, par, pointStringCode, stringCode, 2, 0);

            if (left >= right) return;
            function._flickerFunction(grap, par, pointStringCode, stringCode, 3, 0);

            x = arr[(left + right) / 2]; // choïn phaàn töû giöõa laøm giaù trò moác
            function._flickerFunction(grap, par, pointStringCode, stringCode, 4, 0);

            i = left; j = right;
            function._flickerFunction(grap, par, pointStringCode, stringCode, 5, 0);

            function._flickerFunction(grap, par, pointStringCode, stringCode, 6, 0);
            while (i < j)
            {
                function._flickerFunction(grap, par, pointStringCode, stringCode, 7, 0);
                while (arr[i] < x)
                {
                    i++;
                    function._flickerFunction(grap, par, pointStringCode, stringCode, 8, 0); ///gytỵtcfghfyhjfkhjtfkhjfhjgf
                    Thread.Sleep(200);
                    
                }

                function._flickerFunction(grap, par, pointStringCode, stringCode, 10, 0);
                while (arr[j] > x)
                {
                    j--;
                    function._flickerFunction(grap, par, pointStringCode, stringCode, 11, 0);
                    Thread.Sleep(200);
                }

                function._flickerFunction(grap, par, pointStringCode, stringCode, 13, 0);
                if (i <= j)
                {
                    grap.DrawLine(par.RedPen, pointStruct[i].point1, pointStruct[i].point2);
                    grap.DrawLine(par.RedPen, pointStruct[j].point1, pointStruct[j].point2);

                    Thread.Sleep(200);

                    par.WhitePen.Width = par.BlackPen.Width;
                    tmp = pointStruct[i].point1;  tmp.Y += 20;
                    grap.DrawLine(par.WhitePen, tmp, pointStruct[i].point2);

                    tmp = pointStruct[j].point1; tmp.Y += 20;
                    grap.DrawLine(par.WhitePen, tmp, pointStruct[j].point2);

                    Thread.Sleep(100);

                     
                    function._Swap(arr, pointStruct, i, j);
                    function._flickerFunction(grap, par, pointStringCode, stringCode, 14, 0);

                    grap.DrawLine(par.BlackPen, pointStruct[i].point1, pointStruct[i].point2);
                    grap.DrawLine(par.BlackPen, pointStruct[j].point1, pointStruct[j].point2);
                    function.veLaiTrongSo(grap, par, arr, pointStruct, i, j);


                    //Swap(arr[i], arr[j]);
                    i++; j--;
                    function._flickerFunction(grap, par, pointStringCode, stringCode, 15, 0);
                }
            }

            function._flickerFunction(grap, par, pointStringCode, stringCode, 18, 0);
            _quickSort(grap, par, arr, left, j, pointStruct, pointStringCode, stringCode);

            function._flickerFunction(grap, par, pointStringCode, stringCode, 19, 0);
            _quickSort(grap, par, arr, i, right, pointStruct, pointStringCode, stringCode);

        }

      
        private void _drawStringCode(Graphics grap, parameter par,List<Point> pointStringCode, string[] stringCode)
        {
            Function f = new Function();
            DrawSort drawSort = new DrawSort();

            if (pointStringCode.Count==21)
            {
                for(int i=0; i<pointStringCode.Count; i++)
                {
                    grap.DrawString(stringCode[i], drawSort.DrawFont2, drawSort.DrawBlackBrush, pointStringCode[i]);
                }
                return;
            }


            f._drawStringCode_Tho(grap, pointStringCode, stringCode, 20);

             
        } 
        private string[] _addStringCode()
        {
            string[] k = new string[]
            {
                "void QuickSort (int a [ ], int left, int right )",
                "{",
                "     int i, j, x ;",
                "     if ( left >= right ) return;",
                "     x = a [ ( left + right ) / 2 ] ;",
                "     i = left; j = right;",
                "     while ( i < j ) {",
                "         while ( a[i] < x ) {",
                "               i++",
                "         }",
                "         while ( a[j] > x ){",
                "               j - -",
                "         }",
                "         if ( i <= j ) {",
                "               Swap ( a[i], a[j] ) ;",
                "               i++ ; j--; ",
                "         }",
                "     }",
                "     QuickSort ( a, left, j ) ;",
                "     QuickSort ( a, i, right ) ;",
                "}", 
            };
            return k;
        }
     }
}
