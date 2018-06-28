using System;

class Sample
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        var result = n > k ? x * k + y * (n - k) : x * n;

        Console.WriteLine(result);
    }
}
