using System.Text;

namespace hw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            var speeds = CarProcessor.GenerateCarData();
            var maxSpeeds = CarProcessor.FindMaxSpeedCar(speeds);
            Console.WriteLine($"Швидкість [{string.Join(", ", speeds)}]");
            Console.WriteLine($"Індекс першого максимального: {maxSpeeds.Item1}, останнього: {maxSpeeds.Item2}");
        }
    }
}