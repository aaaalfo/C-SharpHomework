using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        
        int secretNumber = random.Next(1, 11);
        int userGuess;
        
        do
        {

            string input = Console.ReadLine();
            
            if (int.TryParse(input, out userGuess))
            {
                
                if (userGuess == secretNumber)
                {
                    Console.WriteLine($"Поздравляем! Вы угадали число {secretNumber}!");
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
            
        } while (userGuess != secretNumber);
    }
}
