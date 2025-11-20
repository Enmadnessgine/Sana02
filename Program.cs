using System.Text;
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;


double x1, x2, D, a, b, c;
Console.WriteLine("Введіть a, b, c: ");
a = double.Parse(Console.ReadLine()!);
b = double.Parse(Console.ReadLine()!);
c = double.Parse(Console.ReadLine()!);

if (a==0)
{
    x1 = -c / b;
    Console.WriteLine($"Лінійне рівняння. X = {x1}");
}
else
{
    D = b * b - 4 * a * c;
    if (D > 0)
    {
        x1 = (-b + Math.Sqrt(D)) / (2 * a);
        x2 = (-b - Math.Sqrt(D)) / (2 * a);
        Console.WriteLine($"Два дійсних корені: X1 = {x1}, X2 = {x2}");
    }
    else if (D == 0)
    {
        x1 = -b / (2 * a);
        Console.WriteLine($"Один дійсний корінь: X = {x1}");
    }
    else
    {
        Console.WriteLine("Дійсних коренів немає.");
    }
}