using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting_Downcasting_Enum__Exception.Exceptions
{
    public class NotAvailableException : Exception
    {
        public NotAvailableException(string message) : base (message) 
        {
        }
    }
}
