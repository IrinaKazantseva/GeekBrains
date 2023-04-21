Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0) 
{
Console.WriteLine("x и/или y = 0. Невозможно определить четверть");
}
else
{
    if (x > 0 && y > 0) Console.WriteLine("Точка находится в первой четверти");
    if (x < 0 && y > 0) Console.WriteLine("Точка находится во второй четверти");
    if (x < 0 && y < 0) Console.WriteLine("Точка находится в третьей четверти");
    if (x > 0 && y < 0) Console.WriteLine("Точка находится в четвертой четверти");
}