namespace calculator;

public class Calculator
{
    public static double GetNumber(string message)
    {
        while (true)
        {
            Console.Write(message);
            double number;
            string? input = Console.ReadLine()?.Trim();
            if (input != null && !input.Contains(" ") & double.TryParse(input, out number))
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