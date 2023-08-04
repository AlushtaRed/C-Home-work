//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите первое число");
string input = Console.ReadLine();
int number1 = Convert.ToInt32(input);
Console.WriteLine("Введите второе число");
string input2 = Console.ReadLine();
int number2 = Convert.ToInt32(input2);
Console.WriteLine("Введите третье число");
string input3 = Console.ReadLine();
int number3 = Convert.ToInt32(input3);
int max = number1;
if (number2 > number1) max = number2;

if (number3 > max) {max = number3;
Console.WriteLine("Максимальное число " + number3);
}
else 
{Console.WriteLine("Максимальное число " + max );
}
