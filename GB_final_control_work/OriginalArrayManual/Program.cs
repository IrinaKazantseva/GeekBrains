// Методы:

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите новый элемент массива: ");
        string? element = Console.ReadLine();
        if (String.IsNullOrEmpty(element))
        {
            array[i] = "null";
            Console.WriteLine("Ошибка ввода. Это значение не будет учитываться при формировании итогового массива");
        }
        else
        {
            array[i] = element;
        }
    }
}

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

// Ввод первоначального массива с клавиатуры

Console.WriteLine("Введите количество элементов массива: ");
try
{
    int number = Convert.ToInt32(Console.ReadLine());

    if (number > 0)
    {
        string[] originalArray = new string[number];
        FillArray(originalArray);

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
    }

    else
    {
        Console.Write("Укажите число больше нуля");
    }
}
catch (FormatException)
{
    Console.Write("Вы ввели не число");
}


