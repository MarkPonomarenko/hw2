namespace hw2
{
    public class CarProcessor
    {
        public static int[] GenerateCarData()
        {
            //вирішено робити генерацію цілочисельних типів
            //при генерації чисел з плаваючою крапкою йморівність знаходження двух максимумів мінімальна
            Random rnd = new Random();
            return Enumerable.Range(0, 40).Select(_ => rnd.Next(60, 200)).ToArray();
        }

        public static (int, int) FindMaxSpeedCar(int[] speeds)
        {
            int maxSpeed = speeds.Max();
            var firstIndex = Array.IndexOf(speeds, maxSpeed);
            int maxCount = speeds.Count(speed => speed == maxSpeed);
            return maxCount > 1 ? (firstIndex, Array.LastIndexOf(speeds, maxSpeed)) : (firstIndex, -1);
        }
    }
}
