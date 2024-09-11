namespace Triangle_and_dots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int xA = 26;
            int yA = 2;
            int xB = 1;
            int yB = 20;
            int xC = 52;
            int yC = 20;
            int x = xA, y = yA;
            int count = 0;
            while (count < 1000000)
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
