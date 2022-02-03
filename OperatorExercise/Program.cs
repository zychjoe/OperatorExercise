using System;

namespace OperatorExercise
{
    class Program
    {

        public static double AreaOfCircle(double rad)
        {
            return rad * rad * Math.PI; 
        }


        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            Console.WriteLine($"The Area of a circle with radius {radius} is {area}.");
        }
    }
}
