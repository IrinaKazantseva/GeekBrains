Console.Write("Введите число: ");
int OrigNumber = Convert.ToInt32(Console.ReadLine());
int Number = OrigNumber;

if (OrigNumber < 100 && OrigNumber > -100)
{
    Console.WriteLine("Ошибка: в данном числе нет третьей цифры");
}
else
{
    if (OrigNumber > 0)
    {
        while (Number > 1000)
        {
            Number = Number / 10;
        }
        Console.WriteLine($"Третья цифра числа {OrigNumber} = {Number % 10}");
    }
    else
    {
        while (-Number > 1000)
        {
            Number = Number / 10;
        }
        Console.WriteLine($"Третья цифра числа {OrigNumber} = {-Number % 10}");
    }
}