Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
int number = -1 * N; // int count = -N; 

while (count  < 2 * N + 1) // count <= N;
{
Console.WriteLine(number ); // Console.WriteLine(count);
number = number + 1;
count = count + 1; // count++;
}