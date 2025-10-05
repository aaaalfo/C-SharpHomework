using System;

namespace ForthTask
{
    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();
            string specialCharacters = "!@#$%^&*";
            bool Digit_flag = false;
            bool Uppercase_flag = false;
            bool Special_flag = false;
            int password_length = password.Length;
            if (password_length < 8)
            {
                Console.WriteLine("Первый критерий не выполнен");
            }
            foreach (char chr in password)
            {
                if (char.IsDigit(chr))
                {
                    Digit_flag = true;
                }
                if (char.IsUpper(chr))
                {
                    Uppercase_flag = true;
                }
                if (specialCharacters.Contains(chr))
                {
                    Special_flag = true;
                }
            }
            if (!Digit_flag)
            {
                Console.WriteLine("Второй критерий не выполнен");
            }
            if (!Uppercase_flag)
            {
                Console.WriteLine("Третий критерий не выполнен");
            }
            if (!Special_flag)
            {
                Console.WriteLine("Четвертый критерий не выполнен");
            }
            else
            {
                Console.WriteLine("Пароль удовлетворяет всем критериям");
            }
            
        }
    }
}
