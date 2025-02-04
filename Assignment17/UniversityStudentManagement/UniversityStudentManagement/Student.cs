using System;

namespace UniversityStudentManagement
{
    public class Student
    {
        // Static variable shared by all students
        public static string UniversityName = "GLA University";

        // Static variable to track total students
        private static int totalStudents = 0;

        // Readonly variable for unique Roll Number
        public readonly int RollNumber;

        // Instance variables
        private string name;
        private char grade;

        // Constructor using 'this' to initialize Name, RollNumber, and Grade
        public Student(string name, int rollNumber, char grade)
        {
            this.name = name;
            this.RollNumber = rollNumber;
            this.grade = grade;
            totalStudents++;
        }

        // Static method to display total students
        public static void DisplayTotalStudents()
        {
            Console.WriteLine($"Total Students Enrolled: {totalStudents}");
        }

        // Method to update student grade
        public void UpdateGrade(char newGrade)
        {
            if (newGrade >= 'A' && newGrade <= 'F')
            {
                grade = newGrade;
                Console.WriteLine("Grade updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid grade. Please enter a grade between A and F.");
            }
        }

        // Method to get student details
        public string GetStudentDetails()
        {
            return $"University: {UniversityName}\nName: {name}\nRoll Number: {RollNumber}\nGrade: {grade}";
        }

        // Method to check if an object is an instance of Student before displaying/updating
        public static void PerformOperation(object obj, bool update = false)
        {
            if (obj is Student student)
            {
                if (update)
                {
                    Console.Write("Enter new grade: ");
                    char newGrade = char.Parse(Console.ReadLine().ToUpper());
                    student.UpdateGrade(newGrade);
                }
                else
                {
                    Console.WriteLine(student.GetStudentDetails());
                }
            }
            else
            {
                Console.WriteLine("Invalid object. Not a Student instance.");
            }
        }
    }
}
