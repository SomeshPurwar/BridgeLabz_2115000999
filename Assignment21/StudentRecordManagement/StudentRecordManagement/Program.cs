using System;
namespace StudentRecordManagement
{
    class Student
    {
        public int RollNumber;
        public string Name;
        public int Age;
        public string Grade;
        public Student Next;

        public Student(int rollNumber, string name, int age, string grade)
        {
            this.RollNumber = rollNumber;
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
            Next = null;
        }


    }

    class StudentList
    {
        private Student head;

        public void AddStudentAtBeginning(int rollNumber, string name, int age, string grade)
        {
            Student newStudent = new Student(rollNumber, name, age, grade);
            newStudent.Next = head;
            head = newStudent;
            
        }

        public void AddStudentAtEnd(int rollNumber, string name, int age, string grade)
        {
            Student newStudent = new Student(rollNumber, name, age, grade);
            if (head == null)
            {
                head = newStudent;
                return;
            }
            Student temp = head;
            while (temp.Next != null) 
            {
                temp = temp.Next;

            }
            temp.Next = newStudent;

        }

        public void AddStudentAtPosition(int rollNumber, string name, int age, string grade, int position)
        {
            Student newStudent = new Student(rollNumber, name, age, grade);
            if (position == 1)
            {
                AddStudentAtBeginning(rollNumber, name, age, grade);
                return;
            }
            Student temp = head;
            for(int i=1; temp != null && i < position - 1; i++)
                temp = temp.Next;

            if (temp == null)
            {
                Console.WriteLine("Position out of range");
                return;
            }

            newStudent.Next = temp.Next;
            temp.Next = newStudent;
        }

        public void DeleteStudent(int rollNumber)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if (head.RollNumber == rollNumber)
            {
                head = head.Next;
                return;
            }

            Student temp = head;
            while (temp.Next != null && temp.Next.RollNumber != rollNumber)
                temp = temp.Next;

            if (temp.Next == null)
            {
                Console.WriteLine("Student not found");
                return;
            }

            temp.Next = temp.Next.Next;
        }

        public void SearchStudent(int rollNumber)
        {
            Student temp = head;
            while (temp != null)
            {
                if (temp.RollNumber == rollNumber)
                {
                    Console.WriteLine($"Roll Number: {temp.RollNumber}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Student not found");
        }

        public void UpdateGrade(int rollNumber, string newGrade)
        {
            Student temp = head;
            while (temp != null)
            {
                if (temp.RollNumber == rollNumber)
                {
                    temp.Grade = newGrade;
                    Console.WriteLine("Grade updated successfully");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Student not found");
        }

        public void DisplayAllStudents()
        {
            if (head == null)
            {
                Console.WriteLine("No student records found.");
                return;
            }

            Student temp = head;
            while (temp != null)
            {
                Console.WriteLine($"Roll Number: {temp.RollNumber}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
                temp = temp.Next;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            StudentList studentList = new StudentList();

            studentList.AddStudentAtEnd(1, "Somesh Purwar", 21, "A+");
            studentList.AddStudentAtBeginning(2, "Shubham Das", 20, "A");
            studentList.AddStudentAtPosition(3, "Krishna", 21, "B", 2);

            Console.WriteLine("Student Records:");
            studentList.DisplayAllStudents();

            Console.WriteLine("\nSearching for student with Roll Number 2:");
            studentList.SearchStudent(2);

            Console.WriteLine("\nUpdating grade for Roll Number 3:");
            studentList.UpdateGrade(3, "A+");
            studentList.DisplayAllStudents();

            Console.WriteLine("\nDeleting student with Roll Number 2:");
            studentList.DeleteStudent(2);
            studentList.DisplayAllStudents();
        }
    }

}