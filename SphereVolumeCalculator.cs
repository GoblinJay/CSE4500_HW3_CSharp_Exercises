using System;

namespace SphereCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This program will calculate the volume of a sphere. Please enter the radius:");
            double radius = Convert.ToDouble(Console.ReadLine());
            
            const double pi = 3.14;
            double volume = (4.0 / 3.0) * pi * Math.Pow(radius, 3);
            
            Console.WriteLine($"The volume of a sphere with radius {radius} is: {volume}");
        }
    }
} 