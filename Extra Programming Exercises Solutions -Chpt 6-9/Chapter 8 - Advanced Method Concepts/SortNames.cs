using System;
public class SortNames
{
   public static void Main()
   {
      string[] names = {"Louis", "Mickey", "Lydia", "Mona", "Millicent",
         "Larry", "Leo", "Margie", "Lee", "Lucy"};      
      SortAndDisplayNames("Andy");
      SortAndDisplayNames("Cooper", "Brady");
      SortAndDisplayNames("Gina", "Emma", "Frannie", "David", "Hannah");
      SortAndDisplayNames(names);
   }
   public static void SortAndDisplayNames(params string[] names)
   {
      Array.Sort(names);
      foreach(string name in names)
         Console.Write("{0} ", name);
      Console.WriteLine();
   }
}