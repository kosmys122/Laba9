namespace Laba9class
{
    public class Person2
    {
        public string Name { get; set; }
        public Person2(string name)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine(Name);
        }
    }
}
