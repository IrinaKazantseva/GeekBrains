Console.Write("Введите трёхзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number > 99 && Number < 1000)
{
    int SecondDigit = (Number / 10) % 10;
    Console.WriteLine($"Вторая цифра числа {Number} = {SecondDigit}");
}
else
    Console.WriteLine("Ошибка: введено не трехзначное число");