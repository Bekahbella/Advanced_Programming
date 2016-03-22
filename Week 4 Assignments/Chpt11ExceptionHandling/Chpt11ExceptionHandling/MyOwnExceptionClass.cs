using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chpt11ExceptionHandling
{
    //To create your own Exception: Extend the ApplicationException or the Exception class
    class MyOwnExceptionClass : Exception
    {
        private static string msg = "Bank Balance is negative";
        public MyOwnExceptionClass()
            : base(msg)
        {
        }   
    }
}
