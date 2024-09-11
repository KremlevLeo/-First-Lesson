namespace Triangle_and_dots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int xA = 25;
            int yA = 2;
            int xB = 1;
            int yB = 20;
            int xC = 50;
            int yC = 20;
            Console.SetCursorPosition(xA, yA);
            Console.WriteLine("+");
            Console.SetCursorPosition(xB, yB);
            Console.WriteLine("+");
            Console.SetCursorPosition(xC, yC);
            Console.WriteLine("+");
            int x = xA, y = yA;
            int count = 0;
            while (count < 1000)
            {
                int what = new Random().Next(0, 3);
                if (what == 0)
                {
                    x = (x + xA) / 2;
                    y = (y + yA) / 2;
                }
                if (what == 1)
                {
                    x = (x + xB) / 2;
                    y = (y + yB) / 2;
                }
                if (what == 2)
                {
                    x = (x + xC) / 2;
                    y = (y + yC) / 2;
                }
                Console.SetCursorPosition(x, y);
                Console.WriteLine("+");
                count++;
            }
            Console.ReadLine();
        }
    }
}
