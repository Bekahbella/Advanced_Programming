using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindSquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {   
            int Number = 0;
            double SqrtNumber = 0; 


            try
            {
                Console.WriteLine("Enter a number:");
                Number = Convert.ToInt32(Console.ReadLine());
                if (Number < 0)
                {
                    Console.WriteLine("Number can't be negative");
                }
                else
                {
                    //Number = Convert.ToInt32(Console.ReadLine());
                    SqrtNumber = Math.Sqrt(Number);
                    Console.WriteLine("The square root of Number {0} is: {1}", Number, SqrtNumber);
                }
               
            }
            

            catch (ApplicationException)
            {
                Console.WriteLine("Number is not valid");
                SqrtNumber = 0;
           
             }
                
            }
        }

    }



