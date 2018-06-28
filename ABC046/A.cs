using System;
using System.Linq;

class Sample
{
    public static void Main(string[] args)
    {
        var n = Console.ReadLine()
            .Split(' ')
            .Distinct()
            .Count();

        Console.WriteLine(n);
    }
}
