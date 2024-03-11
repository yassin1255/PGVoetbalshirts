using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbalshirts_BL.Exceptions
{
    public class InvalidNaamException : Exception
    {
        public InvalidNaamException(string? message) : base(message)
        {
        }
    }
}
