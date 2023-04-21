Console.WriteLine("Введите число 1: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

if (Number1 == Number2)
{
    Console.WriteLine("Невозможно определить максимум, числа совпадают");
}
else if (Number1 > Number2)
{
    Console.Write("большее число = ");
    Console.WriteLine(Number1);
    Console.Write("меньшее число = ");
    Console.WriteLine(Number2);

}
else
{
    Console.Write("большее число = ");
    Console.WriteLine(Number2);
    Console.Write("меньшее число = ");
    Console.WriteLine(Number1);

}