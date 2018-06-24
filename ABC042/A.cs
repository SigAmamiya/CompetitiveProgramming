using System;

class Sample
{
    public static int CountChar(string s, char c)
    {
        return s.Length - s.Replace(c.ToString(), "").Length;
    }

    public static void Main()
    {
        var n = System.Console.ReadLine();

        if (CountChar(n, '5') == 2 && CountChar(n, '7') == 1)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
