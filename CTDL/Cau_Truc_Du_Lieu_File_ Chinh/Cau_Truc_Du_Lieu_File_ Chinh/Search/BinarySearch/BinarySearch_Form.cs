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

namespace BinarySearch_Version2
{
    public partial class BinarySearch_Form : Form
    {
        public BinarySearch_Form()
        {
            InitializeComponent();
            
           
        }
        List<int> a = new List<int>();
            
        #region Code
        string ab = "int binarySearch(int arr[], int l, int r, int x) {";
        string bb = "    if (r >= l) {";
        string cb = "        int mid = l + (r - l) / 2;";
        string db = "        if (arr[mid] == x)";
        string eb = "            return mid;";
        string fb = "        if (arr[mid] > x)";
        string gb = "            return binarySearch(arr, l, mid - 1, x);";
        string hb = "        return binarySearch(arr, mid + 1, r, x); }";
        string mb = "    return -1; }";
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {

            btnSet.Enabled = false;
            btnTim.Enabled = false;
            textBox1.Enabled = false;
        }
        public int Giatri()
        {
            return int.Parse(textBox1.Text);
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            int giatricantim = int.Parse(textBox1.Text);
            List<int> b = new List<int>();
            for (int i = 5; i <= 125; i += 5)
                b.Add(i);
            LoadChu(0);
            BinarySearch(b, 0, 24, giatricantim);

          
        }
        public void LoadArr(List<int> a,int left,int right,int mid,int note)
        {
            #region KhoiTaoGraphics
            Graphics g;
            g = CreateGraphics();
            Pen p_white = new Pen(Color.White, 10);
            Pen p_green = new Pen(Color.Green, 10);
            Pen p_red = new Pen(Color.Red, 10);
            Pen p_black = new Pen(Color.Black, 10);
            Pen p_orange = new Pen(Color.Yellow, 10);
            #endregion
            Point pt1 = new Point();
            Point def = new Point();
            int dem = 0;
            for (int i = 0; i < 25; i++)
            {
                
                
                    pt1.X = 50 + dem;
                    pt1.Y = 300;
                    def.X = 50 + dem;
                    def.Y = 300 - 2 * a[i];
               
               
                if (i == mid)
                {

                    g.DrawLine(p_black, def, pt1);
                    /*LoadChu(2);
                    Thread.Sleep(100);
                    */
                }
                
                
                dem += 15;
                
            }
        }
        public void LoadChu(int vitri)
        {
            Graphics g;
            g = CreateGraphics();
            Font font = new Font("Consolas", 13, FontStyle.Bold);
            for (int i = 0; i < 9; i++)
            {
                if (i == 0)
                    g.DrawString( ab, font, Brushes.Black, 450, 80);
                if (i == 1)
                    g.DrawString(  bb, font, Brushes.Black, 450, 110);
                if (i == 2)
                    g.DrawString(  cb, font, Brushes.Black, 450, 140);
                if (i == 3)
                    g.DrawString(  db, font, Brushes.Black, 450, 170);
                if (i == 4)
                    g.DrawString(  eb, font, Brushes.Black, 450, 200);
                if (i == 5)
                    g.DrawString(  fb, font, Brushes.Black, 450, 230);
                if (i == 6)
                    g.DrawString(  gb, font, Brushes.Black, 450, 260);
                if (i == 7)
                    g.DrawString(  hb, font, Brushes.Black, 450, 290);
                if (i == 8)
                    g.DrawString(  mb, font, Brushes.Black, 450, 320);

            }
            switch (vitri)
            {
                case 0:
                    g.DrawString(ab, font, Brushes.Red, 450, 80);
                    break;
                case 1:
                    g.DrawString(bb, font, Brushes.Red, 450, 110);
                    break;
                case 2:
                    g.DrawString(cb, font, Brushes.Red, 450, 140);
                    break;
                case 3:
                    g.DrawString(db, font, Brushes.Red, 450, 170);
                    break;
                case 4:
                    g.DrawString(eb, font, Brushes.Red, 450, 200);
                    break;
                case 5:
                    g.DrawString(fb, font, Brushes.Red, 450, 230);
                    break;
                case 6:
                    g.DrawString(gb, font, Brushes.Red, 450, 260);
                    break;
                case 7:
                    g.DrawString(hb, font, Brushes.Red, 450, 290);
                    break;
                case 8:
                    g.DrawString(mb, font, Brushes.Red, 450, 320);
                    break;




            }
        }
        public void  BinarySearch(List<int> a,int l,int r,int x)
        {
            /*if (x > 125)
            {
                LoadChu(0); Thread.Sleep(100); LoadChu(1); Thread.Sleep(100); LoadChu(2); Thread.Sleep(100); LoadChu(5); Thread.Sleep(100);

                LoadChu(6); Thread.Sleep(100);
                XoaArr(a, 13, 25,0,126);
                Thread.Sleep(100);

                LoadChu(0); Thread.Sleep(100); LoadChu(1); Thread.Sleep(100);
                LoadChu(8);
                Thread.Sleep(100);
                MessageBox.Show("Khong tim thay gia tri!");
                return -1;
            }
            else*/
            {


                int ret = -1, mid, n = 0;
                LoadChu(0);
                Thread.Sleep(100);
                while (l <= r)
                {
                    LoadChu(1); Thread.Sleep(100);
                    LoadChu(0);
                    mid = (l + r) / 2;
                    VeMid(mid, a[mid]);
                    LoadChu(2);

                    Thread.Sleep(100);

                    if (a[mid] == x)
                    {
                        ret = mid;
                        LoadChu(3);
                        Thread.Sleep(100);
                        LoadChu(4);
                        Tick(mid, a[mid]);
                        break;
                    }
                    else if (a[mid] > x)
                    {

                        LoadChu(5);
                        Thread.Sleep(100);
                        r = mid - 1;
                        LoadChu(6);
                        Thread.Sleep(100);

                        XoaArr(a, l, r, n, mid);
                        Thread.Sleep(100);
                        LoadChu(0);



                    }
                    else
                    {
                        l = mid + 1;
                        LoadChu(5);
                        Thread.Sleep(100);
                        LoadChu(7);
                        Thread.Sleep(100);
                        XoaArr(a, l, r, n, mid);
                        Thread.Sleep(100);

                        LoadChu(0);

                    }

                    Thread.Sleep(100);

                    n++;
                }
                if (ret != -1)
                {
                   // string tmp = ret.ToString();
                   // MessageBox.Show("Tim thay o vi tri " + tmp);
                   // return ret;
                }
                else
                {
                    LoadChu(8);
                    Thread.Sleep(100);
                   // MessageBox.Show("Khong tim thay !");
                    //return ret;
                }
            }
            
        }
        public void XoaArr(List<int> b,int left,int right,int note,int mid)
        {
            #region KhoiTaoGraphics
            Graphics g;
            g = CreateGraphics();
            Pen p_white = new Pen(Color.White, 10);
            Pen p_green = new Pen(Color.Green, 10);
            Pen p_red = new Pen(Color.Red, 10);
            Pen p_black = new Pen(Color.Black, 10);
            Pen p_orange = new Pen(Color.Orange, 10);
            #endregion
            int dem = 0;
            Point pt1 = new Point();
            Point def = new Point();
            for (int i = 0; i < 25; i++)
            {


                pt1.X = 50 + dem;
                pt1.Y = 300;
                def.X = 50 + dem;
                def.Y = 300 - 2 * a[i];


                if (i == mid)
                {

                    g.DrawLine(p_black, def, pt1);
                    

                }


                dem += 15;

            }
            dem = 0;
            if (note == 0)
            {
                for (int i = 0; i < 25; i++)
                {
                    pt1.X = 50 + dem;
                    pt1.Y = 300;
                    def.X = 50 + dem;
                    def.Y = 300 - 2 * b[i];
                    if (i < left)
                    {
                        g.DrawLine(p_white, def, pt1);
                    }
                    else if (i >right)
                    {
                        g.DrawLine(p_white, def, pt1);
                    }
                    if (b[i] == Giatri())
                        g.DrawLine(p_red, def, pt1);
                    
                    dem += 15;

                }
            }
            else
            {
                for (int i = 0; i < 25; i++)
                {
                    pt1.X = 50 + dem;
                    pt1.Y = 300;
                    def.X = 50 + dem;
                    def.Y = 300 - 2 * b[i];
                    if (i < left)
                    {
                        g.DrawLine(p_white, def, pt1);
                    }
                    else if (i > right)
                    {
                        g.DrawLine(p_white, def, pt1);
                    }
                    if (b[i] == Giatri())
                        g.DrawLine(p_red, def, pt1);
                   
                    dem += 15;
                }
            }




        }
        public void Tick(int a,int b)
        {
            #region KhoiTaoGraphics
            Graphics g;
            g = CreateGraphics();
            Pen p_white = new Pen(Color.White, 10);
            Pen p_green = new Pen(Color.Green, 10);
            Pen p_red = new Pen(Color.Red, 10);
            Pen p_black = new Pen(Color.Black, 10);
            Pen p_orange = new Pen(Color.Yellow, 10);
            #endregion
            Point pt1 = new Point();
            Point def = new Point();
            int dem = 0;
            for(int i=0;i<25;i++)
            {
                pt1.X = 50 + dem;
                pt1.Y = 300;
                def.X = 50 + dem;
                def.Y = 300 - 2 * b;
                if(i==a)
                {
                    //for(int j=0;j<100;j++)
                   // {
                        pt1.X = 50 + dem;
                        pt1.Y = 300;
                        def.X = 50 + dem;
                        def.Y = 300 - 2 * b;
                       // g.DrawLine(p_red, def, pt1);
                        //Thread.Sleep(20);
                        g.DrawLine(p_orange, def, pt1);
                        Thread.Sleep(20);
                    //}
                }
                dem += 15;

            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            for (int i = 5; i <= 125; i += 5)
                a.Add(i);
            Graphics g;
            g = CreateGraphics();
            Pen p_white = new Pen(Color.White, 10);
            Pen p_green = new Pen(Color.Green, 10);
            Pen p_red = new Pen(Color.Red, 10);
            Pen p_black = new Pen(Color.Black, 10);

            Point pt1 = new Point();
            Point def = new Point();
            for (int i = 5; i <= 125; i += 5)
                a.Add(i);
            int dem = 0;
            for (int i = 0; i < 25; i++)
            {
                pt1.X = 50 + dem;
                pt1.Y = 300;
                def.X = 50 + dem;
                def.Y = 300 - 2 * a[i];
                
                g.DrawLine(p_green, def, pt1);
                dem += 15;
            }
            LoadChu(-1);
            btnSet.Enabled = true;
            btnTim.Enabled = false;
            textBox1.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            #region KhoiTaoGraphics
            Graphics g;
            g = CreateGraphics();
            Pen p_white = new Pen(Color.White, 10);
            Pen p_green = new Pen(Color.Green, 10);
            Pen p_red = new Pen(Color.Red, 10);
            Pen p_black = new Pen(Color.Black, 10);
            #endregion
            Point pt1 = new Point();
            Point def = new Point();
            for (int i = 5; i <= 125; i += 5)
                a.Add(i);
            int dem = 0;
            for (int i = 0; i < 25; i++)
            {
                pt1.X = 50 + dem;
                pt1.Y = 300;
                def.X = 50 + dem;
                def.Y = 300 - 2 * a[i];
                if (a[i] == int.Parse(textBox1.Text))
                    g.DrawLine(p_red, def, pt1);
                else
                    g.DrawLine(p_green, def, pt1);
                dem += 15;
            }
            btnTim.Enabled = true;
        }
        public void VeMid(int mid, int amid)
        {
            #region KhoiTaoGraphics
            Graphics g;
            g = CreateGraphics();
            Pen p_white = new Pen(Color.White, 10);
            Pen p_green = new Pen(Color.Green, 10);
            Pen p_red = new Pen(Color.Red, 10);
            Pen p_black = new Pen(Color.Black, 10);
            Pen p_orange = new Pen(Color.Yellow, 10);
            #endregion
            Point pt1 = new Point();
            Point def = new Point();
            int dem = 0;
            for (int i = 0; i < 25; i++)
            {


                pt1.X = 50 + dem;
                pt1.Y = 300;
                def.X = 50 + dem;
                def.Y = 300 - 2 * amid;


                if (i == mid)
                {

                    g.DrawLine(p_black, def, pt1);

                }
                dem += 15;
            }
        }
    }
}
