using System;
using System.Formats.Asn1;

namespace ForthTask
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Введите пароль. Он должен удовлетворять следующим критериям:");
            Console.WriteLine("● Длина не менее 8 символов");
            Console.WriteLine("● Содержит хотя бы одну цифру");
            Console.WriteLine("● Содержит хотя бы одну заглавную букву");
            Console.WriteLine("● Содержит хотя бы один специальный символ (!@#$%^&*)");

            string password = Console.ReadLine();

            string specialCharacters = "!@#$%^&*";

            bool digitFlag = false;
            bool uppercaseFlag = false;
            bool specialFlag = false;
            
            int passwordLength = password.Length;

            if (passwordLength < 8)
            {
                Console.WriteLine("● Первый критерий не выполнен");
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
                Console.WriteLine("● Второй критерий не выполнен");
            }
            if (!uppercaseFlag)
            {
                Console.WriteLine("● Третий критерий не выполнен");
            }
            if (!specialFlag)
            {
                Console.WriteLine("● Четвертый критерий не выполнен");
            }

            else if (specialFlag && uppercaseFlag && digitFlag && passwordLength >= 8) 
            {
                Console.WriteLine("Пароль удовлетворяет всем критериям!");
            }
            
        }
    }
}
