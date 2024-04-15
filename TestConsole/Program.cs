namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день");
            Console.WriteLine("Введите число 1");
            int FirstNumber =Convert.ToInt32(Console.ReadLine());
            TestInput("первое число ", FirstNumber);
            Console.WriteLine("Введите число 2");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            TestInput("второе число ", SecondNumber);
            Console.WriteLine ("Матрица чисел: " + FirstNumber+" "+SecondNumber);
            for (int i = 1; i <= FirstNumber; i++)
            {
                for(int j = 1; j <= SecondNumber; j++)
                {
                    Console.WriteLine(i * j );
                }
                Console.WriteLine();
            }

        }
        static void TestInput(string virable , int value)
        {
            Console.WriteLine($"Вы ввели {virable} со значением {value}");
        }
    }
}