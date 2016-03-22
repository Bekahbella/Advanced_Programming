using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoreCH4
{
    class Program
    {
        static void Main(string[] args)
        {
            int e = 5, f = 10;
            if (e < f || f < 0)
                Console.Write("Red ");
            else
                Console.Write("Orange ");

            Console.ReadKey();

        }
    }
}
