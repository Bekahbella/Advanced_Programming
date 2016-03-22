using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FahrenheitToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string inputString;
            int FahrenheitToCelsius;


            


            Console.WriteLine("Enter a temperature in Farenheit and press enter."); //prompts user to input a value
            inputString = Console.ReadLine();
            Console.WriteLine("Temperature in Farenheit is " + inputString); //displays input temperature in Farenheit
            input = Convert.ToInt32(inputString); //converts the string value to an integer

            FahrenheitToCelsius = ((input - 32) * 5 / 9); //mathematical calculation to figure out the conversion from Farenheit to Celsius
            Console.WriteLine("Temperature in Celsius is " + (FahrenheitToCelsius)); //displays the temperature in Celsius
            Console.ReadLine(); 


            


        }
    }
}
