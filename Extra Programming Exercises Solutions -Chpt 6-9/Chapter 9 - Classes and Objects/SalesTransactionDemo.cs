using System;
class SalesTransactionDemo
{
   static void Main()
   {
      SalesTransaction s1 = new SalesTransaction("Abbott", 2000, 0.20);
      SalesTransaction s2 = new SalesTransaction("Bender", 4000);
      SalesTransaction s3 = new SalesTransaction("Carter");
      SalesTransaction total = s1 + s2 + s3;
      Display(s1);
      Display(s2);
      Display(s3);
      DisplayTotal(total);
   }
   public static void Display(SalesTransaction s)
   {
       Console.Write("{0} had sales totaling {1}.", s.Name, s.SalesAmount);
       Console.WriteLine(" Commission rate is {0}; commision value is {1}.",
            s.getRate(), s.Commission);
   }
   public static void DisplayTotal(SalesTransaction s)
   {
       Console.Write("Total sales: {0}", s.SalesAmount.ToString("C"));
   }
}   
class SalesTransaction
{
   readonly double RATE;
   private double salesAmount;
   private double commission;
   
   public SalesTransaction(string name, double salesAmount, double rate)
   {
      Name = name;
      RATE = rate;
      SalesAmount = salesAmount;
   }
   public SalesTransaction(string name) : this(name, 0, 0)
   {
   }
   public SalesTransaction(string name, double salesAmount) : this(name, salesAmount, 0)
   {
   }
   public string Name {get; set;}
   public double SalesAmount
   {
      get
      {
         return salesAmount;
      }
      set
      {
         salesAmount = value;
         commission = salesAmount * RATE;
      }
   } 
   public double Commission
   {
      get
      {
         return commission;
      }
    }
    public double getRate()
    {
       return RATE;
    }
    public static SalesTransaction operator+(SalesTransaction s1, SalesTransaction s2)
    {
       double total;
       total = s1.SalesAmount + s2.SalesAmount;     
       SalesTransaction temp = new SalesTransaction("Total", total);
       return temp;
    }

}

