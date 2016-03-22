using System;
class DemoSquares
{
   static void Main()
   {
      Square[] s = new Square[10];
      int x;
      for(x = 0; x < s.Length; ++x)
      {
         s[x] = new Square(x + 1);
      }
      for(x = 0; x < s.Length; ++x)
         Console.WriteLine("The area of a {0,2} by {0,2} square is {1,3}",
            s[x].Side, s[x].Area);
   }
}
class Square
{
   double side, area;
   public Square(int side)
   {
      this.side = side;
      ComputeArea();
   }
   public double Side
   {
      get
      {
         return side;
      }
   }
   public double Area
   {
      get
      {
         return area;
      }
   }
   private void ComputeArea()
   {
      area = Side * Side;
   }
}

