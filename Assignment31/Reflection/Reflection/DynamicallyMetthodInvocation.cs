using System;
using System.Reflection;

// Define a class with multiple public methods
public class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

class DynamicMethodInvocationDemo
{
    public static void Print()
    {
        // Create an instance of MathOperations
        MathOperations mathOps = new MathOperations();

        // Prompt user for the method name
        Console.Write("Enter the method name to invoke (Add, Subtract, Multiply): ");
        string methodName = Console.ReadLine();

        // Prompt user for the parameters
        Console.Write("Enter the first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        // Get the Type of the MathOperations class
        Type type = typeof(MathOperations);

        // Retrieve the method based on the user input
        MethodInfo method = type.GetMethod(methodName, BindingFlags.Public | BindingFlags.Instance);
        if (method == null)
        {
            Console.WriteLine("Method not found!");
            return;
        }

        // Prepare parameters array for the method
        object[] parameters = new object[] { firstNumber, secondNumber };

        // Invoke the method dynamically using Reflection
        object result = method.Invoke(mathOps, parameters);

        // Display the result
        Console.WriteLine($"Result of {methodName}({firstNumber}, {secondNumber}) is: {result}");
    }
}
