using System.Globalization;
using System.Text.RegularExpressions;

namespace calculator;

public class Calculator
{
    public static double GetNumber(string message)
    {
        while (true)
        {
            Console.Write(message);
            double number;
            if (double.TryParse(GetConsoleInput(@"\d+\,?\d+"), out number))
                return number;
            else 
                Console.WriteLine("Ошибка ввода - Вы ввели не число. Повторите ввод.");
        }
    }

    static string GetConsoleInput(string rule)
    {
        ConsoleKeyInfo key;
        var input = "";
        while(true)
        {
            key = Console.ReadKey(true);
            if(key.Key == ConsoleKey.Enter)
                break;
            if(Regex.IsMatch(key.KeyChar.ToString(), rule))
            {
                input += key.KeyChar;
                Console.Write(key.KeyChar);
            }
        }

        return input;
    }
    public static string GetSystemSeparator()
    {
        CultureInfo currentCulture = CultureInfo.CurrentCulture;
        return currentCulture.NumberFormat.NumberDecimalSeparator;
    }

    public static string GetOperation()
    {
        //string[] validOperations = {"+", "-", "*", "/"};
        while (true)
        {
            Console.WriteLine("Доступные арифметические операции: '+','-','*','/'.");
            Console.Write("Введите арифметическую операцию: ");
            //string? input = Console.ReadLine().Replace(" ", "");
            string input = GetConsoleInput(@"[+-*/]");
            //if (validOperations.Contains(input)) 
              //  return input;    
            //else
              //  Console.WriteLine("Ошибка ввода. Введите операцию из списка доступных.");
              return input;
        }
    }
    
    public static void GetResult(double num1, double num2, string operation)
    {
        switch (operation)
        {
            case "+": 
                Console.WriteLine($"Результат операции: {num1 + num2}"); 
                break;
            case "-": 
                Console.WriteLine($"Результат операции: {num1 - num2}"); 
                break;
            case "*": 
                Console.WriteLine($"Результат операции: {num1 * num2}"); 
                break;
            case "/": 
                Console.WriteLine($"Результат операции: {num1 / num2}"); 
                break;
            default: 
                Console.WriteLine($"Результат операции: 0");
                break;
        }
    }
}