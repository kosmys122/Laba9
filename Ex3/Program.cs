namespace Ex3
{
    internal class Program
    {
        public delegate void Logger(string message);
        static void Main(string[] args)
        {
            void LogToConsole(string message)
            {
                Console.WriteLine(message);
            }
            Logger print = LogToConsole;
            print("Задание номер 3 выполнено");
        }
    }
}
