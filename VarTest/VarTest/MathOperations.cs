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
        public MathOperations(double seed)
        {
            Seed = (int)Math.Ceiling(seed);
        }
        public MathOperations() : this(314159265) {
        }

        public int NewRandom()
        {
            Seed ^= Seed << 13;
            Seed ^= Seed >> 17;
            Seed ^= Seed << 5;
            Seed = (Seed + iteration) * 7 % Int32.MaxValue;
            return (int)(Seed % 10);
        }
    }
}
