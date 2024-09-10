namespace Hello_user
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");
            Console.ReadLine();
        }
    }
}
