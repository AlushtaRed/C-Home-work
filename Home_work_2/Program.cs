﻿//Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Введите первое число");
string input = Console.ReadLine();
int number1 = Convert.ToInt32(input);
Console.WriteLine("Введите второе число");
string input2 = Console.ReadLine();
int number2 = Convert.ToInt32(input2);
if (number1 > number2)
{Console.WriteLine("Максимальное число " + number1 );
}
else
Console.WriteLine("Максимальное число " + number2 );




