using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите температуру в градусах Цельсия:");
        string input = Console.ReadLine();
        double celsius;
        bool isSuccess = double.TryParse(input, out celsius);
        if (!isSuccess)
        {
            Console.WriteLine("Неверный формат числа!");
            Environment.Exit(0);
        }

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"Температура в градусах Фаренгейта: {celsius}°C = {fahrenheit}°F"); 
    }
}