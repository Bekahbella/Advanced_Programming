using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chpt9ClassesAndObject
{
    class Employee  : IComparable
    {
        //Instance variables and Methods go here


        //Fields
        private int idNumber;
        private string name;


        //Properties - provides access to a field of a class
        public int IdNumber { get; set; }  //- Auto-implemented properties
        public double Salary { get; set; }
        public double PayRate { get; set; }
        

        //Constructors
        public Employee()  //Parameterless 
        {
            IdNumber = 999;
            PayRate = 9.99;
        }
        public Employee(int empId)  
        {
            IdNumber = empId;
            Salary = 0;
        }
        public Employee(int empId, double sal) 
        {
            IdNumber = empId;
            Salary = sal;
        }
        public Employee(char code)
        {
            IdNumber = 111;
            Salary = 10000;
        }

        // Constructor Initializers  -- see following two constructors
        //public Employee() :this(999,0) //Parameterless 
        //{           
        //}
        //public Employee(char code) :this(111,100000)
        //{
        //}
        
        //Destructor 
        ~Employee()
        {
            //Example
            Console.WriteLine("Employee object {0} is destroyed", IdNumber);
        }

        //Methods
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome from Employee #{0}", IdNumber);  // IdNumber is a property 
           //Console.WriteLine("Welcome from Employee #{0}", idNumber);  // idNumber is a field
            Console.WriteLine("How may I help you?");
            Console.ReadLine();
        }

        //Passing objects to Methods
        public void DisplayEmployeeData(string order, Employee emp)
        {
            Console.WriteLine("\n{0} employee's message: ", order);
            emp.WelcomeMessage();
            Console.ReadLine();
        }

        //Using IComparable Interfce
        int IComparable.CompareTo(Object obj)
        {
            int returnVal;
            Employee temp = (Employee)obj;
            if (this.IdNumber > temp.IdNumber)
                returnVal = 1;
            else
                if (this.IdNumber < temp.IdNumber)
                    returnVal = -1;
                else
                    returnVal = 0;
            return returnVal;
        }
    }
}
