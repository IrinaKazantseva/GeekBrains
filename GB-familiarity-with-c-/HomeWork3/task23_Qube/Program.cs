
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int count = 1;

if (N > 0)
{
    Console.WriteLine($"Таблица кубов чисел от 1 до {N}: ");

    while (count <= N)
    {
        Console.WriteLine(Math.Pow(count, 3));
        count++;
    }
}
else
{
    Console.WriteLine($"Число {N} не соответствует условию задачи");
}