using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexException
{
    public class CustomException : Exception
    {
        Exceptiontype type;

        public enum Exceptiontype
        {
            FirstName,
            LastName,
        }
        public CustomException(Exceptiontype type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
