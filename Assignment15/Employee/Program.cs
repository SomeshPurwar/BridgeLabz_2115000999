using System;

class Test
{
	// Main method to test the class
	static void Main()
    {
		Console.Write("Enter the Employee Id: ");
        int id = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the name: ");
        string name = Console.ReadLine();
        Employee emp1 = new Employee(name, id, salary);
        emp1.display();
    }
	
}

class Employee
{
    // Attributes
    public string Name;
    public int Id;
    public double Salary;

    // Constructor
    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    // Method to display employee details
    public void display()
    {
        Console.WriteLine("Employee ID: " + Id);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Salary: Inr " + Salary);
    }

    
}
