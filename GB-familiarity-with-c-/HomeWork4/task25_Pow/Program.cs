Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int Pow = 1;

if (B < 0)
{
    Console.WriteLine($" Возведение в степень {B} не соответствует условию задачи");
}
else if (B == 0)
{
    Console.WriteLine($" Число {A} в степени {B} = {Pow}");
}
else if (B > 0)
{

    for (int i = 1; i <= B; i++)
    {
        Pow = Pow * A;
    }

    Console.WriteLine($" Число {A} в степени {B} = {Pow}");
}
