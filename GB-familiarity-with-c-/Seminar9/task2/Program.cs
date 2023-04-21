Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

PrintNumbersToN(numberN, numberM);

void PrintNumbersToN(int N, int M)
{
    if (N < M) return;

    PrintNumbersToN(N - 1, M);
    Console.Write(N + " ");

}