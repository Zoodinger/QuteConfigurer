using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qute
{
    internal class QuteException : Exception
    {
        public QuteException(string message)
            : base(message) {
        }
    }
}
