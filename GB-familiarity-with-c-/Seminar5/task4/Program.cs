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

int[] array = FillArrayWithRandomNumbers(123, -100, 100);
//Console.WriteLine('[' + string.Join(", ", array) + ']');
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[i] <= 99)
    { count = count + 1; }
}
Console.Write($"В массиве содержится {count} чисел в пределах от 10 до 99 включительно");