using System;

class Program4
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть n: ");
        int n = int.Parse(Console.ReadLine()!);

        double a = CalcA(n);
        double b = CalcB(n);
        long c = CalcC(n);

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"c = {c}");
    }

    // a = -1/3 + 1/5 - 1/7 + ... + (-1)^n/(2n+1)
    static double CalcA(int n)
    {
        int i = 1; double sum = 0;
        while (i <= n)
        {
            sum += Math.Pow(-1, i) / (2 * i + 1);
            i++;
        }

        return sum;
    }

    // b = (1 + 1/1^2) + ... + (1 + 1/n^2)
    static double CalcB(int n)
    {
        int i = 1; double sum = 0;
        while (i <= n)
        {
            sum += 1 + 1.0 / (i * i);
            i++;
        }

        return sum;
    }

    // c = 1! + 2! + ... + n!
    static long CalcC(int n)
    {
        int i = 1;
        long sum = 0;
        long fact = 1;

        while (i <= n)
        {
            fact *= i;
            sum += fact;
            i++;
        }

        return sum;
    }
}
