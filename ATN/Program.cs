namespace ATN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            int res = a + b;
            Console.WriteLine($"The amount is equal to: {res}");
            Console.ReadLine();
        }
    }
}
