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

int[] array = FillArrayWithRandomNumbers(4, -3, 3);
Console.WriteLine('[' + string.Join(", ", array) + ']');

for (int i = 0; i < array.Length; i++)
{
    array[i] = -array[i];
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
