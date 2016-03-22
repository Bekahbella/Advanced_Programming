using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chpt9ClassesAndObject
{
    class OperatorOverloading
    {

        static void Main()
        {

            //Implementation of Book class with Overloaded + operator
            Book book1 = new Book("C# OOP Programming", 350, 15.95);
            Book book2 = new Book("Java OOP Programming", 250, 16.00);
            Book book3;
            book3 = book1 + book2;
            Console.WriteLine("The new book is \"{0}\"", book3.Title);
            Console.WriteLine("It has {0} pages and costs {1} ", book3.NumPages, book3.Price.ToString("C"));
            Console.ReadLine();


            /*  The following code is added to explain the usage of ?? operator in C#  */
            int? x = null;
            // Set y to the value of x if x is NOT null; otherwise, if x = null, set y to -1.
            int y = x ?? -1;

            /* Assign i to return value of the method if the method's result
               is NOT null; otherwise, if the result is null, set i to the default value of int.
             */
            int i = GetNullableInt() ?? default(int);
            string s = GetStringValue();
            // Display the value of s if s is NOT null; otherwise, display the string "Unspecified".
            Console.WriteLine(s ?? "Unspecified");
        }

        //The ?? operator is called the null-coalescing operator. It returns the left-hand operand if the operand is not null; otherwise it returns the right hand operand.
        static int? GetNullableInt()
        {
            return null;
        }
        static string GetStringValue()
        {
            return null;
        }
    }
}
