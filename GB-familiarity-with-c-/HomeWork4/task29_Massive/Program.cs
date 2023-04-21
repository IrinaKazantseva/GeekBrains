int numb_elem = 8;
int[] array = new int[numb_elem];

for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите новый элемент массива: ");
    int A = Convert.ToInt32(Console.ReadLine());
    array[i] = A;
    Console.WriteLine($"Ячейке массива c индексом {i} присвоено значение {A}");
}

Console.WriteLine($"Получили массив из {numb_elem} элементов: ");
Console.Write($"[");
for (int i = 0; i < array.Length - 1; i++)
{
    Console.Write(array[i] + ", ");
}
Console.Write(array[numb_elem - 1] + "]");
