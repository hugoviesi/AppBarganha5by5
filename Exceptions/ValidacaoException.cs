using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBarganhaWEB.Exceptions
{
    public class ValidacaoException : Exception
    {
        public ValidacaoException(string message) : base(message)
        {
        }
    }
}
