namespace Hard_Hello_User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            if (userName == "Masha")
            {
                Console.WriteLine($"Oh! Hi {userName}");
            }
            else { 
            Console.WriteLine($"Hello, {userName}");
            }
            Console.ReadLine();
        }
    }
}
