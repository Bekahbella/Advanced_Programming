using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chpt9ClassesAndObject
{
    class Book
    {

        private int numPages;

        public int NumPages
        {
            get { return numPages; }
            set { numPages = value; }
        }
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private double tax;

        private string title;

        public string Title
        {
            get { return this.title; }  // using this reference
            set { this.title = value; }
        }


        public Book(string title, int pages, double price)
        {
            Title = title;
            NumPages = pages;
            Price = price;
        }

        //Overloading Operator -- Book class with overloaded + operator
        public static Book operator+(Book first, Book second) //overload the + to concatinate titles, add pages and add prices
            //method example found in OperatorOverloading.cs
        {
            const double EXTRA = 10.00;
            string newTitle = first.Title + " and " + second.Title;
            int newPages = first.NumPages + second.NumPages;
            double newPrice;
            if (first.Price > second.Price)
                newPrice = first.Price + EXTRA;
            else
                newPrice = second.Price + EXTRA;
            return (new Book(newTitle, newPages, newPrice));
        }
       
        public void AdvertisingMessage()
        {
            Console.WriteLine("Buy it now : {0}", this.title);
            Console.ReadLine();
        }

        public void SetPriceAndTax(double price)
        {
            const double TAX_RATE = 0.07;
            this.price = price;      // usage of this reference
            tax = price * TAX_RATE;
        }
    }
}
