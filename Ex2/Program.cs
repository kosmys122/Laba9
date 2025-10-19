using HtmlAgilityPack;
namespace Ex2
{
    internal class Program
    {
        static async Task Main()
        {
            Console.Write("Введите URL сайта: ");
            string? url = Console.ReadLine();
            HtmlDocument doc = new();
            HttpClient client = new();
            string html = await client.GetStringAsync(url);
            doc.LoadHtml(html);
            var titleNode = doc.DocumentNode.SelectSingleNode("//title");
            Console.WriteLine(titleNode.InnerText);
        }
    }
}
