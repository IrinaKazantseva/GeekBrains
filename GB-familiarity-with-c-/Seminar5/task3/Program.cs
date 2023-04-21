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

int[] array = FillArrayWithRandomNumbers(5, -16, 16);
Console.WriteLine('[' + string.Join(", ", array) + ']');

Console.Write("Введите искомое число: ");
int A = Convert.ToInt32(Console.ReadLine());
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == A)
    {
        count = 1;
        break;
    }
}
if (count == 1) Console.Write("В массиве есть искомое число");
if (count == 0) Console.Write("В массиве нет искомого числа");
