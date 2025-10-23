/*
 * Adam Goltsman
 * IGME 201
 * due Oct 12
 */


namespace grade_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            string studentName = "Adam";
            int[] grades = new int[] { 100, 92, 87, 200, -20, 52, 82, 75, 67, 88 };
            double average = 0.0;

            Console.WriteLine("Hey there, " +  studentName + "!");
            Console.WriteLine("Here are your grades:");
            Console.WriteLine(""); // empty WriteLines like this are for spacing

            foreach (var grade in grades)
            {
                if(grade >= 90 && grade <= 100) 
                {
                    Console.WriteLine("Great, you got an A!");
                    if(grade == 100)
                    {
                        Console.WriteLine("(WHOAH!!! Perfect score!)");
                    }
                    Console.WriteLine("");
                }

                if(grade >= 80 && grade <= 89) 
                {
                    Console.WriteLine("Nice, you got a B.");
                    Console.WriteLine("");
                }

                if (grade >= 70 && grade <= 79) 
                {
                    Console.WriteLine("Good, you got a C.");
                    Console.WriteLine("");
                }

                if (grade >= 65 && grade <= 69)
                {
                    Console.WriteLine("Good effort, you got a D.");
                    Console.WriteLine("");
                }

                if (grade >= 0 && grade <= 64)
                {
                    Console.WriteLine("Oh man, you got an F...");
                    Console.WriteLine("");
                }

                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Huh?! That's not a grade that's supposed to happen...");
                    Console.WriteLine("");
                }

                average += grade;
            }

            Console.WriteLine("");
            average = average / grades.Length;
            Console.WriteLine("here is the average: " + average);
            Console.WriteLine("That's all the grades, end program.");
        }
    }
}
