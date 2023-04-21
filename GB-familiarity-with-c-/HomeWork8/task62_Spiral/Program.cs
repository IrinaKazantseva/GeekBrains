const int dim1 = 4, dim2 = 4;
int[,] Matrix = FillMatrixSpiral(dim1, dim2);
PrintMatrix(Matrix);
Console.WriteLine();


int[,] FillMatrixSpiral(int rows, int columns)
{

    int[,] matrix = new int[rows, columns];

    int count = 1;
    int i = 0;
    int j = 0;

    while (count <= rows * columns)
    {
        matrix[i, j] = count;
        count++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else
            i--;
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
