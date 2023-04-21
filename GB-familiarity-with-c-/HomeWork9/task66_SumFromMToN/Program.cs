Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > numberN)
{
    Console.Write("Значение числа M должно быть меньше числа N, введите другие значения");
}
else
{
    if (numberN <= 0 && numberM != 0)
    {
        Console.Write("Невозможно найти сумму натуральных элементов в этом промежутке");
    }
    else if (numberN == 0 && numberM == 0)
    {
        Console.Write("Сумма элементов равна 0");
    }
    else if (numberM < 0)
    {
        numberM = 0;
        int sum = PrintNumbersToN(numberN, numberM);
        Console.Write(sum);
    }
    else if (numberM >= 0)
    {
        int sum = PrintNumbersToN(numberN, numberM);
        Console.Write(sum);
    }
}

int PrintNumbersToN(int N, int M)
{

    if (N == M) return N;

    return N + PrintNumbersToN(N - 1, M);

}