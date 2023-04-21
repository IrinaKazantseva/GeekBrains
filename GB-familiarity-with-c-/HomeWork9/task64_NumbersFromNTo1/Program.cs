Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.Write("Введенное число не соответствует условию задачи");
}
else
{
    PrintNumbersFromN(number);
}

void PrintNumbersFromN(int N)
{
    if (N < 1) return;

    Console.Write(N + " ");
    PrintNumbersFromN(N - 1);
}

