Console.Write("Введите число: ");
int OrigNumber = Convert.ToInt32(Console.ReadLine());
int Number = OrigNumber;

if (OrigNumber <100)
{
   Console.WriteLine("Ошибка: в данном числе нет третьей цифры");
}
else
{
    while (Number > 1000)
    {
        Number = Number / 10;
    }
    Console.WriteLine($"Третья цифра числа {OrigNumber} = {Number % 10}");
}