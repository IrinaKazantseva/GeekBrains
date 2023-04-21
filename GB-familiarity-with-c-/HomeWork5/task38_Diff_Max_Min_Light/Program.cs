Console.Write("Введите число элементов массива: ");
int Numb = Convert.ToInt32(Console.ReadLine());

double[] arr = new double[Numb];
for (int i = 0; i < arr.Length; i++)
{
    Console.Write("Введите новый элемент массива: ");
    double A = Convert.ToDouble(Console.ReadLine()); // дроби вводятся через разделитель-запятую: 1,5 - иначе ошибка
    arr[i] = A;
}

Console.WriteLine('[' + string.Join(", ", arr) + ']');

double max = arr[0];
double min = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
    { max = arr[i]; }
    if (arr[i] < min)
    { min = arr[i]; }
}
double diff = max - min;
Console.Write($"Разница между максимальным и минимальным элементом массива = {diff}.");
