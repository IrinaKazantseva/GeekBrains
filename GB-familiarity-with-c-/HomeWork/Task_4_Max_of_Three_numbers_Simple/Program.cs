Console.WriteLine("Введите число 1: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int Number3 = Convert.ToInt32(Console.ReadLine());

int max = Number1;

if (Number2 > max) 
{
    max = Number2;
}
if (Number3 > max) 
{
    max = Number3;
}
Console.Write("Максимальное число = ");
Console.WriteLine(max);