
Console.Write("Введите число строк m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов n: ");
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

// Console.WriteLine();
// int Sum = 0;
// for (int j = 0; j < Matrix.GetLength(1); j++)
// {
//     for (int i = 0; i < Matrix.GetLength(0); i++)
//     {
//         Sum = Sum + Matrix[i, j];
//     }

//     вариант вывода среднего арифметического для каждого столбца в новой строке
//     Console.WriteLine($"Среднее арифметическое столбца с индексом {j} = {(double)Sum / Matrix.GetLength(0)}");

//     вариант вывода среднего арифметического в виде последовательности цифр в одной строке
//     Console.Write((double)Sum / Matrix.GetLength(0) + "    ");

//     Sum = 0;
// }

Console.WriteLine();
ColumnAverage(Matrix);

void ColumnAverage(int[,] matrix, int Sum = 0)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Sum = Sum + matrix[i, j];
        }
        Console.Write((double)Sum / matrix.GetLength(0) + "    ");

        Sum = 0;
    }
}

