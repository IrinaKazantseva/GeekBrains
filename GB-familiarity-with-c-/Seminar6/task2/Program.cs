Console.Write("Введите длину стороны А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину стороны B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину стороны C: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
{
    Console.Write("Такой треугольник существует");
}
else Console.Write("Такой треугольник не существует");
