using System;
using System.Collections.Generic;

namespace MathsFunctionsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Math.Max()
            int max = Math.Max(4, 7);
            Console.WriteLine(max); // output: 7

            // Math.Max() - using a list of numbers
            var arrayMaxNumbers = new List<int>() { 3, 6, 1, 8, 4, 1 };
            int maxNumber = arrayMaxNumbers[0];
            foreach (var num in arrayMaxNumbers)
            {
                maxNumber = Math.Max(maxNumber, num);
            }
            Console.WriteLine(maxNumber); // output: 8

            // Math.Min()
            int min = Math.Min(4, 7);
            Console.WriteLine(min); // output: 4

            // Math.Min() - using a list of numbers
            var arrayMinNumbers = new List<int>() { 3, 6, -1, 8, 4, 1 };
            int minNumber = arrayMinNumbers[0];
            foreach (var num in arrayMinNumbers)
            {
                minNumber = Math.Min(minNumber, num);
            }
            Console.WriteLine(minNumber); // output: -1

            // Math.Abs()
            int absoluteNum = Math.Abs(5);
            Console.WriteLine(absoluteNum); // output: 5

            int absoluteNumNegative = Math.Abs(-5);
            Console.WriteLine(absoluteNumNegative); // output: 5

            // Math.Round()
            double roundedDecimals = Math.Round(40.12345, 2);
            Console.WriteLine(roundedDecimals); // output: 40.12

            double roundedNum = Math.Round(40.6);
            Console.WriteLine(roundedNum); // output: 41

            // Math.Truncate()
            double truncatedNum = Math.Truncate(4.5);
            Console.WriteLine(truncatedNum); // output: 4

            // Math.Sin()
            double sinAngle = (90 * (Math.PI)) / 180;
            Console.WriteLine(Math.Sin(sinAngle)); // output: 1

            // Math.Cos()
            double cosAngle = (90 * (Math.PI)) / 180;
            Console.WriteLine(Math.Cos(cosAngle)); // output: 6.123

            // Math.Tan()
            double tanAngle = (30 * (Math.PI)) / 180;
            Console.WriteLine(Math.Tan(tanAngle)); // output: 0.577

            // Math.Pow()
            double powNum = Math.Pow(5, 3);
            Console.WriteLine(powNum); // output: 125

            // Math.Sqrt()
            double sqrtNum = Math.Sqrt(16);
            Console.WriteLine(sqrtNum); // output: 4

        }
    }
}
