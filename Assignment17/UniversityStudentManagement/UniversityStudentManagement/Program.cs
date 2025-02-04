using UniversityStudentManagement;

class Program
{
    static void Main()
    {
        Student[] students = new Student[2];
        int studentCount = 0;

        Console.WriteLine($"Welcome to {Student.UniversityName} Student Management System!");

        while (true)
        {
            Console.WriteLine("\n1. Enroll Student");
            Console.WriteLine("2. Display Student Details");
            Console.WriteLine("3. Update Student Grade");
            Console.WriteLine("4. Display Total Students");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Enrolling a new student
                    if (studentCount >= students.Length)
                    {
                        // Double the array size when full
                        Array.Resize(ref students, students.Length * 2);
                    }

                    Console.Write("Enter Student Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Roll Number: ");
                    int rollNumber = int.Parse(Console.ReadLine());

                    Console.Write("Enter Grade (A-F): ");
                    char grade = char.Parse(Console.ReadLine().ToUpper());

                    // Creating new student object
                    students[studentCount] = new Student(name, rollNumber, grade);
                    studentCount++;
                    Console.WriteLine("Student enrolled successfully!");
                    break;

                case 2:
                    // Display student details
                    Console.Write("Enter Roll Number: ");
                    int searchRoll = int.Parse(Console.ReadLine());

                    bool found = false;
                    foreach (var student in students)
                    {
                        if (student != null && student.RollNumber == searchRoll)
                        {
                            Student.PerformOperation(student);
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Student not found.");
                    }
                    break;

                case 3:
                    // Update student grade
                    Console.Write("Enter Roll Number: ");
                    int updateRoll = int.Parse(Console.ReadLine());

                    found = false;
                    foreach (var student in students)
                    {
                        if (student != null && student.RollNumber == updateRoll)
                        {
                            Student.PerformOperation(student, true);
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Student not found.");
                    }
                    break;

                case 4:
                    // Display total students
                    Student.DisplayTotalStudents();
                    break;

                case 5:
                    // Exit program
                    Console.WriteLine("Exiting... Thank you!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}