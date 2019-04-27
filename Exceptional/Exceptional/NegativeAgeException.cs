using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptional
{
    public class NegativeAgeException : Exception
    {
        public NegativeAgeException()
            : base() { }
        public NegativeAgeException(string message)
            : base(message) { }
    }
}
