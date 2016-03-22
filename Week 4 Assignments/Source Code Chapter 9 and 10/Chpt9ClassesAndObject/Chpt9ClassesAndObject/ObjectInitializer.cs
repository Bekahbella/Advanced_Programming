using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chpt9ClassesAndObject
{
    class ObjectInitializer
    {
        //static void Main()
        //{   
        //    Employee2 worker = new Employee2 { IdNumber = 101 };

        //    Console.WriteLine("Employee #{0} exists. Salary is {1}.", worker.IdNumber, worker.Salary);
        //    Console.ReadLine();

        //    //Use Box class here ....
        //    Box box1 = new Box { height = 3 };
        //    Box box2 = new Box { width  = 3 };
        //    Box box3 = new Box { depth = 3 };
        //    DisplayDimensions(1, box1);
        //    DisplayDimensions(2, box2);
        //    DisplayDimensions(3, box3);
        //}

        static void DisplayDimensions(int num, Box box)
        {
            Console.WriteLine("Box {0} : height {1} : width {2} : depth {3} ", num, box.height, box.width, box.depth);
        }
    }
    class Employee2
    {
        //Properties - provides access to a field of a class
        public int IdNumber { get; set; }  //- Auto-implemented properties
        public double Salary { get; set; }
        public Employee2()
        {     
           
        }
    }
}
