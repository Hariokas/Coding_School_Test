using System;

namespace _3_task
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new decimal[10];
            decimal sumOfArray = 0;
            decimal avgOfArray = 0;

            Console.WriteLine("Input the 10 numbers:");

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Number {i+1}: ");
                numbers[i] = Convert.ToDecimal(Console.ReadLine());
                sumOfArray += numbers[i];
            }

            avgOfArray = sumOfArray / numbers.Length;

            Console.WriteLine($"The sum of 10 numbers is: {sumOfArray}");
            Console.WriteLine($"The average is: {avgOfArray}");

        }
    }
}
