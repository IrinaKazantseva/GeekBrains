int[] FillArrayWithRandomNumbers(int size, int LeftRange, int RightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(LeftRange, RightRange + 1);
    }
    return arr;
}

Console.Write("Введите число элементов массива: ");
int Numb = Convert.ToInt32(Console.ReadLine());

int[] array = FillArrayWithRandomNumbers(Numb, 100, 999);
//формирование массива из случайных положительных трехзначных чисел

Console.WriteLine('[' + string.Join(", ", array) + ']');
//строчка для вывода сформированного массива

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    { count++; }
}
Console.Write($"Количество четных чисел в массиве = {count}.");