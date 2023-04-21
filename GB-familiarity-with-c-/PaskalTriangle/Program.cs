//Вывести первые N строк треугольника Паскаля. 

Console.Write("Введите число строк и столбцов m: ");
int row = Convert.ToInt32(Console.ReadLine());

int[,] triangle = new int[row, row];
const int cellWidth = 3;
// количество символов для вывода отдельного элемента треугольника

void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}

void PrintTriangle()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (triangle[i, j] != 0)

                Console.Write($"{triangle[i, j],cellWidth}");
        }
        Console.WriteLine();
    }
}

void Magic()
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col + 5, i + 5);
            if (triangle[i, j] != 0)

                Console.Write($"{triangle[i, j],cellWidth}");

            col += cellWidth * 2;
        }
        col = cellWidth * row - cellWidth * (i + 1);
        Console.WriteLine();
    }
}

Console.Clear();
FillTriangle();
//PrintTriangle();
Magic();