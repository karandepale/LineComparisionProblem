using System;

namespace LineComparisonProblem
{
    internal class Line
    {
        private double x1, y1, x2, y2;

        public Line(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public double CalculateLength()
        {
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;
            double length = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return length;
        }

        public bool Equals(Line other)
        {
            if (other == null)
                return false;

            return x1 == other.x1 && y1 == other.y1 && x2 == other.x2 && y2 == other.y2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line comparison problem");

            Line line1 = ReadLine("Enter the first line");
            Line line2 = ReadLine("Enter the second line");

            double length1 = line1.CalculateLength();
            double length2 = line2.CalculateLength();

            Console.WriteLine("The length of the first line is: " + length1);
            Console.WriteLine("The length of the second line is: " + length2);

            if (line1.Equals(line2))
            {
                Console.WriteLine("The two lines are equal.");
            }
            else
            {
                Console.WriteLine("The two lines are not equal.");
            }
        }

        static Line ReadLine(string message)
        {
            Console.WriteLine(message);

            Console.Write("Enter the x-coordinate of the first point: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the y-coordinate of the first point: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the x-coordinate of the second point: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the y-coordinate of the second point: ");
            double y2 = double.Parse(Console.ReadLine());

            return new Line(x1, y1, x2, y2);
        }
    }
}
