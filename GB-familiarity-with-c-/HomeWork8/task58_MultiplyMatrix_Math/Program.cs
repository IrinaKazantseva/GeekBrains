Console.Write("Введите число строк первой матрицы-множителя: ");
int row1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов первой матрицы-множителя,число строк второй матрицы-множителя: ");
int row2Column1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов второй матрицы-множителя: ");
int column2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Первый массив: ");
int[,] Matrix1 = FillMatrixRandomNumbers(row1, row2Column1);
PrintMatrix(Matrix1);
Console.WriteLine();

Console.WriteLine("Второй массив: ");
int[,] Matrix2 = FillMatrixRandomNumbers(row2Column1, column2);
PrintMatrix(Matrix2);
Console.WriteLine();

int[,] ResultMatrix = MultiplyMatrix(row1, column2, Matrix1, Matrix2);
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

int[,] MultiplyMatrix(int rowm1, int columnm2, int[,] matrix1, int[,] matrix2)
{
    int[,] multiplymatrix = new int[rowm1, columnm2];

    for (int i = 0; i < multiplymatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multiplymatrix.GetLength(1); j++)
        {
            int multiplysum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                multiplysum += matrix1[i, k] * matrix2[k, j];
            }
            multiplymatrix[i, j] = multiplysum;
        }
    }
    return multiplymatrix;
}
