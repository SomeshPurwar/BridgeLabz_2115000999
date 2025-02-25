using System;
using System.Reflection;

class ReflectionDemo
{
    public static void DisplayClassInfo(string className)
    {
        try
        {
            // Get the Type object for the given class name
            Type type = Type.GetType(className);

            if (type == null)
            {
                Console.WriteLine($"Class '{className}' not found.");
                return;
            }

            Console.WriteLine($"Class: {type.FullName}\n");

            // Display Fields
            Console.WriteLine("Fields:");
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine($"  {field.FieldType} {field.Name}");
            }

            // Display Methods
            Console.WriteLine("\nMethods:");
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine($"  {method.ReturnType} {method.Name}()");
            }

            // Display Constructors
            Console.WriteLine("\nConstructors:");
            ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine($"  {constructor}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public static void Print()
    {
        Console.Write("Enter class name (with namespace if required): ");
        string className = Console.ReadLine();

        DisplayClassInfo(className);
    }
}


class SampleClass
{
    public int PublicField;
    private string privateField;

    public SampleClass() { }
    public SampleClass(int value) { }

    public void PublicMethod() { }
    private void PrivateMethod() { }
}
