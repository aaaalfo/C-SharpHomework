using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int secretNumber = random.Next(1, 11);
        int userGuess;

        while (true)
            {
            Console.WriteLine("Введите число:");
            string input = Console.ReadLine();
            bool isSuccess = int.TryParse(input, out userGuess);
            if (!isSuccess)
            {
            Console.WriteLine("Надо было ввести число!");
            }   
            else
            {

                if (userGuess == secretNumber)
                {
                    Console.WriteLine($"Поздравляем! Вы угадали число {secretNumber}!");
                    break;
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine("Загаданное число больше");
                }
                else
                {
                    Console.WriteLine("Загаданное число меньше");
                }
            }

        }
    }
}
