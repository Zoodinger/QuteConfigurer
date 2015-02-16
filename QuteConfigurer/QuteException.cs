using System;

namespace Qute
{
    internal class QuteException : Exception
    {
        public QuteException(string message)
            : base(message) {
        }
    }
}
