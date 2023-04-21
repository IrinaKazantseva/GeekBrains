int count = 0;
int distance = 10000;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int DogSpeed = 5;
int friend = 2;
int time;

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
