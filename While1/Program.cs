namespace While1
{
    internal class Program
    {
        static double firstone(){
            Console.Write("Enter a number : ");
            int number = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int index = 1; index <= number; index++)
            {
                sum = sum + Math.Pow(-1, index) / (2 * index + 1);
            }
            return sum;
        }
        static double secondone()
        {
            Console.Write("Enter a number : ");
            int number = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int index = 1; index <= number; index++)
            {
                sum = sum + (1 + 1/Math.Pow(index,2));
            }
            return sum;
        }
        static double thirdone()
        {
            Console.WriteLine("Enter a positive number");
            int number = int.Parse(Console.ReadLine());
            int result = 0;
            for(int index = 1; index <= number; index++)
            {
                int sum = 1;
                for(int j = 1; j <= index; j++)
                {
                    sum = sum * j;
                }
                result = result + sum;
            }
            return result;
        }
        static int Main(string[] args)
        {
            Console.WriteLine("[1] = -1/3 + 1/5 + ... + -1^2 / (2n + 1)\n" +
                "[2] = (1 + 1/1^2 ) + (1 + 1/2^2) + ... + (1 + 1/n^2)\n" +
                "[3] = 1! + 2! + 3! + ... + n!");
            Console.Write("Enter a number between 1 and 3 : ");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine($"Result = {firstone()}");
                    break;
                case 2:
                    Console.WriteLine($"Result = {secondone()}");
                    break;
                case 3:
                    Console.WriteLine($"Result = {thirdone()}");
                    break;
                default:
                    Console.WriteLine("Enter a number between 1 and 3!");return 1
            }
            return 0;
        }
    }
}