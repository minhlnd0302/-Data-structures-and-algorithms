using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cau_Truc_Du_Lieu_File__Chinh.Sort
{
    class parameter:DrawSort
    {
        private int numberOfElements;
        private float distanceCount;
        private float rate;

        public parameter()
        {
            this.numberOfElements = 0;
            this.distanceCount = 0;
            this.Rate = 0;
            this.SizePen = 0;
        }

        public parameter(int numberOfElements)
        {
            this.numberOfElements = numberOfElements;
            this.rate = dataProcessing(this.numberOfElements);
            this.distanceCount = 1 / rate;
            this.SizePen = this.numberOfElements <= 25 ? (int)(1 / this.rate) : 1 / this.rate;
            this.WhitePen.Width = this.BlackPen.Width = this.RedPen.Width = this.YellowPen.Width = this.GreenPen.Width = this.numberOfElements <= 25 ? (int)(1 / this.rate) : 1 / this.rate;
        }

        public parameter(int numberOfElements, float distanceCount, float rate)
        {
            this.numberOfElements = numberOfElements;
            this.distanceCount = distanceCount;
            this.Rate = rate;
            this.SizePen = this.numberOfElements <= 25 ? (int)(1 / rate) : 1 / rate;
        }
        public parameter(parameter tmp)
        {
            this.distanceCount = tmp.distanceCount;
            this.numberOfElements = tmp.numberOfElements;
            this.Rate = tmp.Rate;
            this.SizePen = tmp.numberOfElements <= 25 ? (int)(1 / tmp.rate) : 1 / tmp.rate;
        }

        public int NumberOfElements { get => numberOfElements; set => numberOfElements = value; }
        public float DistanceCount { get => distanceCount; set => distanceCount = value; }
        public float Rate { get => rate; set => rate = value; }


        public float dataProcessing(int numberOfElements)
        {
            if (numberOfElements < 400)
            {
                if (numberOfElements > 350) return 1;
                else if (numberOfElements > 300) return 0.875f;
                else if (numberOfElements > 250) return 0.75f;
                else if (numberOfElements > 400) return 0.625f;
                else if (numberOfElements > 150) return 0.5f;
                else if (numberOfElements > 100) return 0.375f;
                else if (numberOfElements > 50) return 0.25f;
                else if (numberOfElements > 25) return 0.125f;
                else return 0.05f;
            }
            else
            {
                return (numberOfElements / 400) + 1;
            }
        }
    }
}
