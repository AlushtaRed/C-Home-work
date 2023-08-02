int count = 0;
int distanse = 100000;
int FirstFriendSpead = 1;
int SecondFriendSpead = 2;
int DogSpead = 5;
int Time = 0;
int Friend = 2;
while(distanse > 4)
{
    if(Friend == 1)
    {Time = distanse/(FirstFriendSpead + DogSpead);
    Friend = 2;};
    Time = distanse/(SecondFriendSpead + DogSpead);
    Friend = 1;
    distanse = distanse - (FirstFriendSpead + SecondFriendSpead) * Time;
    count = count + 1;

}
Console.WriteLine(count);
