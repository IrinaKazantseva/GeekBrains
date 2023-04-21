void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите новый элемент массива: ");
        int A = Convert.ToInt32(Console.ReadLine());
        array[i] = A;
        Console.WriteLine($"Ячейке массива c индексом {i} присвоено значение {A}");
    }
}

void PrintArray(int[] array1)
{
    Console.WriteLine($"Получили массив: ");
    Console.Write($"[");
    for (int i = 0; i < array1.Length - 1; i++)
    {
        Console.Write(array1[i] + ", ");
    }
    Console.Write(array1[array1.Length - 1] + "]");
}



Console.Write("Введите количество элементов массива: ");
int numb_elem = Convert.ToInt32(Console.ReadLine());
int[] array2 = new int[numb_elem];

FillArray(array2);
PrintArray(array2);





