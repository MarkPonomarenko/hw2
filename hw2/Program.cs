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
            string trimmedString = parser.GetTrimmedString(input);
            int maxIndex = -1;
            bool subject = false;
            switch (option)
            {
                case ConsoleKey.D0:
                    maxIndex = parser.GetMaxNumberIndex(trimmedString);
                    subject = false;
                    break;
                case ConsoleKey.D1:
                    maxIndex = parser.GetMaxDigitIndex(trimmedString);
                    subject = true;
                    break;
                case ConsoleKey.Escape:
                    return;
            }
            Console.WriteLine($"Текст без відступів з початку: {trimmedString}");
            Console.WriteLine($"Індекс макс {(subject ? "цифри" : "числа")}: {maxIndex}");
        }
    }
}