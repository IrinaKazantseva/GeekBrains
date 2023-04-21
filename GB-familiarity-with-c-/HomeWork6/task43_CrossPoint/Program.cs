Console.WriteLine("Введите параметры первой прямой: ");

Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите параметры второй прямой: ");

Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    if (b1 != b2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        Console.WriteLine("Прямые совпадают");
    }
}
else
{
    //double XCrossPoint = (b2 - b1) / (k1 - k2);
    //double YCrossPoint = (k1 * b2 - k2 * b1) / (k1 - k2);
    Console.Write($"Координаты точки пересечения прямых: ({(b2 - b1) / (k1 - k2)}; {(k1 * b2 - k2 * b1) / (k1 - k2)}).");
}

