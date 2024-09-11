namespace The_maximum_of_six
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write($"Enter second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.Write($"Enter third number: ");
            int thirdNum = int.Parse(Console.ReadLine());
            Console.Write($"Enter fourth number: ");
            int fourtgNum = int.Parse(Console.ReadLine());
            Console.Write($"Enter fifth number: ");
            int fifthNum = int.Parse(Console.ReadLine());
            Console.Write($"Enter sixth number: ");
            int sixthNum = int.Parse(Console.ReadLine());
            int max = firstNum;
            if (max < secondNum) max = secondNum;
            if (max < thirdNum) max = thirdNum;
            if (max < fourtgNum) max = fourtgNum;
            if (max < fifthNum) max = fifthNum;
            if (max < sixthNum) max = sixthNum;
            Console.WriteLine($"The maximum of six numbers is: {max}");
        }
    }
}
