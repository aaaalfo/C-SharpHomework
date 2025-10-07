using System;

namespace ForthTask
{
    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();
            string specialCharacters = "!@#$%^&*";
            bool digitFlag = false;
            bool uppercaseFlag = false;
            bool specialFlag = false;
            int passwordLength = password.Length;
            if (passwordLength < 8)
            {
                Console.WriteLine("Первый критерий не выполнен");
            }
            foreach (char chr in password)
            {
                if (char.IsDigit(chr))
                {
                    digitFlag = true;
                }
                if (char.IsUpper(chr))
                {
                    uppercaseFlag = true;
                }
                if (specialCharacters.Contains(chr))
                {
                    specialFlag = true;
                }
            }
            if (!digitFlag)
            {
                Console.WriteLine("Второй критерий не выполнен");
            }
            if (!uppercaseFlag)
            {
                Console.WriteLine("Третий критерий не выполнен");
            }
            if (!specialFlag)
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
