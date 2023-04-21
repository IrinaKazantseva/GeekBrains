Console.Write("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m == n)
{
    Console.WriteLine("Вы задали не прямоугольный двумерный массив");
}
else
{
    int[,] Matrix = FillMatrixRandomNumbers(m, n);
    PrintMatrix(Matrix);
    Console.WriteLine();
    MinSumStringVar1(Matrix);
}


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

// более простой вариант решения

void MinSumStringVar1(int[,] matrix)
{

    int minSumString = int.MaxValue;
    int indexString = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp += matrix[i, j];
        }
        // для вывода значений сумм элементов в каждой строке
        // Console.WriteLine($"Сумма элементов в строке {i} двумерного массива равна {temp}");
        if (temp < minSumString)
        {
            minSumString = temp;
            indexString = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов = {minSumString} и находится в строке с индексом {indexString}");

}

// решение через заполнение служебного массива значениями сумм строк
// и дальнейшего поиска минимального значения в этом массиве
// если таких строк несколько, их индексы указаны через пробел

void MinSumStringVar2(int[,] matrix)
{
    int[] ServiceMatrix = new int[matrix.GetLength(0)];
    int sumString = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumString += matrix[i, j];
        }
        ServiceMatrix[i] = sumString;
        // для вывода значений сумм элементов в каждой строке
        //Console.WriteLine($"Сумма элементов в строке {i} двумерного массива равна {sumString}");
        sumString = 0;
    }
    int min = ServiceMatrix[0];
    int minIndex = 0;

    for (int k = 0; k < ServiceMatrix.Length; k++)
    {
        if (ServiceMatrix[k] < min)
        {
            min = ServiceMatrix[k];
            minIndex = k;
        }
    }
    Console.Write($"Наименьшая сумма элементов =  {min}, индекс строки с наименьшей суммой элементов = ");
    for (int k = 0; k < ServiceMatrix.Length; k++)
    {
        if (ServiceMatrix[k] == min)
        {
            Console.Write($"{k} ");
        }

    }

}

