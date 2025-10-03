using calculator;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Вас приветствует консольный калькулятор!");
            Console.WriteLine($"Вещественные числа необходимо вводить через символ: " +
                              $"'{GetSystemSeparator()}'");
            Console.WriteLine();
            try
            {
                double number1 = Calculator.GetNumber("Введите первое число:");
                string? operation = Calculator.GetOperation();
                double number2 = Calculator.GetNumber("Введите второе число:");
                if (operation == "/" & number2 == 0) 
                {
                    Console.WriteLine("ОШИБКА: Делить на ноль нельзя!");
                    Console.Write("Чтобы выйти из программы введите 'exit',\n" +
                                  "чтобы продолжить введите любые символы: ");
                    if (Console.ReadLine() == "exit") break;
                    else
                    {
                        Console.Clear();
                        continue;
                    }
                }

                if (operation != null) Calculator.GetResult(number1, number2, operation);

                Console.Write("Чтобы выйти из программы введите 'exit',\n" +
                              "чтобы продолжить введите любые символы: ");
                if (Console.ReadLine()?.ToLower() == "exit") break;
                else
                {
                    Console.Clear();
                    continue;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Вызвано исключение: {e.Message}");
            }
        }
    }
    public static string GetSystemSeparator()
    {
        CultureInfo currentCulture = CultureInfo.CurrentCulture;
        return currentCulture.NumberFormat.NumberDecimalSeparator;
    }
}