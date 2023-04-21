Console.WriteLine("Введите числa: ");
int[] numbers = Console.ReadLine().Split().Select(x => Convert.ToInt32(x)).ToArray();

int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    { count++; }
}
Console.Write($"Введено {numbers.Length} чисел, из них {count} больше 0.");