using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividingTest
{
    static class Divider
    {
        public static int half(int a)
        {
            return a / 2;
        }

        public static void half(int a, out int b)
        {
            b = a / 2;
        }
    }
}
