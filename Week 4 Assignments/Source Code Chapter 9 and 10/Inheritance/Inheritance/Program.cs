using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {

            Employee clerk = new Employee();  // declare Empoyee object 
            CommissionEmployee salesperson = new CommissionEmployee();  // declare CommissionEmployee object 
            clerk.EmpNum = 123;
            clerk.EmpSal = 30000.00;
            salesperson.EmpNum = 234;
            salesperson.EmpSal = 20000;
            salesperson.CommissionRate = 0.07;
            Console.WriteLine("\n" + clerk.GetGreeting());
            Console.WriteLine("Clerk #{0} salary: {1} per year",
               clerk.EmpNum,
               clerk.EmpSal.ToString("C"));
            Console.WriteLine("\n" + salesperson.GetGreeting());
            Console.WriteLine("Salesperson #{0} salary: {1} per year",
               salesperson.EmpNum,
               salesperson.EmpSal.ToString("C"));
            Console.WriteLine("...plus {0} commission on all sales",
               salesperson.CommissionRate.ToString("P"));
            Console.ReadLine();


            //Overriding Base Class Methods
            Student payingStudent = new Student();
            ScholarshipStudent freeStudent = new ScholarshipStudent();
            payingStudent.Name = "Megan";
            payingStudent.Credits = 15;
            freeStudent.Name = "Luke";
            freeStudent.Credits = 15;
            Console.WriteLine("{0}'s tuition is {1}",
               payingStudent.Name,
               payingStudent.Tuition.ToString("C"));
            Console.WriteLine("{0}'s tuition is {1}",
               freeStudent.Name,
               freeStudent.Tuition.ToString("C"));
            Console.ReadLine();


            //Accessing Base Class Methods and Properties from a Derived Class 
            CommissionEmployee salesPerson = new CommissionEmployee();
            salesperson.EmpNum = 345;
            Console.WriteLine(salesperson.GetGreeting());


            /* 1. Understanding Implicit Reference Conversions- 
               2. Every derived class object “is a” specific instance of both the derived class and the base class
               3. C# makes an implicit conversion from derived class to base class
              */
            Employee clerk1 = new Employee();
            CommissionEmployee salesPerson1 = new CommissionEmployee();
            clerk1.EmpNum = 234;
            salesPerson1.EmpNum = 345;
            DisplayGreeting(clerk1);
            DisplayGreeting(salesPerson1);
            
            //Object class usage....
            Student payingStudent2 = new Student();
            ScholarshipStudent freeStudent2 = new ScholarshipStudent();
            Employee clerk2 = new Employee();
            Console.Write("Using Student: ");
            DisplayObjectMessage(payingStudent2);
            Console.Write("Using ScholarshipStudent: ");
            DisplayObjectMessage(freeStudent2);
            Console.Write("Using Employee: ");
            DisplayObjectMessage(clerk2);

            //Overriding Methods of Object class 
            GetTypeOfObject(clerk2);
            Employee first = new Employee();
            Employee second = new Employee();
            Console.WriteLine(first.GetHashCode());  // 4614728
            Console.WriteLine(first.GetHashCode()); // 12289376


            /* Base Class Constructors :
               1. Instantiating an object of a derived class calls the constructor for both the base class and the derived class.
               2. The base class constructor must execute FIRST
               3. Within the header of derived class constructor, provide values for any arguments required by the base class constructor
               4. Use keyword 'base'
            */
            CommissionEmployee cmEmployee = new CommissionEmployee(); //Instantiating an object of a derived class calls the constructor for both the base class and the derived class.                       
            Console.ReadLine();

            /*Abstract Classes :
               1. One from which you cannot create concrete objects, but from which you can inherit
               2. Abstract method has no statements         
               3. Derived classes must override Abstract method using the keyword 'override'            
             */
            Dog spot = new Dog("Spot");
            Cat puff = new Cat("Puff");
            Console.WriteLine(spot.Name + " says " + spot.Speak());
            Console.WriteLine(puff.Name + " says " + puff.Speak());

            DisplayAnimal(spot);  // Note Dog 'is-a' animal
            DisplayAnimal(puff);   //Note Cat 'is-a' animal

            Console.ReadLine();

            /*Interface :
               1. You cannot instantiate concrete objects from either abstract classes or interfaces
               2. A class can inherit from only one base class, but it can implement any number of interfaces
               3. You create an interface when you want derived classes to override EVERY  method
               4. Interfaces provide you with a way to exhibit polymorphic behavior
             */
            Employee bob = new Employee("Bob");
            Dog spot1 = new Dog("Spot");
            Cat puff1 = new Cat("Puff");
            Console.WriteLine(bob.Name + " says " + bob.Work());
            Console.WriteLine(puff.Name + " says " + puff.Work());
            Console.WriteLine(spot.Name + " says " + spot.Work());

            /*Extension Methods :  
             1. Methods you can write to add to any type
             2. The first parameter in an extension method specifies the type extended and must begin with the keyword 'this'
             3. When you write an extension method, it must be stored in a static class
             */
             //Look at DemoExtensionMethod class.....
            

        }       

        public static void DisplayGreeting(Employee emp)
        {
            Console.WriteLine("Hi there from #", emp.EmpNum);
            Console.WriteLine(emp.GetGreeting());
        }       
        public static void DisplayObjectMessage(Object o)
        {
            Console.WriteLine("Method successfully called");
        }     
        private static void GetTypeOfObject(Employee emp)
        {
            Console.WriteLine(emp.GetType());
        }
        public static void DisplayAnimal(Animal creature) // only 1 method is used to display all kinds of Animals..
        {
            Console.WriteLine(creature.Name + " says " + creature.Speak());
        }      
    }
}
