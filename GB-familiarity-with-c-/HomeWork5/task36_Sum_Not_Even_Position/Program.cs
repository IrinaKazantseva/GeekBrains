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

Console.Write("Введите минимальное число для определения рандомного диапазона значений элементов массива: ");
int Min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число для определения рандомного диапазона значений элементов массива: ");
int Max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArrayWithRandomNumbers(Numb, Min, Max);

Console.WriteLine('[' + string.Join(", ", array) + ']');
//строчка для вывода сформированного массива

int sum = 0;

for (int i = 1; i < array.Length; i += 2)
{
    sum = sum + array[i];
}
Console.Write($"Сумма элементов, стоящих на нечетных позициях = {sum}.");
