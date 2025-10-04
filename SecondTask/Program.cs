using System;

class Program
{
    static void Main()
    {
        double sum = 0;
        
        
        while (true)
        {

            string input = Console.ReadLine();
            
            if (double.TryParse(input, out double number))
            {
                if (number == 0)
                {
                    break;
                }

                sum += number;
                Console.WriteLine(sum);
            }
        }
        
        Console.WriteLine(sum);
    }
}