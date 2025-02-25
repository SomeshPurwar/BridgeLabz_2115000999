using System;
using System.Diagnostics;
using System.Reflection;

// Step 1: Define the LogExecutionTime attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class LogExecutionTimeAttribute : Attribute
{
}

// Step 2: Apply the attribute and measure execution time using Reflection
public class PerformanceTester
{
    [LogExecutionTime]
    public void FastMethod()
    {
        for (int i = 0; i < 100000; i++) { } // Simulated fast operation
    }

    [LogExecutionTime]
    public void SlowMethod()
    {
        for (int i = 0; i < 500000; i++) { } // Simulated slow operation
    }
}

class Test7
{
    public static void Print()
    {
        Type type = typeof(PerformanceTester);
        object instance = Activator.CreateInstance(type);

        MethodInfo[] methods = type.GetMethods();

        foreach (MethodInfo method in methods)
        {
            if (method.GetCustomAttribute(typeof(LogExecutionTimeAttribute)) != null)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();

                method.Invoke(instance, null); // Execute method

                stopwatch.Stop();
                Console.WriteLine($"Method {method.Name} executed in {stopwatch.ElapsedMilliseconds} ms");
            }
        }
    }
}
