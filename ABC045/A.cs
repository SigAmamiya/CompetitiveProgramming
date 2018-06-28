using System;

class Sample
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        var area = (a + b) * h / 2;

        Console.WriteLine(area);
    }
}
