// Напишите программу, 
//которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int Proizvedenie = 1;

for (int i = 1; i <= N; i++)
{
    Proizvedenie = Proizvedenie * i;
}
Console.WriteLine($"Произведение чисел от 1 до N = {Proizvedenie}");