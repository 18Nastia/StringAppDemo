using System;
using StringHelper;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        string reversed = Helper.ReverseString(input);
        Console.WriteLine($"Инвертированная строка: {reversed}");
    }
}
