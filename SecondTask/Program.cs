using System;

class Program
{
    static void Main()
    {
        double sum = 0;
        
        Console.WriteLine("Для того, чтобы выйти из программы, нажмите 0");
        while (true)
        {   
            Console.WriteLine("Введите число:");
            string input = Console.ReadLine();
            
            if (double.TryParse(input, out double number))
            {
                if (number == 0)
                {
                    break;
                }
                Console.WriteLine("Cумма введеных чисел:");
                sum += number;
                Console.WriteLine(sum);
            }
        }
        
        Console.WriteLine(sum);
    }
}