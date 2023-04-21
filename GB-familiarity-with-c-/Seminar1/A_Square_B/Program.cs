Console.Write("Введите число 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int square = numberB * numberB;

if (numberA == square)
{
Console.WriteLine("первое число - квадрат второго");
}
else
{
Console.WriteLine("первое число не квадрат второго");
}