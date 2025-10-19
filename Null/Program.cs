using System.Threading.Channels;

namespace Null
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string? name = null;
            //Console.WriteLine(name?.Length);
            //string result = name ?? "Defult";
            //int? num = null;
            //num = 10;
            //string? GetUserName(int id)
            //{
            //    return id == 1 ? "Alice" : null;
            //}
            //var user = GetUserName(2);
            //Console.WriteLine(user?.ToUpper());
            //string? input = Console.ReadLine();
            //if (input!=null)
            //    Console.WriteLine($"Вы ввели: {input}");
            //else
            //    Console.WriteLine("Вы ниего не ввели");
            //List<string?> names = new() { "Anna", null, "Bob" };
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name?.Length ?? 0);
            //}

            int? num1 = 5;
            Nullable<int> num2 = 5;
            PrintNullable(5);
            PrintNullable(null);
            void PrintNullable(int? num)
            {
                if (num.HasValue)
                {
                    Console.WriteLine(num.Value);
                    Console.WriteLine(num);
                }
                else
                    Console.WriteLine("параметр равен null");
            }
            //int? num = null;
            //Console.WriteLine(num.Value);
            //Console.WriteLine(num);
            int? num = null;
            Console.WriteLine(num.GetValueOrDefault());
            Console.WriteLine(num.GetValueOrDefault(10));
            num = 15;
            Console.WriteLine(num.GetValueOrDefault());
            Console.WriteLine(num.GetValueOrDefault(10));
        }
    }
}
