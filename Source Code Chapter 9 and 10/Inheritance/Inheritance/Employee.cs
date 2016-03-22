using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Employee : IWorkable
    {
        private int empNum;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        protected double empSal; // protected field
        public int EmpNum
        {
            get
            {
                return empNum;
            }
            set
            {
                empNum = value;
            }
        }
        public double EmpSal
        {
            get
            {
                return empSal;
            }
            set
            {
                empSal = value;
            }
        }

        //Constructor
        public Employee()
        {
            Console.WriteLine("Employee Constructed");
        }
        public Employee(string name)
        {
            this.Name = name;
        }
        public Employee(int EmpID, string name)
        {
            ;
        }
        
        public string GetGreeting()
        {
            string greeting = "Hello. I am employee #" + EmpNum;
            return greeting;
        }

        //Implement ToString() method of Object class
        public override string ToString()
        {
            return (GetType() + ": " + empNum + " " + EmpSal);
        }

        //Implement Equals Method
        public override bool Equals(object e)
        {
            bool isEqual;
            if (this.GetType() != e.GetType())
                isEqual = false;
            else
            {
                Employee temp = (Employee)e;
                if (EmpNum == temp.EmpNum)
                    isEqual = true;
                else
                    isEqual = false;
            }
            return isEqual;
        }

        public string Work()
        {
            return "I do my job";
        }
    }
}
