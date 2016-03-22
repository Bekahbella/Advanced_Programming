using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogBoarding
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogWeightString;
            double dogWeight;
            string dayString;
            double dayDoub;
            double cost;
            double perPoundCost;

            Console.WriteLine("Please enter your dog's weight in pounds");
            dogWeightString = Console.ReadLine();
            dogWeight = Convert.ToDouble(dogWeightString);

            Console.WriteLine("Please enter the amount of days you would like to board your dog");
            dayString = Console.ReadLine(); 
            dayDoub = Convert.ToDouble(dayString);

            perPoundCost = (.50 * dogWeight);
            cost = (perPoundCost * dayDoub);
            Console.WriteLine("The cost to board your dog is {0}", cost.ToString("C"));
            Console.ReadKey();
        }
    }
}
