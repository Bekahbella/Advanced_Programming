using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionsOnPurpose
{
    class ExceptionsOnPurpose
    {
        static void Main(string[] args)
        {
            int answer;
            int result;
            int zero = 0;
            Console.WriteLine("Enter an integer >>");
            answer = Convert.ToInt32(Console.ReadLine());
            result = answer / zero;
            Console.WriteLine("The answer is " + answer);
        }
    }
}
