using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zipCodes = { 55101, 55102, 55103, 55419, 55417, 55416, 56093, 56008, 55411, 55422 };
            int x;
            string zipString;
            int zipEntered;
            Console.WriteLine("Enter a zip code");
            zipString = Console.ReadLine();
            zipEntered = Convert.ToInt32(zipString);
            x = Array.BinarySearch(zipCodes, zipEntered);
            if (x < 0)
                Console.WriteLine("Zip code {0} not found", zipEntered);
            else
                Console.WriteLine("Zip code {0} found at position {1} ", zipEntered, x);

            Console.ReadKey();
        }
    }
}
