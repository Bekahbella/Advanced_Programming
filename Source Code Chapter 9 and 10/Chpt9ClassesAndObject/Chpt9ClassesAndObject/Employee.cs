using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chpt9ClassesAndObject
{
    class Employee  : IComparable //class header can change access modifyer to public before class if you want
    {
        //Instance variables and Methods go here


        //Fields are local to the class
        private int idNumber; //only used within the class private
        private string name;


        //Properties - provides access to a field of a class
        public int IdNumber { get; set; }  //- Auto-implemented properties  / other classes can use public properties
        public double Salary { get; set; }
        public double PayRate { get; set; }
        

        //Constructors /methods within a class /initialize fields within a class
        public Employee()  //Parameterless 
        {
            IdNumber = 999;
            PayRate = 9.99;
        }
        public Employee(int empId)  //overloaded Employee with 1 param
        {
            IdNumber = empId;
            Salary = 0;
        }
        public Employee(int empId, double sal) //overloaded Employee with 2 param
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
        
        //Destructor use when you want to dispose from the memory, but compiler will ususally take care of this for you
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
        public void DisplayEmployeeData(string order, Employee emp) //can pass a class so you don't have to list every parameter
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
