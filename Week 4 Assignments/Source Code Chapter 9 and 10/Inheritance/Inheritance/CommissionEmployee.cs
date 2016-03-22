using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class CommissionEmployee : Employee //class : base class so you know where you are inheriting from
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
        //    : base(1234, "XXXXX") //using the base class constructor
        //{
        //}

        new public string GetGreeting()  //new modifier to acknowledge that GetGreeting HIDES the base class method.
        {
            string greeting = base.GetGreeting(); //base...get from the base (parent) class using base class constructor
            greeting += "\n I work on commission";
            return greeting;
        }
    }
}
