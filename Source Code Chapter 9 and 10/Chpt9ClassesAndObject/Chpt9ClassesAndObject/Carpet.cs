using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chpt9ClassesAndObject
{
    class Carpet
    {
        public const string MOTTO = "Our carpet are quality-made";
        private int length;
        private int width;
        private int area;


        public int Length
        {
            get { return length; }
            set
            {
                length = value;
                CalArea();
            }
        }

        public int Width
        {
            get { return width; }
            set
            {
                width = value;
                CalArea();
            }
        }
        public int Area
        {
            get { return area; }
        }

        private void CalArea()
        {
            area = Length * Width;
        }
    }
}
