namespace PointsAverage
{
    internal class Program
    {
        static int Main(string[] args)
        {
            int number = 5;
            int gradecount = 0,sum = 0;
            while (gradecount < number)
            {
                Console.Write($"Grade number {gradecount + 1} : ");
                int grade = int.Parse(Console.ReadLine());
                if(grade < 0 || grade > 100) { Console.WriteLine("Invalid input, grade must be in the range of 0 and 100!");return 1; }
                sum = sum + grade;
                gradecount = gradecount + 1;


            }
            double domain = sum / number;
            Console.WriteLine($"Domain : {domain}");
            if(domain > 50) { Console.WriteLine("Yes");}
            else { Console.WriteLine("No"); }
            return 0;
        }
    }
}