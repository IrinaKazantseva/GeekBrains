Console.Write("Введите число строк m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] Matrix = FillMatrixRandomDoubleNumbers(m, n);
PrintMatrix(Matrix);

double[,] FillMatrixRandomDoubleNumbers(int rows, int columns, int LeftRange = -100, int RightRange = 100)
{
    double[,] matrix = new double[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = LeftRange + rand.NextDouble() * (RightRange - LeftRange);

            //matrix[i, j] = Convert.ToDouble(rand.Next(LeftRange, RightRange) / 10.0); //значения от -10 до 9.9

        }
    }

    return matrix;
}

void PrintMatrix(double[,] matrix)
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