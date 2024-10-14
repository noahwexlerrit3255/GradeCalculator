namespace ConsoleApp1
{
/* 
    Noah Wexler
    IGME.201
    Due: 10/13/2024
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = "Noah wexler";
            int[] grades = { 100, 92, 87, 200, -20, 52, 82, 75, 67, 88 };

            Console.WriteLine("Welcome, " + studentName + "!");
            Console.WriteLine("Here are your grades:");

            int sum = 0;
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);

                if (grade >= 90 && grade <= 100)
                {
                    Console.WriteLine("This grade is an A!");
                    if (grade == 100)
                    {
                        Console.WriteLine("wowsers a perfect score!");
                    }
                }
                else if (grade >= 80 && grade <= 89)
                {
                    Console.WriteLine("This grade is a B");
                }
                else if (grade >= 70 && grade <= 79)
                {
                    Console.WriteLine("This grade is a C");
                }
                else if (grade >= 65 && grade <= 69)
                {
                    Console.WriteLine("This grade is a D");
                }
                else if (grade >= 0 && grade <= 64)
                {
                    Console.WriteLine("This grade is an F");
                }
                else
                {
                    Console.WriteLine("This is out of the range of 0-100. How did you even get this grade? (inverse of negative i!!!!!!)");
                }

                sum += grade;
            }

            double average = sum / (double)grades.Length;
            Console.WriteLine("our average grade is: " + average);
            Console.WriteLine("We have displayed all grades for " + studentName + ".");
        }
    }
}
