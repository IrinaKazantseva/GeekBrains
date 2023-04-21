const int dim1 = 2, dim2 = 2, dim3 = 2;
int[,,] Matrix = FillMatrix3DRandomNumbers(dim1, dim2, dim3);
PrintMatrix(Matrix);
Console.WriteLine();

int[,,] FillMatrix3DRandomNumbers(int rows, int columns, int depth, int LeftRange = 10, int RightRange = 99)
{
    int[] serviceMatrix = new int[rows * columns * depth];
    Random rand = new Random();
    serviceMatrix[0] = rand.Next(LeftRange, RightRange + 1);
    for (int i = 1; i < serviceMatrix.Length; i++)
    {
        serviceMatrix[i] = rand.Next(LeftRange, RightRange + 1);
        for (int j = 0; j < i; j++)
        {
            while (serviceMatrix[i] == serviceMatrix[j])
            {
                serviceMatrix[i] = rand.Next(LeftRange, RightRange + 1);
                j = 0;
            }
        }
    }
    int[,,] matrix = new int[rows, columns, depth];
    int count = 0;
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            for (int m = 0; m < matrix.GetLength(2); m++)
            {
                matrix[k, l, m] = serviceMatrix[count];
                count++;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) "); ;
            }
            Console.WriteLine();
        }
    }
}
