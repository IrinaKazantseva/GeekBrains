Console.Write("Введите порядковый номер дня недели: ");
int WeekDayNumber = Convert.ToInt32(Console.ReadLine());

switch (WeekDayNumber)
{
    case 1:
        Console.WriteLine("Рабочий день");
        break;
    case 2:
        Console.WriteLine("Рабочий день");
        break;
    case 3:
        Console.WriteLine("Рабочий день");
        break;
    case 4:
        Console.WriteLine("Рабочий день");
        break;
    case 5:
        Console.WriteLine("Рабочий день");
        break;
    case 6:
        Console.WriteLine("Выходной день");
        break;
    case 7:
        Console.WriteLine("Выходной день");
        break;
    default :
        Console.WriteLine("Введены неверные данные");
        break;
}