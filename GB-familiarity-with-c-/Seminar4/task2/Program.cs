// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (A > 0)
{
    A = A / 10; // A /=10;
    count++;
}
Console.WriteLine($"Количество цифр в числе = {count}");

// string? A = Console.ReadLine();  
//Console.WriteLine(A.Length); работа через строку 


// int A = Convert.ToInt32(Console.ReadLine());
// string k = Convert.ToString(A);
// Console.WriteLine(k.Length); работа через строку со вводом точно числа

//Console.WriteLine(int.TryParse(Console.ReadLine(), out int a));
//Console.WriteLine(a); возможность конвертации в число