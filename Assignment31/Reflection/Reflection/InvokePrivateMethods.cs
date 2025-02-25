using System;
using System.Reflection;

// Define a class with a private method
class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

class ReflectionInvokePrivateMethod
{
    public static void Print()
    {
        // Create an instance of the Calculator class
        Calculator calculator = new Calculator();

        //  Get the Type object
        Type type = typeof(Calculator);

        //  Get the private method using Reflection
        MethodInfo multiplyMethod = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

        if (multiplyMethod != null)
        {
            //  Invoke the private method
            object result = multiplyMethod.Invoke(calculator, new object[] { 5, 10 });

            //  Display the result
            Console.WriteLine($"Result of Multiply(5, 10): {result}");
        }
        else
        {
            Console.WriteLine("Method 'Multiply' not found.");
        }
    }
}
