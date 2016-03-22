using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chpt11ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            // Divide by zero Exception
            MilesPerGallon();

            //Handle Exception thrown from outside Method :- When methods from other classes throw Exceptions, 
            //methods do not have to catch them, Your calling program can catch them, and you can decide what to do
            int item;
            try
            {
                Console.WriteLine("Enter an Item  number ");
                item = Convert.ToInt32(Console.ReadLine());
                PriceList.DisplayPrice(item);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace); // Note that this shows the 'call stack' ..  //StackTrace property -> Contains 
                //a list of methods in the 'call stack' so you can determine the location of the Exception
            }

            // Using MyOwnException Class to handle error 
            BankAccount acct = new BankAccount();
            try
            {
                acct.AccountNum = 1234;
                acct.Balance = -1000;
            }
            catch (MyOwnExceptionClass ex) //creating an exception of your own that inherits from exception
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.ReadLine();
            }

            //Rethrow the exception - The method that catches an Exception does not have to handle it ... 
            //Within a catch block, you can rethrow the exception that was caught by using the keyword throw with no object after it
            try
            {
                Console.WriteLine("Trying in Main() Method");
                MethodA();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught in Main() Method  -- \n {0} ", ex.Message);
                Console.ReadLine();
            }
            Console.WriteLine("Main() Method is done");
           
        }

        //divide by zero exception
        private static void MilesPerGallon()
        {
            int milesDriven;
            int gallonOfGas;
            int mpg;

            try
            {
                Console.WriteLine("Enter Miles Driven");
                milesDriven = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter gallons of gas purchased");
                gallonOfGas = Convert.ToInt32(Console.ReadLine());
                mpg = milesDriven / gallonOfGas;
            }
            catch (Exception ex)
            {
                mpg = 0;
                Console.WriteLine("You attempt to divide by zero", ex.Message);
                Console.ReadLine();
            }
            Console.WriteLine("You got {0} miles per gallon", mpg);
        }

        // Possible TryParse() Method
        public static bool TryParse(string inputString, out int number)
        {
            bool wasSuccessful = true;
            try
            {
                number = Convert.ToInt32(inputString);
            }
            catch (FormatException ex)
            {
                wasSuccessful = false;
                number = 0;
            }
            return wasSuccessful;
        }

        private static void MethodA()
        {
            try
            {
                Console.WriteLine("Trying in Method A");
                MethodB();
            }   
            catch (Exception)
            {
                Console.WriteLine("Caught in Method A");
                throw; //log it and throw the exception
            }
        }
        private static void MethodB()
        {
            try
            {
                Console.WriteLine("Trying in Method B");
                MethodC();
            }
            catch (Exception)
            {
                Console.WriteLine("Caught in Method B");
                throw; // log it and throw the exception
            }
        }
        private static void MethodC()
        {
            Console.WriteLine("This came from Method C");
            throw (new Exception("This came from Method C")); 
        }
        
    }
}
