Console.Clear();

string[] array = new string[4] { "hello", "2", "world", ":-)" };
Main(array);

void Main(string[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write($"{array[i]} ");
        }
    }

}