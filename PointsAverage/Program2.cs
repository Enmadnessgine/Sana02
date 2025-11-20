using System;

class Program2
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        double b1, b2, b3, b4, b5;
        Console.WriteLine("Введіть b1, b2, b3, b4, b5: ");
        b1 = double.Parse(Console.ReadLine()!);
        b2 = double.Parse(Console.ReadLine()!);
        b3 = double.Parse(Console.ReadLine()!);
        b4 = double.Parse(Console.ReadLine()!);
        b5 = double.Parse(Console.ReadLine()!);

        if (((b1+b2+b3+b4+b5)/5) > 50 )
        {
            Console.WriteLine("До екзамену допущено.");
        }
        else 
        {
            Console.WriteLine("До екзамену не допущено.");
        }
    }
}