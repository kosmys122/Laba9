namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thermometer item = new();
            item.TemperatureTooHigh += () => Console.WriteLine("Срочно снизте температуру!");
            item.Measure(10);
            item.Measure(33);
            item.Measure(80);
            item.Measure(1);
        }
    }
}
