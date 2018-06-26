using System;

class Sample
{
    public static void Main()
    {
        var str = Console.ReadLine();
        int n = int.Parse(str);
        int i, result = 0;


        for (i = 0; i <= n; i++)
        {
            result += i;
        }

        Console.WriteLine(result);
    }
}
