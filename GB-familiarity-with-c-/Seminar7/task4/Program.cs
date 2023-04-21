// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

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

int sum = 0;

//for (int i = 0; i < Matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < Matrix.GetLength(1); j++)
//    {
//        if (i == j)
//        {
//            sum = sum + Matrix[i, j];
//        }
//   }
//}
//Console.WriteLine($"Сумма чисел на главной диагонали = {sum}");

if (m > n)
{
    for (int i = 0; i < Matrix.GetLength(1); i++)
    {

        sum = sum + Matrix[i, i];
    }
}
else
{
    for (int j = 0; j < Matrix.GetLength(0); j++)
    {

        sum = sum + Matrix[j, j];
    }
}
Console.WriteLine($"Сумма чисел на главной диагонали = {sum}");


//int SumDiag(int[,] matrix)
//{ 
//    int sum = 0;
//    int minElem;
//   if(matrix.GetLength(0) < matrix.GetLength(1))
//   {minElem = matrix.GetLength(0);}
//   else minElem = matrix.GetLength(1);
//   for (int i = 0; i < minElem; i++)
//    {
//
//        sum += matrix[i, i];
//   }
//return sum
//}