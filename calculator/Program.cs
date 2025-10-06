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
                double number1 = InputHandler.GetNumber("Введите первое число:");
                string? operation = InputHandler.GetOperation();
                double number2 = InputHandler.GetNumber("Введите второе число:");

                if (operation != null) Calculator.GetResult(number1, number2, operation);

                Console.Write("Чтобы выйти из программы введите 'exit',\n" +
                              "чтобы продолжить введите любые символы: ");
                if (Console.ReadLine()?.ToLower() == "exit") break;
                else
                    Console.Clear();
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