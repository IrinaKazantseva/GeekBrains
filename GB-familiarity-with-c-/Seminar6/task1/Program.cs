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


int[] reverseArray(int[] array)
{
    int[] reversedArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        reversedArray[i] = array[array.Length - 1 - i];
    }
    return reversedArray;
}

Console.Write("Задайте длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] arr = FillArrayWithRandomNumbers(N, 0, 10);

Console.WriteLine(string.Join(", ", arr));

int[] reversedArr = reverseArray(arr);

Console.WriteLine(string.Join(", ", reversedArr));

//int[] numbers = Console.ReadLine().Split().Select(x => Convert.ToInt32(x)).ToArray(); массив чисел из 1 строки

