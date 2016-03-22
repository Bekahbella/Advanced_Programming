using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tax_Calculation
{
    class TaxCalculation

    {
        static void Main()
            
        {
            double priceAsDoub = 0;
            int taxInt = 0;
            double taxAmt = 0;
            TaxRate(priceAsDoub, taxInt);
            TaxRate(priceAsDoub,  taxAmt);
            
        }

        private static void TaxRate(double priceDoub, int taxValue)
        {
            double priceAsDoub;
            string price;
            string tax;
            double taxPercent;
            double CalcTax;
            double taxDouble;
            

            Console.WriteLine("Enter the item price");
            price = Console.ReadLine();
            priceAsDoub = Convert.ToDouble(price);

            Console.WriteLine("Enter the tax percent as a whole number");
            tax = Console.ReadLine();
            taxDouble = Convert.ToDouble(tax);
            taxPercent = (taxDouble / 100);
           

            CalcTax = (taxPercent * priceAsDoub);


            Console.WriteLine("{0} tax charged on {1} will be {2}", taxPercent.ToString(), priceAsDoub.ToString("C"), CalcTax.ToString("C"));

        }

        private static void TaxRate(double priceDoub, double taxValue)
        {
           

            double priceAsDoub;
            string price;
            string tax;
            double taxAmt;
            double CalcTax;

            Console.WriteLine("Enter the item price");
            price = Console.ReadLine();
            priceAsDoub = Convert.ToDouble(price);

            Console.WriteLine("Enter the tax amount in decimal form");
            tax = Console.ReadLine();
            taxAmt = Convert.ToDouble(tax);

            CalcTax = (taxAmt * priceAsDoub);

            Console.WriteLine("{0} tax charged on {1} will be {2}", taxAmt, priceAsDoub.ToString("C"), CalcTax.ToString("C"));
            

            Console.ReadKey();



        }
    }
}
