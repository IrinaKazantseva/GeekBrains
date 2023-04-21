// Задача 67: Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int res = SumDigit(number);
Console.Write(res);


int SumDigit(int N)
{
    if (N < 10)
    {
        return N;
    }

    else
    {
        return N % 10 + SumDigit(N / 10);

    }

}
