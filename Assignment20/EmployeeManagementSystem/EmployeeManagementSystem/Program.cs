using System;
namespace EmployeeManagementSystem 
{
    // Abstract class Employee
    abstract class Employee
    {
        // Encapsulated fields
        private int employeeId;
        private string name;
        private double baseSalary;

        // Constructor
        public Employee(int id, string name, double salary)
        {
            this.employeeId = id;
            this.name = name;
            this.baseSalary = salary;
        }

        // Properties for encapsulated fields
        public int EmployeeId { get { return employeeId; } }
        public string Name { get { return name; } }
        public double BaseSalary { get { return baseSalary; } }

        // Abstract method
        public abstract double CalculateSalary();

        // Concrete method
        public void DisplayDetails()
        {
            Console.WriteLine($"ID: {employeeId}, Name: {name}, Salary: Rs.{CalculateSalary()}");
        }
    }

    // Interface IDepartment
    interface IDepartment
    {
        void AssignDepartment(string department);
        string GetDepartmentDetails();
    }

    // FullTimeEmployee class
    class FullTimeEmployee : Employee, IDepartment
    {
        private string department;

        public FullTimeEmployee(int id, string name, double salary) : base(id, name, salary) { }

        public override double CalculateSalary()
        {
            return BaseSalary; // Fixed salary for full-time employees
        }

        public void AssignDepartment(string dept)
        {
            department = dept;
        }

        public string GetDepartmentDetails()
        {
            return $"Department: {department}";
        }
    }

    // PartTimeEmployee class
    class PartTimeEmployee : Employee, IDepartment
    {
        private int workHours;
        private double hourlyRate;
        private string department;

        public PartTimeEmployee(int id, string name, double hourlyRate, int hours) : base(id, name, 0)
        {
            this.workHours = hours;
            this.hourlyRate = hourlyRate;
        }

        public override double CalculateSalary()
        {
            return workHours * hourlyRate; // Salary based on hours worked
        }

        public void AssignDepartment(string dept)
        {
            department = dept;
        }

        public string GetDepartmentDetails()
        {
            return $"Department: {department}";
        }
    }

    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();

            FullTimeEmployee emp1 = new FullTimeEmployee(1, "Somesh", 5000);
            emp1.AssignDepartment("Developer");

            PartTimeEmployee emp2 = new PartTimeEmployee(2, "Shubham", 20, 100);
            emp2.AssignDepartment("IT");

            employees.Add(emp1);
            employees.Add(emp2);

            foreach (var emp in employees)
            {
                emp.DisplayDetails();
                if (emp is IDepartment deptEmp)
                {
                    Console.WriteLine(deptEmp.GetDepartmentDetails());
                }
                Console.WriteLine();
            }
        }
    }

}
