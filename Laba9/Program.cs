using Newtonsoft.Json;
using Laba9class;
using System.Text.Json.Serialization;
using HtmlAgilityPack;
using System.Threading.Channels;
namespace Laba9
{
    internal class Program
    {
        static async Task Main()
        {
            //Person2 anton = new("Anton");
            //Fruit apple = new() { Name = "Яблоко", Quantity = 5 };
            //string json = JsonConvert.SerializeObject(apple);
            //Console.WriteLine(json);
            //var deserialized=JsonConvert.DeserializeObject<Fruit>(json);
            //Console.WriteLine($"Объект: {deserialized?.Name} - {deserialized.Quantity}");
            Console.Write("Введите URL сайта: ");
            string? url = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(url))
            {
                try
                {
                    HttpClient client = new HttpClient();
                    string html = await client.GetStringAsync(url);
                    HtmlDocument doc = new HtmlDocument();
                    doc.LoadHtml(html);
                    var titleNode = doc.DocumentNode.SelectSingleNode("//title");
                    if (titleNode != null)
                    {
                        Console.WriteLine($"Заголовок страницы: {titleNode.InnerText}");
                    }
                    else
                    {
                        Console.WriteLine("Заголовок не зайден");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("URL не может быть пустым.");
            }
        }
    }
    public class Fruit
    {
        public string? Name { get; set; }
        public int Quantity {  get; set; }
    }
}
