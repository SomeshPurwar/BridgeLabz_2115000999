using System;
class Test13{
    public static void Print(){
        Console.WriteLine("Enter Employee ID:");
        int employeeID = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Department:");
        string department = Console.ReadLine();
        Console.WriteLine("Enter Salary:");
        double salary = Convert.ToDouble(Console.ReadLine());
        Employee employee = new Employee(employeeID, department, salary);
        Console.WriteLine("\nEmployee Details:");
        employee.DisplayEmployeeDetails();
        Console.ReadKey();
        Console.WriteLine("\nEmployee Role for Manager Class:");
        string role=Console.ReadLine();
        Manager manager = new Manager(employeeID, department, salary, role);
        Console.WriteLine("\nManager Details:");
        manager.DisplayManagerDetails();
        Console.ReadKey();
        Console.WriteLine("\nUpdating Salary");
        Console.WriteLine("Enter new Salary:");
        double newSalary = Convert.ToDouble(Console.ReadLine());
        employee.SetSalary(newSalary);
        Console.ReadKey();
        Console.WriteLine("\nUpdated Employee Details:");
        employee.DisplayEmployeeDetails();
    }
}

public class Employee{
    public int employeeID;
    protected string department;
    private double salary;
    public Employee(int employeeID, string department, double salary){
        this.employeeID = employeeID;
        this.department = department;
        this.salary = salary;
    }

    public double GetSalary(){
        return salary;
    }

    public void SetSalary(double newSalary){
        salary = newSalary;
    }

    public void DisplayEmployeeDetails(){
        Console.WriteLine($"Employee ID: {employeeID}");
        Console.WriteLine($"Department: {department}");
        Console.WriteLine($"Salary: INR {salary}");
    }
}

public class Manager : Employee{
    private string role;

    public Manager(int employeeID, string department, double salary, string role) 
        : base(employeeID, department, salary){
        this.role = role;
    }

    public void DisplayManagerDetails(){
        Console.WriteLine($"Employee ID: {employeeID}");
        Console.WriteLine($"Department: {department}");
        Console.WriteLine($"Role: {role}");
        Console.WriteLine($"Salary: INR {GetSalary()}");
    }
}
