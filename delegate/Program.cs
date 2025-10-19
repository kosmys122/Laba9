namespace Delegate
{
    internal class Program
    {
    static void Main(string[] args)
    {
        MassegeHandler handler = ShowMessage;
        handler("Hello");
        MasseageNum num = Double;
        num += Square;
        num(10);
    }
    static void ShowMessage(string message)
    {
        Console.WriteLine($"Message {message}");
    }
    static void Double(int num)
    {
        Console.WriteLine($"Удвоенно {num * 2}");
    }
    static void Square(int num)
    {
        Console.WriteLine($"Квадрат {num * num}");
    }
    public delegate void MassegeHandler(string text);
    public delegate void MasseageNum(int num);
    }
}
