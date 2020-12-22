using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatAgency.Exceptions
{
    class InputException : ApplicationException
    {
        public string Parameter { get; set; }

        public InputException(string message, string parameter) : base(message)
        {
            Parameter = parameter;
        }
    }
}
