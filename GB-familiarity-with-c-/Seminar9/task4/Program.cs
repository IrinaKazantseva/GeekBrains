// Задача 69: Напишите программу, которая на вход 
// принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int res = Pow(A, B);
Console.Write(res);


int Pow(int num1, int num2)
{
    if (num2 == 0)
    {
        return 1;
    }

    else
    {
        return num1 * Pow(num1, num2 - 1);

    }

}
