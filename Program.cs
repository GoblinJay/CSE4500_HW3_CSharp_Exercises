using System;

namespace MainProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool continueRunning = true;
            
            while (continueRunning)
            {
                Console.Clear(); // Clear the console for cleaner display
                Console.WriteLine("Choose a program to run:");
                Console.WriteLine("1. Sphere Volume Calculator");
                Console.WriteLine("2. Cylinder Volume Calculator");
                Console.WriteLine("3. Pet Tracker");
                Console.WriteLine("4. Student Group Tracker");
                Console.WriteLine("5. Exit");
                
                string? choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        SphereCalculator.Program.Main(args);
                        Console.WriteLine("\nPress Enter to return to main menu...");
                        Console.ReadLine();
                        break;
                    case "2":
                        CylinderCalculator.Program.Main(args);
                        Console.WriteLine("\nPress Enter to return to main menu...");
                        Console.ReadLine();
                        break;
                    case "3":
                        PetTracking.Program.Main(args);
                        Console.WriteLine("\nPress Enter to return to main menu...");
                        Console.ReadLine();
                        break;
                    case "4":
                        StudentTracking.Program.Main(args);
                        Console.WriteLine("\nPress Enter to return to main menu...");
                        Console.ReadLine();
                        break;
                    case "5":
                        continueRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        Console.WriteLine("\nPress Enter to continue...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
} 