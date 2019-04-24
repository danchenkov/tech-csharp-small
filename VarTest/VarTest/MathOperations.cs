using System;
using System.Collections.Generic;
using System.Text;

namespace VarTest
{
    class MathOperations
    {
        public Int64 Seed;
        int iteration;
        public MathOperations(Int64 seed)
        {
            Seed = seed;
            iteration = 0;
        }
        public MathOperations() : this(314159265) {
        }

        public int NewRandom()
        {
            Seed = Seed * 7 % Int32.MaxValue;
            return (int)(Seed % 10);
        }
    }
}
