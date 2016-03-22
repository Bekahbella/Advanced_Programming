using System;
class Commission
{
   static void Main()
   {
      int[] priceLimits = {15000, 24000, 9999999};
      double[] commRates = {0.05, 0.07, 0.10};
      int x, price;
      string entryPrice;
      Console.Write("What is the sale price of the car? ");
      entryPrice = Console.ReadLine();
      price = Convert.ToInt32(entryPrice);
      x = 0;
      while(price > priceLimits[x])
      {
         ++x;
      }
      Console.WriteLine("The commission for selling a {0} car",
         price.ToString("C"));
      Console.WriteLine("is {0} percent or {1}", commRates[x] * 100,
         (commRates[x] * price).ToString("C"));
   }
}