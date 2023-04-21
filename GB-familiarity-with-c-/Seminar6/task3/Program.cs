
Console.WriteLine("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int[] binNum = new int[Convert.ToInt32(Math.Log2(n1)) + 1];
Console.WriteLine(Convert.ToInt32(Math.Log2(n1)) + 1);
for (int i = binNum.Length - 1; i >= 0; i--)
{
    binNum[i] = n1 % 2;
    n1 /= 2;
}
Console.WriteLine($"[{string.Join(", ", binNum)}]");


//void PrintBinaryNumber(int number)
// if (number == 0)
//{ return;}
//else 
// {PrintBinaryNumber(number/2);
//Console.Write(number%2);}
//}