using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Person
    {
        protected string FirstName;
        protected string LastName;

        public abstract void SayName();
    }
}
