using System.Text;

namespace hw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            var pages = BookProcessor.GeneratePageData();
            Console.WriteLine($"Сторінки [ {string.Join(", ", pages)} ]");
            var maxPages = BookProcessor.FindBookWMaxPages(pages);
            Console.WriteLine($"Сторінок в найтовшій книжці: {maxPages}");
        }
    }
}