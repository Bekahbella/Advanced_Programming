using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chpt11ExceptionHandling
{
    public class PriceList
    {
        private static double[] price = { 15.99, 27.88, 34.56, 45.89};
        public static void DisplayPrice(int item)
        {

            double tax;
            double total;
            double pr;

            pr = price[item];
            tax = pr * Tax.DetermineTaxRate(pr);
            total = pr + tax;

            Console.WriteLine("The total Price is " + price[item].ToString("C"));
            Console.ReadLine();
        }

    }
}
