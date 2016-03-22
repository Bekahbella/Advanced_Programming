
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desks
{
    class Program
    {

        static void Main(string[] args)
            

        {
          
            
            DeskCost();
        }
            

        public static int NumOfDrawers()
        {
            string drawers;
            int drawerInt;

            Console.WriteLine("Enter number of desk drawers you would like");
            drawers = Console.ReadLine();
            drawerInt = Convert.ToInt32(drawers);
            return drawerInt;


        }

        public static string PickWoodType()
        {
            
            string woodType;
            
           

            Console.WriteLine("Choose your wood type, enter m for mahogany, o for oak, p for pine");
            woodType = Console.ReadLine();

            
            switch (woodType)
            {
                case "p":
                    woodType = "Pine";
                    break;
                case "o":
                    woodType = "Oak";
                    break;
                case "m":
                    woodType = "Mahogany";
                    break;
                default:
                    woodType = ("Invalid");
                    break;
            }


            return woodType;


        }

        public static void DeskCost()
        {
            string wood = PickWoodType();
            double woodCost; 


            switch (wood)
            {
                case "Pine":
                    woodCost = 100.00;
                    break;
                case "Oak":
                    woodCost = 140.00;
                    break;
                case "Mahogany":
                    woodCost = 180.00;
                    break;
                default:
                    woodCost = 0.00;
                    break;
                    
            }
        
            Console.WriteLine("Your wood type is {0}", wood);

            
            double deskPrice;
            double totalDrawerCost;
            const double drawerBase = 30.00;
            int drawerTotal;

            drawerTotal = (NumOfDrawers());
            totalDrawerCost = (drawerTotal * drawerBase);
            Console.WriteLine("The total for {0} drawers is {1}", drawerTotal, totalDrawerCost.ToString("C"));
            deskPrice = (totalDrawerCost + woodCost);
            Console.WriteLine("The total cost of your desk is {0}", deskPrice.ToString("C"));

            Console.ReadKey();





            

           

        }
    }
}
