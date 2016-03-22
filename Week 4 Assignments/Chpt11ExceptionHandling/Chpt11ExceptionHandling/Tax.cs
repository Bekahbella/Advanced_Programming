using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chpt11ExceptionHandling
{
    class Tax
    {
        private static double[] taxRate = { 0.06, 0.07};
        private static double CUTOFF = 20.00;
        public static double DetermineTaxRate(double price)
        {
            int subscript;
            double rate;

            if (price <= CUTOFF)
                subscript = 0;
            else
                subscript = 2;
            rate = taxRate[subscript];
            return rate;
        }
    }
}
