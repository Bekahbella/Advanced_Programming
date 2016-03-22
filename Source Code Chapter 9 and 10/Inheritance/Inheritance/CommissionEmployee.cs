using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class CommissionEmployee : Employee
    {
        private double commissionRate;
        public double CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                commissionRate = value;
                empSal = 0; //the protected empSal field is accessible in the child class - because we made it protected
            }
        }

        //Constructor
        public CommissionEmployee()
        {
            Console.WriteLine("CommissionEmployee Constructed");
        }
        //public CommissionEmployee()
        //    : base(1234, "XXXXX")
        //{
        //}

        new public string GetGreeting()  //new modifier to acknowledge that GetGreeting HIDES the base class method.
        {
            string greeting = base.GetGreeting();
            greeting += "\n I work on commission";
            return greeting;
        }
    }
}
