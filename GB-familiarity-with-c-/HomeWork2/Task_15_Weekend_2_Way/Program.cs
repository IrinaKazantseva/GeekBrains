Console.Write("Введите порядковый номер дня недели: ");
int WeekDayNumber = Convert.ToInt32(Console.ReadLine());

if (WeekDayNumber > 0 && WeekDayNumber <= 7)
{
    if (WeekDayNumber > 0 && WeekDayNumber <= 5)
    {
        Console.WriteLine("Сегодня рабочий день");
    }
    else
    Console.WriteLine("Сегодня выходной день");
}
else
Console.WriteLine("данные введены некорректно");