using System.Globalization;
using static System.Globalization.NumberStyles;

namespace calculator;

public class InputHandler
{
    public static double GetNumber(string message)
    {
        while (true)
        {
            Console.Write(message);
            double number;
            string? input = Console.ReadLine()?.Trim();
            if (double.TryParse(input, NumberStyles.Float | NumberStyles.AllowThousands, 
                    new CultureInfo("en-US"), out number))
                return number;
            else 
                Console.WriteLine("Ошибка ввода - Вы ввели не число. Повторите ввод.");
        }
    }
    public static string? GetOperation()
    {
        string[] validOperations = {"+", "-", "*", "/"};
        while (true)
        {
            Console.WriteLine("Доступные арифметические операции: '+','-','*','/'.");
            Console.Write("Введите арифметическую операцию: ");
            string? input = Console.ReadLine();
            if (validOperations.Contains(input)) 
                return input;    
            else
                Console.WriteLine("Ошибка ввода. Введите операцию из списка доступных.");
        }
    }
}