using System;
using System.Reflection;

// Define the ImportantMethod attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class ImportantMethodAttribute : Attribute
{
    public string Level { get; }

    public ImportantMethodAttribute(string level = "HIGH")
    {
        Level = level;
    }
}

//  Apply the attribute to methods
public class MyClass
{
    [ImportantMethod] // Default Level is "HIGH"
    public void CriticalTask()
    {
        Console.WriteLine("Executing Critical Task...");
    }

    [ImportantMethod("MEDIUM")]
    public void RegularTask()
    {
        Console.WriteLine("Executing Regular Task...");
    }

    public void UnmarkedTask()
    {
        Console.WriteLine("Executing Unmarked Task...");
    }
}

class Test5
{
    public static void Print()
    {
        Type type = typeof(MyClass);
        MethodInfo[] methods = type.GetMethods();

        Console.WriteLine("Important Methods:");
        foreach (MethodInfo method in methods)
        {
            object[] attributes = method.GetCustomAttributes(typeof(ImportantMethodAttribute), false);
            foreach (ImportantMethodAttribute attr in attributes)
            {
                Console.WriteLine($"- {method.Name} (Level: {attr.Level})");
            }
        }
    }
}
