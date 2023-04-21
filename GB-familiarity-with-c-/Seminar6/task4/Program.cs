Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int n1 = 0;
Console.Write(n1 + " ");
int n2 = 1;
Console.Write(n2 + " ");

for (int i = 2; i < number; i++)
{
    int NewNumber = n1 + n2;
    Console.Write(NewNumber + " ");
    n1 = n2;
    n2 = NewNumber;
}
