using System;
using System.Collections.Generic;

namespace UniversityManagementSystem
{
    class Course
    {
        public string name;
        private List<Student> students;
        public Professor professor;

        public Course(string name)
        {
            this.name = name;
            students = new List<Student>();
        }

        public void assignProfessor(Professor professor)
        {
            this.professor = professor;
            Console.WriteLine($"Professor {professor.name} is assigned to teach {name}.");
        }

        public void enrollStudent(Student student)
        {
            students.Add(student);
            student.enrollCourse(this);
            Console.WriteLine($"Student {student.name} has enrolled in {name}.");
        }

        public void showEnrolledStudents()
        {
            Console.WriteLine($"Course: {name} has the following students enrolled:");
            foreach (var student in students)
            {
                Console.WriteLine($"  Student: {student.name}");
            }
        }
    }
}
