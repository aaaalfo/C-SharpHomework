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
            
             bool isSuccess = double.TryParse(input, out double number);
                if (!isSuccess)
                {
                Console.WriteLine("Нужно было ввести число!");
                }

                else
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

        Console.WriteLine($"Итоговая сумма:"); 
        Console.WriteLine($"{sum}");
    }
}