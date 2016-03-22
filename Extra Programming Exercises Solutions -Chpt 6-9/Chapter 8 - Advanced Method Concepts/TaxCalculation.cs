using System;
class TaxCalculation
{
   static void Main()
   {
      double price = 79.95;
      int rateAsInt = 6;
      double rateAsDouble = 0.06;
        ComputeTax(price, rateAsInt);
      ComputeTax(price, rateAsDouble);
   }
   private static void ComputeTax(double price, int taxRate)
   {
      double taxRateAsPct, tax;
      taxRateAsPct = taxRate / 100.0;
      tax = price * taxRateAsPct;
      Console.WriteLine("{0} tax on {1} is {2}",
         taxRateAsPct.ToString(), price.ToString("C"),
         tax.ToString("C")); 
   }
   private static void ComputeTax(double price, double taxRate)
   {
      double tax;
      tax = price * taxRate;
      Console.WriteLine("{0} tax on {1} is {2}",
         taxRate.ToString(), price.ToString("C"),
         tax.ToString("C")); 
   }
}
