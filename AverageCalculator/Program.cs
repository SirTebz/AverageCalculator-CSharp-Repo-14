using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AverageCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Methods

            Console.WriteLine("*-----------------------------*");
            Console.WriteLine("|Average Percentage Calculator|");
            Console.WriteLine("*-----------------------------*");
            Console.WriteLine();
            
            // Get the total and the user's score for the first test
            Console.Write("Total for test 1: ");
            int iTest1Total = int.Parse(Console.ReadLine());
            Console.Write("Your mark for test 1: ");
            double dTest1Score = double.Parse(Console.ReadLine());
            
            // Get the total and the user's score for the second test
            Console.Write("Total for test 2: ");
            int iTest2Total = int.Parse(Console.ReadLine());
            Console.Write("Your mark for test 2: ");
            double dTest2Score = double.Parse(Console.ReadLine());
            
            // Convert the user's test scores to percentages
            ConvertToPercentage(ref dTest1Score, iTest1Total);
            ConvertToPercentage(ref dTest2Score, iTest2Total);
            
            // Call GetAverage() to calculate the average percentage and display that average
            // using DisplayAverage
            DisplayAverage(dTest1Score, dTest2Score, GetAverage(dTest1Score, dTest2Score));
            
            Console.Write("\nPress any key to exit... ");
            Console.ReadKey();
        }
        private static void ConvertToPercentage(ref double dTestScore, int iTestTotal)
        {
            dTestScore = (dTestScore / iTestTotal) * 100;
        }

        public static double GetAverage(double dTest1, double dTest2)
        {
            return (dTest1 + dTest2) / 2.0;
        }
        private static void DisplayAverage(double dTest1, double dTest2, double dAverage)
        {
            Console.WriteLine();
            Console.WriteLine("You scored " + dTest1.ToString("0.00") + "% for the first test and " + dTest2.ToString("0.00") + "% for the second test.");
            Console.WriteLine("Your average is " + dAverage.ToString("0.00") +"%");

        }

    }
}
