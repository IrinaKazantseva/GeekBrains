//Вывести первые N строк треугольника Паскаля. 

Console.Write("Введите число строк и столбцов m: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] Matrix = FillMatrix(m, m);


int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = 1;
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



for (int i = 1; i < Matrix.GetLength(0); i++)
{
    for (int j = 1; j < Matrix.GetLength(1); j++)
    {
        Matrix[i, j] = Matrix[i - 1, j] + Matrix[i, j - 1];
    }
}

PrintMatrix(Matrix);

