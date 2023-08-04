// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Введите число");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
if (number%2 == 0) Console.WriteLine("число " + number + " является четным");
else  Console.WriteLine("число " + number + " является нечетным");
