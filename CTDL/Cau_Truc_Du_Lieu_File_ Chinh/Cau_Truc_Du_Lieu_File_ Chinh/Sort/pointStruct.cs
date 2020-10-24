using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cau_Truc_Du_Lieu_File__Chinh.Sort
{
    public class pointStruct
    {
        public PointF point1;
        public PointF point2;

        public pointStruct()
        {
            this.point1.X = this.point1.Y = this.point2.Y = this.point2.Y = 0;
        }
        public pointStruct(PointF poin1, PointF point2)
        {
            this.point1 = poin1;
            this.point2 = point2;
        }
        public pointStruct(pointStruct k)
        {
            //this.point1 = k.point1;
            //this.point2 = k.point2;
            this.point1.X = k.point1.X;
            this.point1.Y = k.point1.Y;
            this.point2.X = k.point2.X;
            this.point2.Y = k.point2.Y;

        }
        
    }
}
