Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int ModA = Math.Abs(A);
//if (A > 0)
//{
//    while (A >= 10)
//    {
//       sum = sum + A % 10;
//        A = A / 10;
//    }
//}
//else
//{
//    A = A * -1;
//    while (A >= 10)
//    {
//        sum = sum + A % 10;
//        A = A / 10;
//    }
//}
//sum = sum + A;
//Console.WriteLine($"Сумма цифр в числе = {sum}");

while (ModA >= 10)
{
    sum = sum + ModA % 10;
    ModA = ModA / 10;
}
sum = sum + ModA;
Console.WriteLine($"Сумма цифр в числе = {sum}");