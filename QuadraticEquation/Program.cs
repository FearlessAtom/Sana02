namespace QuadraticEquation
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Console.Write("What is the value of a? : ");
            double a = double.Parse(Console.ReadLine());
            if (a == 0) { Console.WriteLine("Invalid user input!"); return 1; }
            Console.Write("What is the value of b? : ");
            double b = double.Parse(Console.ReadLine());
            if (b == 0) { Console.WriteLine("Invalid user input!"); return 1; }
            Console.Write("What is the value of c? : ");
            double c = double.Parse(Console.ReadLine());
            if (c == 0) { Console.WriteLine("Invalid user input!"); return 1; }
            double d = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine($"D = {d}");
            if (d < 0) { Console.WriteLine("The equations has no roots!"); return 0; }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"The equation has one root : {x}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"x1 = {x1},x2 = {x2}");

            }

            return 0;
        }
    }
}