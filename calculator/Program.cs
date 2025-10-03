using calculator;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Вас привествует консольный калькулятор!");
            Console.WriteLine($"Вещественные числа необходимо вводить через символ: '{Calculator.GetSystemSeparator()}'");
            Console.WriteLine();
            try
            {
                double number1 = Calculator.GetNumber("Введите первое число:");
                string operation = Calculator.GetOperation();
                double number2 = Calculator.GetNumber("Введите второе число:");
                if (operation == "/" & number2 == 0) 
                {
                    Console.WriteLine("ОШИБКА: Делить на ноль нельзя!");
                    Console.Write("Чтобы выйти из программы введите 'exit',\n чтобы продолжить введите любые символы: ");
                    if (Console.ReadLine() == "exit") break;
                    else
                    {
                        Console.Clear();
                        continue;
                    }
                }
                Calculator.GetResult(number1, number2, operation);

                Console.Write("Чтобы выйти из программы введите 'exit',\n чтобы продолжить введите любые символы: ");
                if (Console.ReadLine() == "exit") break;
                else
                {
                    Console.Clear();
                    continue;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Вызвано исключение: {1}", e.Message);
            }
        }
    }
}