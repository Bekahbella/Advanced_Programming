using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatAWhile
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int [] codes = { 262, 414, 608, 715, 815, 920 };
            double [] prices = { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };
            int areaCodeUsed;
            double pricePerMin = 0;
            bool isValid = false;
            string callLengthString;
            int callLengthInt;
            
            

            Console.WriteLine("Please enter an area code");
            areaCodeUsed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the length of your call in minutes");
            callLengthString = Console.ReadLine();
            callLengthInt = Convert.ToInt16(callLengthString);

           

            for (int x = 0; x < codes.Length; ++x)
            {
                if (areaCodeUsed == codes[x])
                {
                    isValid = true;
                    pricePerMin = prices[x];
                }
            }
            if(isValid)
                Console.WriteLine("Price is {0}", (pricePerMin * callLengthInt));
            else
                Console.WriteLine("Not valid");

            Console.ReadKey();

           

        }
    }






           

            


            
        }
    

