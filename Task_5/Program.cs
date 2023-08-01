Console.WriteLine("Введите целое трехзначное число");
int input1 = Convert.ToInt32(Console.ReadLine());
if (input1 > 100 && input1 < 999)
{
int input2 = input1 % 100; 
int input3 = input2 % 10;
Console.WriteLine(input3);
}
else
{
    Console.WriteLine("Ошибка, это число не трехзначное");
}
