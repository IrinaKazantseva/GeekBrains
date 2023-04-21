int[] FillArrayWithRandomNumbers(int size, int LeftRange, int RightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(LeftRange, RightRange + 1);
    }
    return arr;
}

int[] array = FillArrayWithRandomNumbers(5, -5, 8);
Console.WriteLine('[' + string.Join(", ", array) + ']');
int newLength = array.Length % 2 + array.Length / 2;
int[] newArray = new int[newLength];

//for (int i = 0; i <= array.Length / 2; i++)
//{
//    if (i != array.Length / 2)
//    {
//        newArray[i] = array[i] * array[array.Length - 1 - i];
//   }
//   else newArray[i] = array[i];
//}
for (int i = 0; i <= array.Length / 2; i++)
{
    newArray[i] = array[i] * array[array.Length - 1 - i];
}
if (array.Length % 2 > 0)
{
    newArray[newArray.Length - 1] = array[array.Length / 2];
}

Console.WriteLine('[' + string.Join(", ", newArray) + ']');
