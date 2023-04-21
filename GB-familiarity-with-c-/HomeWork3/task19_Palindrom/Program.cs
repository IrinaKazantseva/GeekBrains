Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// int digit1 = number/10000;

// int digit5 = number%10;

// int digit2 = (number/1000)%10;

// int digit4 = (number/10)%10;


if (number < 10000 || number > 99999)
{
Console.WriteLine("Данные введены неверно, укажите пятизначное число");
}
else if (number/10000 == number%10 && (number/1000)%10 == (number/10)%10)
// else if (digit1 == digit5 && digit2 == digit4)
{
    Console.WriteLine("Введенное число является палиндромом");
}
else
{
    Console.WriteLine("Введенное число не является палиндромом");
}