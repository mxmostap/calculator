namespace calculator;

public class Calculator
{
    public static double GetResult(double num1, double num2, string operation)
    {
        switch (operation)
        {
            case "+": 
                return num1 + num2; 
            case "-": 
                return num1 - num2; 
            case "*": 
                return num1 * num2; 
            case "/":
                if (num2 == 0)
                    throw new DivideByZeroException("ОШИБКА: Делить на ноль нельзя!");
                else
                    return num1 / num2; 
            default:
                throw new Exception("Результат не вычислен, введена недопустимая " +
                                    "арифметическая операция.");
        }
    }
}