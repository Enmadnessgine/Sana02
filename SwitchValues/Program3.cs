using System;

class Program3
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int num;
        Console.WriteLine("Введіть число: ");
        num = int.Parse(Console.ReadLine()!);
        
        switch (num)
        {
            case 0:
                Console.WriteLine("Нуль");
                break;
            case 1:
                Console.WriteLine("Один");
                break;
            case 2:
                Console.WriteLine("Два");
                break;
            case 3:
                Console.WriteLine("Три");
                break;
            case 4:
                Console.WriteLine("Чотири");
                break;
            case 5:
                Console.WriteLine("П'ять");
                break;
            case 6:
                Console.WriteLine("Шість");
                break;
            case 7: 
                Console.WriteLine("Сім");
                break;
            case 8:
                Console.WriteLine("Вісім");
                break;
            case 9: 
                Console.WriteLine("Дев'ять");
                break;
            default:
                Console.WriteLine("Число поза діапазоном від 1 до 9");
                break;
        }

    }
}