Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());

if (N % 2 == 0)
{
    Console.Write(N);
    Console.WriteLine(" - четное число");
}
else
{
    Console.Write(N);
    Console.WriteLine(" - нечетное число");
}