using System.Text;

namespace hw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            StringParser parser = new StringParser();
            Console.WriteLine("Введіть текст:");
            string input;
            do
            {
                input = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(input));
            Console.WriteLine("Виділити цифри чи числа? (1/0)");
            ConsoleKey[] readKeys = { ConsoleKey.Escape, ConsoleKey.D0, ConsoleKey.D1 };
            ConsoleKey option;
            do
            {
                option = Console.ReadKey(true).Key;
            } while (!readKeys.Contains(option));
            List<int> numbers = new List<int>();
            switch (option)
            {
                case ConsoleKey.D0:
                    numbers = parser.GetNumbers(input);
                    Console.WriteLine($"Виділені числа [ {string.Join(", ", numbers)} ]");
                    break;
                case ConsoleKey.D1:
                    numbers = parser.GetDigits(input);
                    Console.WriteLine($"Виділені цифри [ {string.Join(", ", numbers)} ]");
                    break;
                case ConsoleKey.Escape:
                    return;
            }
            int sum = parser.GetSum(numbers);
            int max = parser.GetMax(numbers);
            Console.WriteLine($"Максимальне = {max}, Сума = {sum}");
        }
    }
}