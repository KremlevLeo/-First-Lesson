namespace DTN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            double res = a / b;
            Console.WriteLine($"The division is: {res}");
            Console.ReadLine();
        }
    }
}
