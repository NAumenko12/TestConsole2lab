namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Добрый день");
                Console.WriteLine("Введите число 1");
                string input1 = Console.ReadLine();
                if (!IsNumberValid(input1))
                {
                    throw new ArgumentException("Введено неверное значение для числа 1");
                }
                double FirstNumber;
                if (!double.TryParse(input1, out FirstNumber) || FirstNumber <= 0)
                {
                    throw new ArgumentException("Введено неверное значение для числа 1");
                }
                Console.WriteLine("Введите число 2");
                string input2 = Console.ReadLine();
                if (!IsNumberValid(input2))
                {
                    throw new ArgumentException("Введено неверное значение для числа 2");
                }
                double SecondNumber;
                if (!double.TryParse(input2, out SecondNumber) || SecondNumber <= 0)
                {
                    throw new ArgumentException("Введено неверное значение для числа 2");
                }
                TestInput("первое число ", FirstNumber);
                TestInput("второе число ", SecondNumber);
                Console.WriteLine("Матрица чисел: " + FirstNumber + " " + SecondNumber);
                for (int i = 1; i <= FirstNumber; i++)
                {
                    for (int j = 1; j <= SecondNumber; j++)
                    {
                        Console.WriteLine(i * j);
                    }
                    Console.WriteLine();
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Произошла ошибка: {e.Message}");
            }
        }
        static void TestInput(string virable, double value)
        {
            Console.WriteLine($"Вы ввели {virable} со значением {value}");
        }
        static bool IsNumberValid(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c) && c != '.' && c != ',' && c != '%' && c != '*' && c != '$' && c != '?')
                {
                    return false;
                }
            }
            return true;
        }
    }
}

 


