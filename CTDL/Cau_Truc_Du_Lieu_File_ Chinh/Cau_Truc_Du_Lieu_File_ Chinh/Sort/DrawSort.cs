using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cau_Truc_Du_Lieu_File__Chinh.Sort
{
    class DrawSort
    {
        private float sizePen;

        public DrawSort()
        {
            this.SizePen = 0;
        }

        public DrawSort(float k)
        {
            this.SizePen = k;
        }

        public DrawSort(DrawSort k)
        {
            this.SizePen = k.SizePen;
        }

        private Pen redPen = new Pen(Color.Red);
        private Pen blackPen = new Pen(Color.Black);
        private Pen greenPen = new Pen(Color.Green);
        private Pen whitePen = new Pen(Color.White);
        private Pen yellowPen = new Pen(Color.Yellow);


        public float SizePen { get => sizePen; set => sizePen = value; }
        public Pen RedPen { get => redPen; set => redPen = value; }
        public Pen BlackPen { get => blackPen; set => blackPen = value; }
        public Pen GreenPen { get => greenPen; set => greenPen = value; }
        public Pen WhitePen { get => whitePen; set => whitePen = value; }

        public Pen YellowPen { get => yellowPen; set => yellowPen = value; }


        private Font drawFont = new Font("Arial", 10);
        private Font drawFont2 = new Font("Arial", 12);
        private SolidBrush drawBlackBrush = new SolidBrush(Color.Black);
        private SolidBrush drawWhiteBrush = new SolidBrush(Color.White);

        public Font DrawFont { get => drawFont; set => drawFont = value; }

        public SolidBrush DrawBlackBrush { get => drawBlackBrush; set => drawBlackBrush = value; }
        public SolidBrush DrawRedBrush { get => drawWhiteBrush; set => drawWhiteBrush = value; }
        public Font DrawFont2 { get => drawFont2; set => drawFont2 = value; }
    }
}
