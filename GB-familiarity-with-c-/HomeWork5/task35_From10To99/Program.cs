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
//соответственно условию задачи, предполагается A = 123

Console.Write("Введите минимальное число для определения рандомного диапазона значений элементов массива: ");
int Min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число для определения рандомного диапазона значений элементов массива: ");
int Max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArrayWithRandomNumbers(Numb, Min, Max);
// возможно исключить строки 12-13, тогда формирование массива из 123 чисел будет выглядеть как:
// int[] array = FillArrayWithRandomNumbers(123, Min, Max);

//Console.WriteLine('[' + string.Join(", ", array) + ']'); 
//строчка для вывода сформированного массива

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[i] <= 99)
    { count++; }
}
Console.Write($"Массив содержит {count} чисел в пределах от 10 до 99 включительно");