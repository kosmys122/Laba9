using Newtonsoft.Json;
namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartLight lampa = new();
            lampa.OnStateChanged += OnStateChanged;
            lampa.Toggle(false, 5);
            lampa.Toggle(false, 1);
            string json = JsonConvert.SerializeObject(lampa);
            Console.WriteLine("В JSON: "+json);
        }
        static void OnStateChanged()
        {
            Console.WriteLine("Свет включён / Свет выключен");
        }
    }
}
