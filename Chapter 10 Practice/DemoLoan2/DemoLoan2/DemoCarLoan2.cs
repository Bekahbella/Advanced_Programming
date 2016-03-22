using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoLoan2
{
    class DemoCarLoan2
    {
        public int LoanNumber { get; set; }
        public string LastName { get; set; }
        public double LoanAmount
        {
            set
            {
                if (value < MINIMUM_LOAN)
                    loanAmount = MINIMUM_LOAN;
                else
                    loanAmount = value;
            }
            get
            {
                return loanAmount;

            }
        }
        public const double MINIMUM_LOAN = 5000;
        protected double loanAmount;
    }
        class Loan
        {
        static void Main(string[] args)
        { 
            Loan aLoan = new Loan ();
            aLoan.LoanNumber = 2239;
            aLoan.LastName = "Mitchell";
            aLoan.LoanAmount = 1000.00;
            CarLoan aCarLoan = new CarLoan();
            aCarLoan.LoanNumber = 3358;
            aCarLoan.LastName = "Jansen";
            aCarLoan.LoanAmount = 20000.00;
            aCarLoan.Make = "Ford";
            aCarLoan.Year = 2005;


        Console.WriteLine("Loan #{0} for {1} is for {2}", aLoan.LoanNumber, aLoan.LastName, aLoan.LoanAmount.ToString("C2"));

        Console.WriteLine("Loan#{0} for {1} is for {2}", aCarLoan.LoanNumber, aCarLoan.LastName, aCarLoan.LoanAmount.ToString("c"));
        Console.WriteLine("  Loan #{0} is for a {1} {2}", aCarLoan.LoanNumber, aCarLoan.Year, aCarLoan.Make);

        Console.ReadKey();

        
        }

        class CarLoan : Loan
        {
            private int year;
            public int Year
            {
                set
                {
                    if (value < EARLIEST_YEAR)
                    {
                        year = value;
                        loanAmount = 0;

                    }
                    else
                        year = value;
                }
                get
                {
                    return year;
                }
            }

            public string Make { get; set; }
            private const int EARLIEST_YEAR = 2006;
            private const int LOWEST_INVALID_NUM = 1000;
        }
        }

       }
    

