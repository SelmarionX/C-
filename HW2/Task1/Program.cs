// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Введите первое число ");
int a1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int a2 = int.Parse(Console.ReadLine());
int max = a1;
int min = a2;
if (a1 > max) max = a1;
if (a2 > max) max = a2;
if (a1 < max) min = a1;
if (a2 < max) min = a2;
Console.WriteLine(("Большее число ", (max)));
Console.WriteLine(("Меньшее число ", (min)));
