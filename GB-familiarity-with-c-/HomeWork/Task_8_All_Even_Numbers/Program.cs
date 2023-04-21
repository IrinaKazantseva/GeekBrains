Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;

if (N < 1)
{
    Console.WriteLine("Введенное число не удовлетворяет условию задачи");
}
else
{
   if (N == 1)
   {
    Console.WriteLine("четные числа отсутствуют");
   }
   else
   {
    while (count <= N)
    {
        if (count % 2 == 0)
        {
        Console.Write(count);
        Console.Write(" ");
        }
    count++;
    }
   }
}