int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите новый элемент массива: ");
    int A = Convert.ToInt32(Console.ReadLine());
    array[i] = A;
}

Console.WriteLine("[" + string.Join(", ", array) + "]");