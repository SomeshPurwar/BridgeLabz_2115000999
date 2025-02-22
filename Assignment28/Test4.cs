using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

[Serializable]
class Employee {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, string department, double salary) {
        Id = id;
        Name = name;
        Department = department;
        Salary = salary;
    }
}

class Test4{
    private static string filePath = "employees.json";

    public static void Print() {
        List<Employee> employees = new List<Employee> {
            new Employee(1, "Shivam Kumar Rajput", "HR", 50000),
            new Employee(2, "Ashish Verma", "IT", 60000),
            new Employee(3, "Aditya Sharma", "Finance", 55000)
        };

        SerializeEmployees(employees);
        List<Employee> deserializedEmployees = DeserializeEmployees();

        Console.WriteLine("Employee Data Retrieved:");
        foreach (var emp in deserializedEmployees) {
            Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
        }
    }

    private static void SerializeEmployees(List<Employee> employees) {
        try {
            string json = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
            Console.WriteLine("Employees serialized successfully.");
        } catch (Exception ex) {
            Console.WriteLine("Serialization error: " + ex.Message);
        }
    }

    private static List<Employee> DeserializeEmployees() {
        try {
            if (!File.Exists(filePath)) {
                Console.WriteLine("No employee data found.");
                return new List<Employee>();
            }
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Employee>>(json) ?? new List<Employee>();
        } catch (Exception ex) {
            Console.WriteLine("Deserialization error: " + ex.Message);
            return new List<Employee>();
        }
    }
}
