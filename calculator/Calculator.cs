namespace calculator;

public class Calculator
{
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
            {
                if (num2 == 0)
                    Console.WriteLine("ОШИБКА: Делить на ноль нельзя!");
                else
                    Console.WriteLine($"Результат операции: {num1 / num2}"); 
                break;
            }
            default: 
                Console.WriteLine($"Результат операции не вычислен, введена " +
                                  $"недопустимая арифметическая операция.");
                break;
        }
    }
}