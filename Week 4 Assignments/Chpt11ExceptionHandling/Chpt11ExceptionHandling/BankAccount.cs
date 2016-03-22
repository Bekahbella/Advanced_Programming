using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chpt11ExceptionHandling
{
    class BankAccount
    {
        private double balance;
        public double AccountNum { get; set; }
            
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    MyOwnExceptionClass nbe = new MyOwnExceptionClass();
                    throw (nbe);
                }
                balance = value;
            }
        }
        

    }
}
