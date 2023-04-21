int number = new Random().Next(10,100); // 10-99 включительно

Console.WriteLine($"Наше случайное число = {number}");

int secondDigit = number % 10; // остаток от деления на 10
int firstDigit = number / 10; 

Console.WriteLine($"Первая цифра = {firstDigit}, вторая цифра = {secondDigit}");

if (firstDigit > secondDigit)
{ 
Console.WriteLine($"Первая цифра числа {number} больше. Это {firstDigit}");
}
else
{ 
 Console.WriteLine($"Вторая цифра числа {number} больше. Это {secondDigit}");   
}