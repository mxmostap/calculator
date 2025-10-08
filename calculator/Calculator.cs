namespace calculator;

public class Calculator
{
    public static string GetResult(double num1, double num2, string operation)
    {
        switch (operation)
        {
            case "+": 
                return (num1 + num2).ToString(); 
            case "-": 
                return (num1 - num2).ToString(); 
            case "*": 
                return (num1 * num2).ToString(); 
            case "/":
                if (num2 == 0)
                    return "ОШИБКА: Делить на ноль нельзя!";
                else
                    return (num1 / num2).ToString(); 
            default: 
                return $"Не вычислен, введена недопустимая арифметическая операция.";
        }
    }
}