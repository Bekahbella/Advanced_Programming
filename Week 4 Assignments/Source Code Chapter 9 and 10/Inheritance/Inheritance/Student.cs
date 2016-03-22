using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Student
    {
        private const double RATE = 55.75;
        private string name;
        protected int credits;
        protected double tuition;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public virtual int Credits
        {
            get
            {
                return credits;
            }
            set
            {
                credits = value;
                tuition = credits * RATE;
            }
        }
        public double Tuition
        {
            get
            {
                return tuition;
            }
        }
    }
}
