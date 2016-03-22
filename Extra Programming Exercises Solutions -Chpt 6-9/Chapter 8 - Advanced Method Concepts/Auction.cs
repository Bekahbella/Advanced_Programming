using System;
public class Auction
{
   static void Main()
   {
       string bid;
       int intBid;
       double doubleBid;
       const int MIN = 10;
       Console.Write("Please enter your bid >> ");
       bid = Console.ReadLine();
       if(int.TryParse(bid, out intBid))
          AcceptBid(intBid, MIN);
       else
          if(double.TryParse(bid, out doubleBid))
             AcceptBid(doubleBid, MIN);
          else
             AcceptBid(bid, MIN);
   }
   private static void AcceptBid(int bid, int min)
   {
       if(bid >= min)
          Console.WriteLine("Bid accepted");
       else
          Console.WriteLine("Bid not high enough");
   }
   private static void AcceptBid(double bid, int min)
   {
       if(bid >= min)
          Console.WriteLine("Bid accepted");
       else
          Console.WriteLine("Bid not high enough");
   }
   private static void AcceptBid(string bid, int min)
   {
       double doubleBid;
       string dollarsString = " dollars";
       if(bid.Substring(0, 1).Equals("$"))
          if(double.TryParse(bid.Substring(1, bid.Length - 1), out doubleBid))
             AcceptBid(doubleBid, min);
          else
             Console.WriteLine("Bid was not in correct format");
       else
       {
          if(bid.Substring(bid.Length - dollarsString.Length, dollarsString.Length).Equals(dollarsString))
          {
             if(double.TryParse(bid.Substring(0, bid.Length - 8), out doubleBid))
                AcceptBid(doubleBid, min);
             else
                Console.WriteLine("Bid was not in correct format");
          }
         else
             Console.WriteLine("Bid was not in correct format");
  }}
}
