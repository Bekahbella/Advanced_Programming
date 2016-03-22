using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            string custName, streetAddress, city, state, zip;

            string blenderQuanString;
            int blenderQuant = 0;
            double beforeTax = 0;
            const double Sales_Tax = 0.07;
            double taxAmt;
            double total;

           


            Console.WriteLine("Please enter your name and hit enter.");
            custName = Console.ReadLine();
            Console.WriteLine("Please enter your street address and hit enter.");
            streetAddress = Console.ReadLine();
            Console.WriteLine("Please enter your city and hit enter.");
            city = Console.ReadLine();
            Console.WriteLine("Please enter your state and hit enter.");
            state = Console.ReadLine();
            Console.WriteLine("Please enter your zip code and hit enter.");
            zip = Console.ReadLine();
            Console.WriteLine("Please enter the number of blenders you would like to order.");
            blenderQuanString = Console.ReadLine();
            blenderQuant = Convert.ToInt32(blenderQuanString); //converting input from string to integer
            
            Console.WriteLine("Receipt for:");
            Console.WriteLine(custName);
            Console.WriteLine(streetAddress);
            Console.WriteLine("{0}, {1}, {2}", city, state, zip);



           
            beforeTax = (39.95 * blenderQuant); //input quantity times cost 
            Console.WriteLine("Total:  " + beforeTax);
            taxAmt = (Sales_Tax * beforeTax);
            Console.WriteLine("Tax:  " + taxAmt);
            Console.WriteLine("---------------------------------------------");
            total = (beforeTax + taxAmt);
            Console.WriteLine("Due:    " + total);

            


            Console.ReadLine();

            


            


            

        }
    }
}
