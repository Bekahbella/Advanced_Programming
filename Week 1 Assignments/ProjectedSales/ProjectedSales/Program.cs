using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectedSales
{
    class Program
    {
        static void Main(string[] args)
        {
            double curSalesN = 4000.00; //declared in double value so all values have the same numeric type
            double curSalesS = 5500.00;
            const double Sales_Increase = 0.10; //constant value of the 10% sales increase

 
            //next two lines calculating the sales increase and then add it to the value of the current sales for each division
            Console.WriteLine("Projected sales for North division are" + " " +"$"  + ( curSalesN + (curSalesN * Sales_Increase)));
            Console.WriteLine("Projected sales for South division are" + " " +"$" + (curSalesS + (curSalesS * Sales_Increase)));

            Console.ReadLine(); //pauses program before closing

        }
    }
}
