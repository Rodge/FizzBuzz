using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        /// <summary>
        /// Returns "FizzBuzz" if divisible by 3 and 5, "Fizz" if by 3, "Buzz" by 5 and just the (same) input if neither. 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Compute(int input)
        {
            bool fizz = input % 3 == 0;
            bool buzz = input % 5 == 0;

            if (fizz && buzz)
                return "FizzBuzz";

            if (fizz)
                return "Fizz";

            if (buzz)
                return "Buzz";

            return input.ToString();
        }

        /// <summary>
        /// Writes lines to the console app for the fizzbuzz computation of 1 until 100 or the given end by any first value in the console app arguments (<paramref name="args"/>. 
        /// </summary>
        /// <param name="args">Console app arguments</param>
        public static void Main(string[] args)
        {
            if (args.Length > 0 && int.TryParse(args[0], out int givenEnd))
                WriteLinesForComputeUntil(givenEnd);
            else 
                WriteLinesForComputeUntil(100);
        }

        private static void WriteLinesForComputeUntil(int theEnd)
        {
            for (int i = 1; i <= theEnd; i++)
                Console.WriteLine(Compute(i));
        }
    }
}
