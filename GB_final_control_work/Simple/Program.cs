// Метод:

void PrintArray(string[] array)
{
    Console.WriteLine($"Массив из строк, длина которых менее или равна 3 символам: ");

    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + " ");
    }
}

// Первоначальный массив задан заранее, можно выбрать один из приведенных
// либо задать его самостоятельно

string[] originalArray = { "Hello", "2", "world", ":-)" };
// string[] originalArray = { "1234", "1567", "-2", "computer science" };
// string[] originalArray = { "Russia", "Denmark", "Kazan" };

// Формирование и заполнение нового массива 
string[] newArray = new string[originalArray.Length];

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



