using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbalshirts_BL.Exceptions
{
    public class InvalidKostprijsException : Exception
    {
        public InvalidKostprijsException(string? message) : base(message)
        {
        }
    }
}
