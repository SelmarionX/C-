
Console.Write("Введите номер недели ");
int a = int.Parse(Console.ReadLine());
//if (a > 0 && a < 8)
switch (a)
{
    case 1: Console.WriteLine("понедельник"); break;
    case 2: Console.WriteLine("вторник"); break;
    case 3: Console.WriteLine("среда"); break;
    case 4: Console.WriteLine("четверг"); break;
    case 5: Console.WriteLine("пятница"); break;
    case 6: Console.WriteLine("суббота"); break;
    case 7: Console.WriteLine("воскресенье"); break;
    default: Console.WriteLine("ошибка"); break; //без default switch не работает
}


/*Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
if (number < 1 || number > 7)
{
    Console.WriteLine("error");
}
if (number == 1)
{
    Console.Write(" понедельник ");
}
if (number == 2)
{
    Console.Write(" вторник ");
}
if (number == 3)
{
    Console.Write(" среда ");
}
if (number == 4)
{
    Console.Write(" четверг ");
}
if (number == 5)
{
    Console.Write(" пятница ");
}
if (number == 6)
{
    Console.Write(" суббота ");
}
if (number == 7)
{
    Console.Write(" воскресенье ");
} */