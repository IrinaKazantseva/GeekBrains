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


int[] CopyArray(int[] array)
{
    int[] copiedArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        copiedArray[i] = array[i];
    }
    return copiedArray;
}

Console.Write("Задайте длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] arr = FillArrayWithRandomNumbers(N, 0, 10);

Console.WriteLine(string.Join(", ", arr));

int[] copiedArr = CopyArray(arr);

Console.WriteLine(string.Join(", ", copiedArr));

//int[] numbers = input.Split().Select(x => Convert.ToInt32(x)).ToArray(); массив чисел из 1 строки

