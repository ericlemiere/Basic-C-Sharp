using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name");
            string name = Console.ReadLine();
            string date = DateTime.Today.ToShortDateString();
            string msg = $"\nWelcome, {name}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\ericr\Documents\GitHub\Basic-C-Sharp\Scores\Scores\scores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            double totalScore = 0;

            Console.WriteLine("\nStudent Scores:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
                double score = Convert.ToDouble(line);
                totalScore += score;
            }

            double average = totalScore / lines.Length;

            Console.WriteLine("Total of " + lines.Length + " student scores. The average score is: " + average);

        }
    }
}
