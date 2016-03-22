using System;
public class Multiplication
{
   public static void Main()
   {
      int num;
      Console.Write("Enter a number >> ");
      num = Convert.ToInt32(Console.ReadLine());
      MultiplicationTable(num);
   }
   private static void MultiplicationTable(int num)
   {
       for(int factor = 2; factor < 11; ++factor)
          Console.WriteLine("{0} * {1} = {2}", num, factor, num * factor);
   }
}
