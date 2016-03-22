using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    static class DemoExtensionMethod
    {
        /*Extension Methods :  
            1. Methods you can write to add to any type
            2. The first parameter in an extension method specifies the type extended and must begin with the keyword 'this'
            3. When you write an extension method, it must be stored in a static class
        */     

        static void Main()
        {
            int acctNum = 49;
            int revisedAcctNum = acctNum.AddCheckDigit();
            Console.WriteLine("Original account number was {0}",
               acctNum);
            Console.WriteLine("Revised account number is {0}",
               revisedAcctNum);
        }
        
        //AddCheckDigit() extension method
        public static int AddCheckDigit(this int num)
        {
            int first = num / 10;
            int second = num % 10;
            int third = (first + second) % 10;
            int result = num * 10 + third;
            return result;
        }
    }
}
