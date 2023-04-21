//Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива.

Console.Write("Введите число строк m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] Matrix = FillMatrixRandomNumbers(m, n);
PrintMatrix(Matrix);

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

Console.WriteLine();

//void MinElement(int[,] matrix)
//{
//    int min = matrix[0, 0];
//   int minI = 0;
//    int minJ = 0;
//
//   for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//            if (matrix[i, j] < min)
//            {
//               min = matrix[i, j];
//               minI = i;
//               minJ = j;
//           }
//       }
//   }
//    Console.WriteLine($"Наименьший элемент массива равен {min} и имеет координаты [{minI},{minJ}]");
//}

//MinElement(Matrix);

int min = Matrix[0, 0];
int minI = 0;
int minJ = 0;

for (int i = 0; i < Matrix.GetLength(0); i++)
{
    for (int j = 0; j < Matrix.GetLength(1); j++)
    {
        if (Matrix[i, j] < min)
        {
            min = Matrix[i, j];
            minI = i;
            minJ = j;
        }
    }
}
Console.WriteLine($"Наименьший элемент массива равен {min} и имеет координаты [{minI},{minJ}]");



int[,] NewMatrix = new int[Matrix.GetLength(0) - 1, Matrix.GetLength(1) - 1];

for (int i = 0; i < NewMatrix.GetLength(0); i++)
{
    for (int j = 0; j < NewMatrix.GetLength(1); j++)
    {
        if (i >= minI && j >= minJ)
        {
            NewMatrix[i, j] = Matrix[i + 1, j + 1];
        }
        else if (i >= minI)
        {
            NewMatrix[i, j] = Matrix[i + 1, j];
        }

        else if (j >= minJ)
        {
            NewMatrix[i, j] = Matrix[i, j + 1];
        }

        else
        {
            NewMatrix[i, j] = Matrix[i, j];
        }
    }
}
Console.WriteLine();
PrintMatrix(NewMatrix);