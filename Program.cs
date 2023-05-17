using System;

namespace LineComparisonProblem
{
    internal class Program
    {
        static double CalculateLength(double x1, double y1, double x2, double y2)
        {
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;
            double length = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            return length;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line comparison problem");

            // Prompt the user to enter the coordinates of the first point
            Console.Write("Enter the x-coordinate of the first point: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the y-coordinate of the first point: ");
            double y1 = double.Parse(Console.ReadLine());

            // Prompt the user to enter the coordinates of the second point
            Console.Write("Enter the x-coordinate of the second point: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the y-coordinate of the second point: ");
            double y2 = double.Parse(Console.ReadLine());

            // Calculate the length of the line
            double length = CalculateLength(x1, y1, x2, y2);
            Console.WriteLine("The length of the line is: " + length);
        }
    }
}

