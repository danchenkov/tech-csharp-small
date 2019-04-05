using System;

class Confusion
{
    public int GuessWhat(int input)
    {
        return input * 2;
    }

    public int GuessWhat(decimal input)
    {
        return (int)input * 10;
    }

    public int GuessWhat(string input)
    {
        Int32.TryParse(input, out int intermediate);
        return intermediate * 5;
    }
}