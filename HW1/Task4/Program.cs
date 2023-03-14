/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8 
*/
Console.Clear(); // очищает терминал во время выполнения задачи
Console.WriteLine("Введите трехзначное число ");
int number = int.Parse(Console.ReadLine());
if ((number > 99 && number < 1000) || (number < -99 && number > -1000)) // делаем проверку, что пользователь введёт трехзначное число, если нет, то напишем ошибку
{
    int lastNumber = number % 10;
    if (lastNumber < 0)
    {
        lastNumber = lastNumber * -1;
    }
    Console.WriteLine(lastNumber);
}
else
{
    Console.WriteLine("Ошибка! Ввели неверное значение задачи");
}