// Метод:

void PrintArray(string[] array)
{
    Console.WriteLine($"Массив из строк, длина которых менее или равна 3 символам: ");
    Console.Write($"[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
}

// Первоначальный массив задан заранее, можно выбрать один из приведенных
// либо задать его самостоятельно

string[] originalArray = { "Hello", "2", "world", ":-)" };
// string[] originalArray = { "1234", "1567", "-2", "computer science" };
// string[] originalArray = { "Russia", "Denmark", "Kazan" };


// Вычисление длины нового массива

int newArrayLength = 0;
for (int i = 0; i < originalArray.Length; i++)
{
    if (originalArray[i].Length <= 3)
    {
        newArrayLength++;
    }
}

// Формирование нового массива и вывод его на консоль
// либо сообщение об отсутствии данных для формирования нового массива

if (newArrayLength > 0)
{
    string[] newArray = new string[newArrayLength];

    int index = 0;
    for (int i = 0; i < originalArray.Length; i++)
    {
        if (originalArray[i].Length <= 3)
        {
            newArray[index] = originalArray[i];
            index++;
        }
    }
    Console.WriteLine();
    PrintArray(newArray);
}
else
{
    Console.WriteLine();
    Console.Write("Все введенные строки не соответствуют условию задачи");
}



