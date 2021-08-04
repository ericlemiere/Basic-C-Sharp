using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("State Tax Calculator");
            Console.WriteLine("\nPlease enter your yearly income:");
            int income = Convert.ToInt32(Console.ReadLine());

            Taxes incomeAfterTax = new Taxes();
            Console.Write("Your income after state taxes in Texas would be: $");
            Console.WriteLine(incomeAfterTax.Texas(income));
            Console.Write("Your income after state taxes in Colorado would be: $");
            Console.WriteLine(incomeAfterTax.Colorado(income));
            Console.Write("Your income after state taxes in California would be: $");
            Console.WriteLine(incomeAfterTax.California(income));
        }
    }
}
