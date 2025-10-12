using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int celsius;
        bool isSuccess = int.TryParse(input, out celsius);
        if (!isSuccess)
        {
            Console.WriteLine("Неверный формат числа!");
            Environment.Exit(0);
        }

        double fahrenheit = (celsius * 9 / 5) + 32;
        
        Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
    }
}