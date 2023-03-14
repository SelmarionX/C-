//1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет
// Math.Pow(number,2)- какое число, такая и степень ввода числа. 2 - квадрат, 3 куб и так далее

Console.Write("Введите число ");
int numberOne = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int numberTwo = int.Parse(Console.ReadLine());

if(numberOne == numberTwo*numberTwo)
{
Console.Write(" Да ");
}
else
{
Console.Write(" нет ");
}