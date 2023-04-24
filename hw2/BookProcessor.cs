namespace hw2
{
    public class BookProcessor
    {
        public static int[] GeneratePageData()
        {
            Random rnd = new Random();
            return Enumerable.Range(0, 100).Select(_ => rnd.Next(10, 1000)).ToArray();
        }

        public static int FindBookWMaxPages(int[] pages) 
        {
            return pages.Max();
        }
    }
}
