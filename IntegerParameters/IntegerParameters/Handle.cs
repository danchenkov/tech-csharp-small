using System;

class Handle
{
    public int total;

    public void Process(int a, int b)
    {
        total = a * 2;
        Console.WriteLine(b);
    }
}
