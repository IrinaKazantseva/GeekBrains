Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 4) 
{
Console.WriteLine("Данные введены неверно, укажите диапазон от 1 до 4");
}
else
{
    if (number == 1) Console.WriteLine("x > 0 и y > 0");
    if (number == 2) Console.WriteLine("x < 0 и y > 0");
    if (number == 3) Console.WriteLine("x < 0 и y < 0");
    if (number == 4) Console.WriteLine("x > 0 и y < 0");
}