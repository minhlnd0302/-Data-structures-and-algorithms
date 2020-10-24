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
using System.Drawing.Drawing2D;

namespace BinarySearchReproduce
{
    public partial class BNS_Form : Form
    {
        public BNS_Form()
        {
            InitializeComponent();
        }
        Graphics g;

        Font font = new Font("Times New Roman", 8);
        Font font2= new Font("Times New Roman", 6);

        Pen p_Green = new Pen(Color.Green,10);
        Pen p_Magenta = new Pen(Color.Magenta,10);
        Pen p_Red = new Pen(Color.Red,10);
        Pen p_Yellow = new Pen(Color.Yellow,10);
        Pen p_Blue = new Pen(Color.Blue,10);
        Pen p_Orange = new Pen(Color.Orange, 10);
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

        List<int> Arr = new List<int>();

        public void DrawCol(int x,int y,int z,int t, string idx,Pen p,int val)
        {
            g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawLine(p, x, y, z, t);
           // g.DrawString(idx, font, Brushes.White, x-5, y);
            if(idx.Count()==2)
            {
                g.DrawString(idx, font, Brushes.White, x - 8, y);
            }
            else
            {
                g.DrawString(idx, font, Brushes.White, x - 5, y);
            }
            if(val<100)
                if(val<10)
                {
                    g.DrawString(val.ToString(), font2, Brushes.Yellow, x -5, t-10);
                }
                else
                {
                    g.DrawString(val.ToString(), font2, Brushes.Yellow, x - 8, t - 10);
                }
            else
                g.DrawString(val.ToString(), font2, Brushes.Yellow, x - 10, t - 10);
        }
        public void DelCol(int x,int y,Pen p)
        {
            g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawLine(p, x, y, x, y - 1000);
        }
        public void DrawNote(string left,string right,string vitri)
        {
            g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawString("Left: " + left, font, Brushes.Green, 400, 500);
            g.DrawString("Right: " + right, font, Brushes.Yellow, 450, 500);
            g.DrawString("Middle: " + vitri, font, Brushes.Red, 500, 500);
        }
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            for (int i = 1; i <= 50; i++)
            {
                int a = rnd.Next(1, 150);
                Arr.Add(a);
            }
            Arr.Sort();
            int dem = 20;
            int count = 0;
            foreach(int k in Arr)
            {
                DrawCol(dem, 400, dem, 400 - 2*k,count.ToString(),p_Magenta,k);
                
                dem += 15;
                count++;
            }
            DrawNote("0", (Arr.Count()-1).ToString(), (Arr.Count / 2).ToString());
            LoadChu(51);
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            int dem = 20;
            int idx = 0;
            foreach (int k in Arr)
            {
                if(k==int.Parse(txbVal.Text))
                {
                    DrawCol(dem, 400, dem, 400 - 2 * k, idx.ToString(), p_Blue, k);
                }
                dem += 15;idx++;
            }
            LeftRight(0, 49);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
             BinarySearch(0, Arr.Count - 1, int.Parse(txbVal.Text));
        }
        public void BinarySearch(int l,int r,int x)
        {
            int  mid, n = 0;

            DrawNote(l.ToString(), r.ToString(), ((l + r) / 2).ToString());
            while (l <= r)
            {
                LoadChu(0);
                Thread.Sleep(1000);
                LoadChu(1);
                Thread.Sleep(1000);
               
                LoadChu(2);
                mid = (l + r) / 2;
                g.FillRectangle(Brushes.Black, 400, 500, 300, 300);
                DrawNote(l.ToString(), r.ToString(), ((l + r) / 2).ToString());
                Mid(mid);
                
                Application.DoEvents();
                Thread.Sleep(1000);
                LoadChu(3);
                Thread.Sleep(1000);
                if (Arr[mid] == x)
                {
                    LoadChu(4);
                    n = 1;
                    Tick();
                    break;
                }
                LoadChu(5);
                if (Arr[mid] > x)
                {

                    LoadChu(6);
                    Thread.Sleep(1000);
                    r = mid - 1;
                    LeftRight(l, r);
                    Application.DoEvents();
                    Thread.Sleep(1000);
                    //g.FillRectangle(Brushes.Black, 0, 0, 800, 400);

                }
                else
                {
                    l = mid + 1;
                    LoadChu(7);
                    Thread.Sleep(1000);
                    LeftRight(l, r);
                    Application.DoEvents();
                    Thread.Sleep(1000);
                    //g.FillRectangle(Brushes.Black, 0, 0, 800, 400);
                }
               
            }
            if(n!=1)
            {
                LoadChu(0);
                Thread.Sleep(1000);
                LoadChu(1);
                Thread.Sleep(1000);
                LoadChu(8);
                MessageBox.Show("Không tìm thấy");
            }
        }
        public void LeftRight(int l,int r)
        {
            int index = 0, dem = 20;
           
            
            foreach (int k in Arr)
            {
                if(index==l)
                {
                    DrawCol(dem, 400, dem, 400 - 2 * k,index.ToString(), p_Green, k);
                }
                if(index==r)
                {
                    DrawCol(dem, 400, dem, 400 - 2 * k, index.ToString(), p_Red, k);
                }
                if(index!=l&&index!=r&&Arr[index]!=int.Parse(txbVal.Text))
                {
                    DrawCol(dem, 400, dem, 400 - 2 * k, index.ToString(), p_Magenta, k);
                }
               
                dem += 15;
                index++;
            }
        }
        public void Mid(int m)
        {
            int index = 0, dem = 20;
            foreach (int k in Arr)
            {
                if (index == m)
                {
                    DrawCol(dem, 400, dem, 400 - 2 * k, index.ToString(), p_Orange, k);
                }
               
                dem += 15;
                index++;
            }
        }
        public void LoadChu(int vitri)
        {
            Graphics g;
            g = CreateGraphics();
            Font fontk = new Font("Consolas", 12, FontStyle.Bold);
            for (int i = 0; i < 9; i++)
            {

                switch (i)
                {
                    case 0:
                        g.DrawString(ab, fontk, Brushes.White, 800, 80);
                        break;
                    case 1:
                        g.DrawString(bb, fontk, Brushes.White, 800, 110);
                        break;
                    case 2:
                        g.DrawString(cb, fontk, Brushes.White, 800, 140);
                        break;
                    case 3:
                        g.DrawString(db, fontk, Brushes.White, 800, 170);
                        break;
                    case 4:
                        g.DrawString(eb, fontk, Brushes.White, 800, 200);
                        break;
                    case 5:
                        g.DrawString(fb, fontk, Brushes.White, 800, 230);
                        break;
                    case 6:
                        g.DrawString(gb, fontk, Brushes.White, 800, 260);
                        break;
                    case 7:
                        g.DrawString(hb, fontk, Brushes.White, 800, 290);
                        break;
                    case 8:
                        g.DrawString(mb, fontk, Brushes.White, 800, 320);
                        break;

                }
                switch (vitri)
                {
                    case 0:
                        g.DrawString(ab, fontk, Brushes.Red, 800, 80);
                        break;
                    case 1:
                        g.DrawString(bb, fontk, Brushes.Red, 800, 110);
                        break;
                    case 2:
                        g.DrawString(cb, fontk, Brushes.Red, 800, 140);
                        break;
                    case 3:
                        g.DrawString(db, fontk, Brushes.Red, 800, 170);
                        break;
                    case 4:
                        g.DrawString(eb, fontk, Brushes.Red, 800, 200);
                        break;
                    case 5:
                        g.DrawString(fb, fontk, Brushes.Red, 800, 230);
                        break;
                    case 6:
                        g.DrawString(gb, fontk, Brushes.Red, 800, 260);
                        break;
                    case 7:
                        g.DrawString(hb, fontk, Brushes.Red, 800, 290);
                        break;
                    case 8:
                        g.DrawString(mb, fontk, Brushes.Red, 800, 320);
                        break;

                }
            }
            
        }
        public void Tick()
        {
            int idx = 0;
            int dem = 20;
            bool check = false;
            foreach (int k in Arr)
            {
                if (k == int.Parse(txbVal.Text) && check == false)
                {
                    DrawCol(dem, 400, dem, 400 - 2 * k, idx.ToString(), p_Yellow, k);
                    check = true;
                }
                else
                {
                    DrawCol(dem, 400, dem, 400 - 2 * k, idx.ToString(), p_Magenta, k);
                }
                dem += 15;
                idx++;
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Arr.Clear();
            g.Clear(Color.Black);
        }
    }
}
