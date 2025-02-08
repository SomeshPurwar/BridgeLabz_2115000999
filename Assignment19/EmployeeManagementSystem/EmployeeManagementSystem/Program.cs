using System;
using System.Xml.Linq;

namespace EmployeeMAnagementSystem
{
    class Employee
    {
        public string name;
        public int id;
        public double salary;

        public Employee(string name, int id, double salary)
        {
            this.name = name;   
            this.id = id;
            this.salary = salary;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {name}, ID: {id}, Salary: {salary}");
        }
    }

    class Manager : Employee
    {
        public int teamSize;

        public Manager(string name, int id, int salary, int teamSize) : base(name, id, salary)
        {
            this.teamSize = teamSize;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("I am a Manager");
            base.DisplayDetails();
            Console.WriteLine($"Team size: {teamSize}");
        }
    }

    class Developer : Employee
    {
        public string programmingLanguage;

        public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary)
        {
            this.programmingLanguage = programmingLanguage;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("I am a Developer");
            base.DisplayDetails();
            Console.WriteLine($"Known Programming Language: {programmingLanguage}");
        }
    }

    class Intern : Employee
    {
        public string internshipDuration;

        public Intern(string name, int id, double salary, string internshipDuration) : base(name, id, salary) 
        {
            this.internshipDuration = internshipDuration;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("I am an Intern");
            base.DisplayDetails();
            Console.WriteLine($"Internship Duration: {internshipDuration}");
        }
    }

    class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Employee", 1, 1000);
            Employee manager = new Manager("HR Didi", 101, 600000, 6);
            Employee developer = new Developer("Prahil", 102, 2000000, ".NET");
            Employee intern = new Intern("Somesh", 111, 50000, "6 months");

            employee.DisplayDetails();
            manager.DisplayDetails();
            developer.DisplayDetails();
            intern.DisplayDetails();

        }
    }

}