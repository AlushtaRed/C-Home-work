// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
int chetnoe = 1;
while (chetnoe < number)
    {if (chetnoe % 2 == 0) Console.WriteLine(chetnoe);
    chetnoe = chetnoe + 1;
    }