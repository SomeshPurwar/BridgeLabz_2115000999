using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class Employee
    {
        // Static variable shared across all employees
        public static string CompanyName = "Capgemini";
        private static int totalEmployees = 0;

        // Readonly variable for Employee ID
        public readonly int Id;

        // Instance variables for Employee details
        private string name;
        private string designation;

        // Constructor using 'this' to initialize Name, Id, and Designation
        public Employee(string name, int id, string designation)
        {
            this.name = name;
            this.Id = id;
            this.designation = designation;
            totalEmployees++;
        }

        // Static method to display total number of employees
        public static void DisplayTotalEmployees()
        {
            Console.WriteLine($"Total Employees: {totalEmployees}");
        }

        // Instance method to get employee details
        public string GetEmployeeDetails()
        {
            return $"Employee Name: {name}\nEmployee ID: {Id}\nDesignation: {designation}\nCompany: {CompanyName}";
        }

        // Method to check if the object is an instance of Employee class using 'is'
        public static void DisplayEmployeeDetails(object obj)
        {
            if (obj is Employee employee)
            {
                Console.WriteLine(employee.GetEmployeeDetails());
            }
            else
            {
                Console.WriteLine("The object is not an Employee.");
            }
        }
    }
}
