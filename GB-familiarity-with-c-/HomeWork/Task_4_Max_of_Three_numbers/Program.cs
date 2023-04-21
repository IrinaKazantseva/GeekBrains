Console.WriteLine("Введите число 1: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int Number3 = Convert.ToInt32(Console.ReadLine());

if (Number2 > Number1)
{
    if (Number2 > Number3)
    {
        Console.Write("Максимальное число - ");
        Console.WriteLine(Number2);
    }
    else
    {
        Console.Write("Максимальное число - ");
        Console.WriteLine(Number3);
    }
}
else
{
    if (Number1 > Number3)
    {
        Console.Write("Максимальное число - ");
        Console.WriteLine(Number1);
    }
    else
    {
        Console.Write("Максимальное число - ");
        Console.WriteLine(Number3);
    }
}
