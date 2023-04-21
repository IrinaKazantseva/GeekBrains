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

void ChangeMatrixFirsttoEndString(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = matrix[0, j];
        matrix[0, j] = temp;
    }
}

Console.WriteLine();
ChangeMatrixFirsttoEndString(Matrix);
PrintMatrix(Matrix);

