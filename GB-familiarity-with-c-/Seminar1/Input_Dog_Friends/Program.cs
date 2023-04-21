int count = 0;
int friend = 2;
int time;

Console.Write("Введите скорость первого друга: ");
string? FirstFriendSpeedStr = Console.ReadLine();
int FirstFriendSpeed;
Int32.TryParse(FirstFriendSpeedStr, out FirstFriendSpeed);

Console.Write("Введите скорость второго друга: ");
string? SecondFriendSpeedStr = Console.ReadLine();
int SecondFriendSpeed;
Int32.TryParse(SecondFriendSpeedStr, out SecondFriendSpeed);

Console.Write("Введите скорость собаки: ");
string? DogSpeedStr = Console.ReadLine();
int DogSpeed;
Int32.TryParse(DogSpeedStr, out DogSpeed);

Console.Write("Введите растояние между друзьями: ");
string? distanceStr = Console.ReadLine();
int distance;
Int32.TryParse(distanceStr, out distance);


while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (FirstFriendSpeed + DogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (SecondFriendSpeed + DogSpeed);
        friend = 1;
    }

    distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
    count = count + 1;
}

Console.Write("Собака пробежит ");
Console.Write(count);
Console.WriteLine(" раз");
