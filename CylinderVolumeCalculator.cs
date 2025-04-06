using System;

namespace CylinderCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This program will calculate the volume of a cylinder. Please enter the radius:");
            double radius = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Now enter the height:");
            double height = Convert.ToDouble(Console.ReadLine());
            
            const double pi = 3.14;
            double volume = pi * Math.Pow(radius, 2) * height;
            
            Console.WriteLine($"The volume of a cylinder with radius {radius} and height {height} is: {volume}");
        }
    }
} 