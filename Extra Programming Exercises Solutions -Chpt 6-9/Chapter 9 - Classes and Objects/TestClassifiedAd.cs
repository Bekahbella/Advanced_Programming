using System;
public class TestClassifiedAd
{
   public static void Main()
   {
      ClassifiedAd myClassifiedAd = new ClassifiedAd();
      myClassifiedAd.Category = "Used cars";
      myClassifiedAd.Words = 100;
      Console.WriteLine("The classified ad with {0} words in category {1} costs {2}", myClassifiedAd.Words, myClassifiedAd.Category, myClassifiedAd.Price.ToString("C"));
   }
}
class ClassifiedAd
{
   const double PRICE_PER_WORD = 0.09;
   private int words;
   private double price;
   public string Category {get;set;}
   public int Words 
   {
     get
     {
        return words;
     }
     set
     {
        words = value;
        price = words * PRICE_PER_WORD;
     }
   }
   public double Price
   {
      get
      {
         return price;
      }
   }
}
