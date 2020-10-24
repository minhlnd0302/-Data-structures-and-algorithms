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

namespace SimpleSearch
{
    public partial class LinearSearch : Form
    {
        public LinearSearch()
        {
            InitializeComponent();
        }
        List<int> b = new List<int>();
        string a1 = "int LinearSearch(int a[], int N, int x) {";
        string a2 = "   a[N] = x;";
        string a3 = "   for (int i=0; (a[i]!=x); i++) ";
        string a4 = "       if (i<N)";
        string a5 = "           return i;";
        string a6 = "   return -1; }";
        Graphics g;
        Pen p_white = new Pen(Color.White, 20);
        Pen p_green = new Pen(Color.YellowGreen, 20);
        Pen p_red = new Pen(Color.Red, 20);
        Pen p_black = new Pen(Color.Black, 20);
        Pen p_orange = new Pen(Color.Blue, 20);
        Pen p_xx = new Pen(Color.DarkGreen, 20);
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            btnTim.Enabled = true;
            textBox1.Enabled = true;
            btnLoad.Enabled = false;
            Random rnd = new Random();
            for (int i = 1; i <= 15; i++)
                b.Add(rnd.Next(10,100));

            VeSo();


            g = CreateGraphics();
           
    
            Point pt1 = new Point();
            Point def = new Point();
            int dem = 0;
            for(int i=0;i<15;i++)
            {
                pt1.X = 50 + dem;
                pt1.Y = 300;
                def.X = 50 + dem;
                def.Y = 300 - 2 * b[i];


                g.DrawLine(p_black, def, pt1);
                dem += 23;
            }
        }
        public void Swap(List<int> a,int l,int r)
        {
            int tmp = a[l];
            a[l] = a[r];
            a[r] = tmp;
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {


            LoadChu(-1);
            veDiemcantim(b, int.Parse(textBox1.Text));
           
            Thread.Sleep(200);
            LoadChu(0);
            Thread.Sleep(200);
            b.Add(int.Parse(textBox1.Text));
            LoadChu(1);
            Thread.Sleep(1000);

            Velinhcanh(b, int.Parse(textBox1.Text));
            LoadChu(2);
            Thread.Sleep(2000);

            bool tf = false;

            for (int i = 0; i <= 15; i++)
            {
                
                LoadChu(2);
                UpdateMang(b, int.Parse(textBox1.Text), i);
                Thread.Sleep(1000);
                
                LoadChu(3);
                Thread.Sleep(1000);

                if (b[i] == int.Parse(textBox1.Text) && i != 15)
                {
                    NhapNhay(i, b[i]);
                    LoadChu(4);
                    break;
                }
                else if (b[i] == int.Parse(textBox1.Text) && i == 15)
                {
                    LoadChu(5);
                    MessageBox.Show("Không tìm thấy!");
                }
                 
            }
        }
       
        public void veDiemcantim(List<int> a,int x)
        {
          
            g = CreateGraphics();
            
            Point pt1 = new Point();
            Point def = new Point();
            int dem = 0;
            for (int i = 0; i< 15;i++)
            {
                pt1.X = 50 + dem;
                pt1.Y = 300;
                def.X = 50 + dem;
                def.Y = 300 - 2 * a[i];
                if (a[i] == x)
                    g.DrawLine(p_orange, def, pt1);


                dem += 23;
            }
        }
        public void UpdateMang(List<int> a,int x,int k)
        {
          
            
            g = CreateGraphics();
           
            Point pt1 = new Point();
            Point def = new Point();
            int dem = 0;
            for (int i = 0; i <= k; i++)
            {
                pt1.X = 50 + dem;
                pt1.Y = 300;
                def.X = 50 + dem;
                def.Y = 300 - 2 * a[i];
                /*if (a[i] == x)
                    NhapNhay(i, a[i]);*/
                if (i == k)
                    g.DrawLine(p_green, def, pt1);
                else
                    g.DrawLine(p_black, def, pt1);

                dem += 23;
            }
            
        }
        public void NhapNhay(int a,int b)
        {
           

            Point pt1 = new Point();
            Point def = new Point();
            int dem = 0;
            for (int i = 0; i <15; i++)
            {
                pt1.X = 50 + dem;
                pt1.Y = 300;
                def.X = 50 + dem;
                def.Y = 300 - 2 * b;
                if(i==a)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        g.DrawLine(p_orange, def, pt1);
                        Thread.Sleep(5);
                        g.DrawLine(p_red, def, pt1);
                        Thread.Sleep(5);

                    }
                    
                }


                dem += 23;
            }
            //MessageBox.Show("Da tim thay!");
        }
        public void LoadChu(int vitri)
        {
            
            g = CreateGraphics();
            Font font = new Font("Consolas", 13, FontStyle.Bold);
            for (int i = 0; i <= 5; i++)
            {
                if (i == 0)
                    g.DrawString(a1, font, Brushes.Black, 450, 80);
                if (i == 1)
                    g.DrawString(a2, font, Brushes.Black, 450, 110);
                if (i == 2)
                    g.DrawString(a3, font, Brushes.Black, 450, 140);
                if (i == 3)
                    g.DrawString(a4, font, Brushes.Black, 450, 170);
                if (i == 4)
                    g.DrawString(a5, font, Brushes.Black, 450, 200);
                if (i == 5)
                    g.DrawString(a6, font, Brushes.Black, 450, 230);
            }
            switch (vitri)
            {
                case 0:
                    g.DrawString(a1, font, Brushes.Red, 450, 80);
                    break;
                case 1:
                    g.DrawString(a2, font, Brushes.Red, 450, 110);
                    break;
                case 2:
                    g.DrawString(a3, font, Brushes.Red, 450, 140);
                    break;
                case 3:
                    g.DrawString(a4, font, Brushes.Red, 450, 170);
                    break;
                case 4:
                    g.DrawString(a5, font, Brushes.Red, 450, 200);
                    break;
                case 5:
                    g.DrawString(a6, font, Brushes.Red, 450, 230);
                    break;
                default:
                    g.DrawString(a1, font, Brushes.Black, 450, 80);
                    break;

            }
        }
        public void Velinhcanh(List<int> a,int x)
        {
            g = CreateGraphics();
            Font font = new Font("Consolas", 10);
            Point pt1 = new Point();
            Point def = new Point();
            int dem = 0;
            for (int i = 0; i <= 15; i++)
            {
                pt1.X = 50 + dem;
                pt1.Y = 300;
                def.X = 50 + dem;
                def.Y = 300 - 2 * a[i];
                if (a[i] == x && i == 15)
                {
                    g.DrawLine(p_xx, def, pt1);
                    g.DrawString(x.ToString(), font, Brushes.Black, pt1.X-10,pt1.Y);
                }

                dem += 23;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTim.Enabled = false;
            textBox1.Enabled = false;
        }
        private void VeSo()
        {
            Font font = new Font("Consolas", 10);
            g = CreateGraphics();
            Point pt1 = new Point();
            Point def = new Point();
            int dem = 0;
            for (int i = 0; i < 15; i++)
            {
                pt1.X = 50 + dem-10;
                pt1.Y = 300;
                def.X = 50 + dem;
                def.Y = 300 - 2 * b[i];
                g.DrawString(b[i].ToString(), font,Brushes.Black, pt1);


                dem += 23;
            }

        }
    }
}
