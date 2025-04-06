using System;

namespace StudentTracking
{
    public class Program
    {
        struct Student
        {
            public string firstName;
            public string lastName;
            public string studentID;
        }
        
        public static void Main(string[] args)
        {
            Student[] students = new Student[3];
            
            // First student - You can replace with your own details
            students[0].firstName = "Jason";
            students[0].lastName = "Huang";
            students[0].studentID = "008233206";
            
            // Second student - Best friend
            students[1].firstName = "Juan";
            students[1].lastName = "Enriquez";
            students[1].studentID = "012845712";
            
            // Third student - Fictional character
            students[2].firstName = "Harry";
            students[2].lastName = "Potter";
            students[2].studentID = "123451235";
            
            Console.WriteLine("Student List:");

            foreach (Student student in students)
            {
                Console.WriteLine($"First Name: {student.firstName}, Last Name: {student.lastName}, Student ID: {student.studentID}");
            }
        }
    }
} 