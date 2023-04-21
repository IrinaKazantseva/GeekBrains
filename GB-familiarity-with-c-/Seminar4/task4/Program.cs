void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 2);
        index++;
    }
}

void PrintArray(int[] collection2)
{
    int count = collection2.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(collection2[position]);
        position++;
    }
}

int[] array2 = new int[8];

FillArray(array2);
PrintArray(array2);

//int[] arr = {1,2,3,5,6,0,1};
//Console.WriteLine(string.Join(", ", arr)); - вывод массива одной строкой