// int[] array = new int[12];
// Random rand = new Random();
// int sumPositive = 0;
// int sumNegative = 0;

// for (int i = 0; i < array.Length; i++)
// {
//    array[i] = rand.Next(-9, 10);
// }
// Console.WriteLine('[' + string.Join(", ", array) + ']');

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

void sumPositiveNegative(int[] arr, out int sumPositive, out int sumNegative)
{
    sumPositive = 0;
    sumNegative = 0;


    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumPositive += arr[i];
        }
        if (arr[i] < 0)
        {
            sumNegative += arr[i];
        }
    }
}

// for (int i = 0; i < array.Length; i++)
// {
//    if (array[i] > 0)
//    {
//        sumPositive += array[i];
//    }
// if (array[i] < 0)
//   {
//        sumNegative += array[i];
//   }
//}
//Console.Write($"Сумма положительных чисел= {sumPositive}, сумма отрицательных чисел = {sumNegative}");

int[] array = FillArrayWithRandomNumbers(12, -9, 9);
sumPositiveNegative(array, out int sumP, out int sumN);
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.Write($"Сумма положительных чисел= {sumP}, сумма отрицательных чисел = {sumN}");
