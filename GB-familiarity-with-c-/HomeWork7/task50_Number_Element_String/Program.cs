Console.Write("Введите число строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] Matrix = FillMatrixRandomNumbers(m, n);
PrintMatrix(Matrix);

int[,] FillMatrixRandomNumbers(int rows, int columns, int LeftRange = 0, int RightRange = 10)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(LeftRange, RightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите позиции элемента в двумерном массиве через пробел: ");
int[] numbers = Console.ReadLine().Split().Select(x => Convert.ToInt32(x)).ToArray();

if (numbers.Length != 2)
{
    Console.Write($"Указаны неверные данные, введите две цифры");
}
else
{
    if (numbers[0] < Matrix.GetLength(0) && numbers[1] < Matrix.GetLength(1))
    {

        Console.Write($"Значение элемента с индексом [{numbers[0]}, {numbers[1]}] = {Matrix[numbers[0], numbers[1]]}");
    }
    else
    {
        Console.Write($"В массиве отсутствует элемент с индексом [{numbers[0]}, {numbers[1]}]");
    }
}
