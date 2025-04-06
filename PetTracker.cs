using System;

namespace PetTracking
{
    public class Program
    {
        struct Pet
        {
            public string Name;
            public string Species;
        }
        
        public static void Main(string[] args)
        {
            Pet[] pets = new Pet[3];
            
            pets[0].Name = "Jack";
            pets[0].Species = "Dog";
            
            pets[1].Name = "May";
            pets[1].Species = "Cat";
            
            pets[2].Name = "Hank";
            pets[2].Species = "Fish";
            
            for (int i = 0; i < pets.Length; i++)
            {
                Console.WriteLine($"Name: {pets[i].Name}, Species: {pets[i].Species}");
            }
        }
    }
} 