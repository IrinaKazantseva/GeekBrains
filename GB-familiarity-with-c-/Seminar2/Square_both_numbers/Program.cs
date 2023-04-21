Console.Write("Введите число 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int square = numberB * numberB;
int square1 = numberA * numberA;

if (numberA == square || numberB == square1)
{
Console.WriteLine("первое число - квадрат второго или второе число - квадрат первого");
}
else
{
Console.WriteLine("первое число не квадрат второго или второе число не квадрат первого");
}