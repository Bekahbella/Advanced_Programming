using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chpt9ClassesAndObject
{
    class CreateEmployee
    {
        static void Main()
        {
            Employee emp;
            //
            Employee myAsst = new Employee();
            myAsst.WelcomeMessage();


            //Passing object to a method as a parameter
            Employee aWorker = new Employee();
            Employee anotherWorker = new Employee();
            aWorker.DisplayEmployeeData("First", aWorker);
            anotherWorker.DisplayEmployeeData("Second", anotherWorker);

            //Usage of Property 
            emp = new Employee();
            emp.IdNumber = 2345;
            emp.Salary = 22.11;
            Console.WriteLine("ID number is {0}", emp.IdNumber);
            emp.WelcomeMessage();

            Console.WriteLine("Employee #{0} makes {1}", emp.IdNumber, emp.Salary.ToString("C"));
            emp.WelcomeMessage();


            // Overloading Constructors
            Employee worker = new Employee();
            Employee anotherworker = new Employee(234);
            Employee boss = new Employee('A');

            Console.WriteLine("{0,4}{1,14}", worker.IdNumber, worker.Salary.ToString("C"));
            Console.WriteLine("{0,4}{1,14}", anotherworker.IdNumber, anotherworker.Salary.ToString("C"));
            Console.WriteLine("{0,4}{1,14}", boss.IdNumber, boss.Salary.ToString("C"));
            Console.ReadLine();

            //BinarySearch - uses IComparable 
            Employee[] aEmp = new Employee[5];
            int x;
            for (x = 0; x < aEmp.Length; x++)
                aEmp[x] = new Employee();
            aEmp[0].IdNumber = 333;
            aEmp[1].IdNumber = 444;
            aEmp[2].IdNumber = 555;
            aEmp[3].IdNumber = 111;
            aEmp[4].IdNumber = 222;

            Employee seekEmp = new Employee();
            seekEmp.IdNumber = 222;
            Array.Sort(aEmp);
            Console.WriteLine("Sorted Employees : ");
            for (x = 0; x < aEmp.Length; x++)
                Console.WriteLine("Employee #{0} : {1} {2}", x, aEmp[x].IdNumber, aEmp[x].Salary.ToString("C"));
            x = Array.BinarySearch(aEmp, seekEmp);
            Console.WriteLine("Employee #{0} was found at position {1}", seekEmp.IdNumber, x);          
            
            //
        }
    }
}
