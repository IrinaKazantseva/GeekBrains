// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

const int ROWS = 3;
const int COLUMNS = 4;

int[,] FillMatrixRandomNumbers(int rows, int columns, int leftRange = 0, int rightRange = 9)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
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

int[,] sourceMatrix = FillMatrixRandomNumbers(ROWS, COLUMNS);
PrintMatrix(sourceMatrix);

int[] countingArray = new int[10];


for (int i = 0; i < sourceMatrix.GetLength(0); i++)
{
    for (int j = 0; j < sourceMatrix.GetLength(1); j++)
    {
        countingArray[sourceMatrix[i, j]]++;
    }
}

for(int i = 0; i < countingArray.Length; i++)
{
    if (countingArray[i] != 0) Console.WriteLine($"Количество повторений для {i} = {countingArray[i]}");
}


