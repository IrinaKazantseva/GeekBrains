Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());


PrintNumbersToN(number);

void PrintNumbersToN(int N)
{
    if (N < 1) return;

    PrintNumbersToN(N - 1);
    Console.Write(N + " ");

}

// if (N < 1) return;
// Console.Write(N + " ");
// PrintNumbersToN(N - 1);
// выведет от N до 1: 5 4 3 2 1
