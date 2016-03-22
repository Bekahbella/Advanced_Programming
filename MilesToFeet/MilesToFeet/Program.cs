using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilesToFeet
{
    class Program
    {
        static void Main(string[] args)

        {
            string feetString;
            double feetDouble;
            const double feetInMile = 5280;
            double milesCalculated;


            Console.WriteLine("Enter feet to be converted into miles.");
            feetString = Console.ReadLine();
            feetDouble = Convert.ToDouble(feetString);

            milesCalculated = (feetDouble / feetInMile);
            Console.WriteLine("{0} feet is {1} mile(s) ", feetDouble, milesCalculated);
            Console.ReadKey();

        

        }
    }
}
