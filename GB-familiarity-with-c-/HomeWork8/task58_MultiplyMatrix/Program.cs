Console.Write("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Первый массив: ");
int[,] Matrix1 = FillMatrixRandomNumbers(m, n);
PrintMatrix(Matrix1);
Console.WriteLine();

Console.WriteLine("Второй массив: ");
int[,] Matrix2 = FillMatrixRandomNumbers(m, n);
PrintMatrix(Matrix2);
Console.WriteLine();

Console.WriteLine("Массив, полученный в результате умножения: ");
int[,] ResultMatrix = MultiplyMatrix(m, n, Matrix1, Matrix2);
PrintMatrix(ResultMatrix);

int[,] FillMatrixRandomNumbers(int rows, int columns, int LeftRange = 0, int RightRange = 9)
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

int[,] MultiplyMatrix(int rows, int columns, int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[rows, columns];

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return resultMatrix;
}

