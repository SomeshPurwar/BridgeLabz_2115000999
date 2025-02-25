using System;
using System.Reflection;

// Define the Todo attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

// Apply the attribute to multiple methods
public class ProjectTasks
{
    [Todo("Implement user authentication", "Alice", "HIGH")]
    public void AuthenticateUser()
    {
        Console.WriteLine("Authenticating user...");
    }

    [Todo("Optimize database queries", "Bob")]
    public void OptimizeDatabase()
    {
        Console.WriteLine("Optimizing database...");
    }

    [Todo("Improve UI responsiveness", "Charlie", "LOW")]
    [Todo("Add dark mode support", "David", "MEDIUM")]
    public void UpdateUI()
    {
        Console.WriteLine("Updating UI...");
    }
}

class Test6
{
    public static void Print()
    {
        Type type = typeof(ProjectTasks);
        MethodInfo[] methods = type.GetMethods();

        Console.WriteLine("Pending Tasks:");
        foreach (MethodInfo method in methods)
        {
            object[] attributes = method.GetCustomAttributes(typeof(TodoAttribute), false);
            foreach (TodoAttribute attr in attributes)
            {
                Console.WriteLine($"- Task: {attr.Task}");
                Console.WriteLine($"  Assigned To: {attr.AssignedTo}");
                Console.WriteLine($"  Priority: {attr.Priority}");
                Console.WriteLine($"  Method: {method.Name}");
                Console.WriteLine();
            }
        }
    }
}
