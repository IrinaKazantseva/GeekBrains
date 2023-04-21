int number = new Random().Next(100,1000); // 100-999 включительно

Console.WriteLine($"Наше случайное число = {number}");

int thirdDigit = number % 10; // остаток от деления на 10
int firstDigit = number / 100; 

int N = Convert.ToInt32(firstDigit + "" + thirdDigit); // int result = digit1*10 + digit3;
Console.WriteLine(N);