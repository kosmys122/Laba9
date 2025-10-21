namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void PrintLength(string? input)
            {
                if (input==null)
                    Console.WriteLine("Строка отсутствует!");
                else
                    Console.WriteLine(input.Length);
            }
            PrintLength(null);
            PrintLength("31");
        }
    }
}
