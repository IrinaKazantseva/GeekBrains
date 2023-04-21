Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberN < 0)
{
    Console.Write("Числа не удовлетворяют условию задачи, введите неотрицательные числа ");
}
else
{
    int result = AkkermanFunction(numberM, numberN);
    Console.Write(result);
}

int AkkermanFunction(int M, int N)
{
    if (M == 0) return N + 1;

    else if (N == 0) return AkkermanFunction(M - 1, 1);

    return AkkermanFunction(M - 1, AkkermanFunction(M, N - 1));
}



