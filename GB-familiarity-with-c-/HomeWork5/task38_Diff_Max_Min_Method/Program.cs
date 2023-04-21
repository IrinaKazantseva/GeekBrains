double[] FillArray(int size)
{
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите новый элемент массива: ");
        double A = Convert.ToDouble(Console.ReadLine());
        arr[i] = A;
    }
    return arr;
}

Console.Write("Введите число элементов массива: ");
int Numb = Convert.ToInt32(Console.ReadLine());

double[] array = FillArray(Numb);

Console.WriteLine('[' + string.Join(", ", array) + ']');

double max = array[0];
double min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    { max = array[i]; }
    if (array[i] < min)
    { min = array[i]; }
}
double diff = max - min;
Console.Write($"Разница между максимальным и минимальным элементом массива = {diff}.");