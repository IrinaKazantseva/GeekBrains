Console.WriteLine("Введите число 1: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int Number3 = Convert.ToInt32(Console.ReadLine());

if (Number1 == Number2)
{
    if (Number2 == Number3)
    {
        Console.Write("Все числа одинаковы и равны ");
        Console.WriteLine(Number2);
    }
    else if (Number3 > Number1)
    {
        Console.Write("Максимальное число = ");
        Console.WriteLine(Number3);
    }
        else
        {
        Console.Write("Первое и второе числа имеют максимальное значение среди введенных, равное  ");
        Console.WriteLine(Number2);
        }
}
else
{
    if (Number1 > Number2)
    {
        if (Number1 == Number3)
        {
        Console.Write("Первое и третье числа имеют максимальное значение среди введенных, равное  ");
        Console.WriteLine(Number1);
        }
        else if (Number1 > Number3)
        {
            Console.Write("Максимальное число = ");
            Console.WriteLine(Number1);
        }
        else
        {
            Console.Write("Максимальное число = ");
            Console.WriteLine(Number3);
        }

    }
    else
    if (Number2 == Number3)
        {
        Console.Write("Второе и третье числа имеют максимальное значение среди введенных, равное  ");
        Console.WriteLine(Number2);
        }
        else if (Number2 > Number3)
        {
            Console.Write("Максимальное число = ");
            Console.WriteLine(Number2);
        }
        else
        {
            Console.Write("Максимальное число = ");
            Console.WriteLine(Number3);
        }
}

