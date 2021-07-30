using System;

namespace PersonComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("\nPerson 1");
            Console.WriteLine("Hourly Wage:");
            string inputWage1 = Console.ReadLine();
            decimal p1wage = Convert.ToDecimal(inputWage1);
            Console.WriteLine("Hours Worked Per Week:");
            string inputHours1 = Console.ReadLine();
            decimal p1hours = Convert.ToDecimal(inputHours1);

            Console.WriteLine("\nPerson 2");
            Console.WriteLine("Hourly Wage:");
            string inputWage2 = Console.ReadLine();
            decimal p2wage = Convert.ToDecimal(inputWage2);
            Console.WriteLine("Hours Worked Per Week:");
            string inputHours2 = Console.ReadLine();
            decimal p2hours = Convert.ToDecimal(inputHours2);

            decimal p1salary = p1wage * p1hours * 52;
            decimal p2salary = p2wage * p2hours * 52;

            Console.WriteLine("\nPerson 1 has an annual salary of $" + p1salary);
            Console.WriteLine("\nPerson 2 has an annual salary of $" + p2salary);

            Console.WriteLine("\nDoes Person 1 make more per year than Person 2?");
            Console.WriteLine(p1salary > p2salary);



        }
    }
}
