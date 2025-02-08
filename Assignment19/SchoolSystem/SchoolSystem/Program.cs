using System;
namespace SchoolSystem
{
    class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void DisplayRole()
        {
            Console.WriteLine("General Person");
        }
    }

    class Teacher : Person
    {
        public string subject;

        public Teacher(string name, int age, string subject)
            : base(name, age)
        {
            this.subject = subject;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"Teacher - Subject: {subject}");
        }
    }

    class Student : Person
    {
        public string grade;

        public Student(string name, int age, string grade)
            : base(name, age)
        {
            this.grade = grade;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"Student - Grade: {grade}");
        }
    }

    class Staff : Person
    {
        public string position;

        public Staff(string name, int age, string position)
            : base(name, age)
        {
            this.position = position;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"Staff - Position: {position}");
        }
    }

    class Program
    {
        static void Main()
        {
            Person teacher = new Teacher("Mohit Chaudhary", 35, "Mathematics");
            Person student = new Student("Somesh", 21, "Graduation");
            Person staff = new Staff("Ramesh", 40, "Administrator");

            teacher.DisplayRole();
            student.DisplayRole();
            staff.DisplayRole();
        }
    }

}