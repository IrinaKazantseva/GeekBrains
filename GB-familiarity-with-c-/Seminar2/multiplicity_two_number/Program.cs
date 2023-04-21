Console.Write("Введите число 1: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int numberA = Convert.ToInt32(Console.ReadLine());


if (numberB % numberA == 0)
{
Console.WriteLine("число 1 кратно числу 2");
// Console.WriteLine($"Число {numberB} нацело делится на число {numberA}");
}
else
{
//Console.Write("число 1 не кратно числу 2, остаток = ");
//Console.WriteLine(numberB % numberA);
Console.WriteLine($"Число 1 не кратно числу 2. Остаток {numberB % numberA}");
}