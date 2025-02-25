using System;
using System.Diagnostics;
using System.Reflection;

//  Define a Sample Class with Methods
public class SampleOperations
{
    public void FastMethod()
    {
        Console.WriteLine("Executing FastMethod...");
    }

    public void SlowMethod()
    {
        Console.WriteLine("Executing SlowMethod...");
        System.Threading.Thread.Sleep(2000); // Simulate delay
    }
}

//  Method Execution Timing via Reflection
public static class MethodTimer
{
    public static void MeasureExecutionTime(object obj, string methodName)
    {
        Type type = obj.GetType();
        MethodInfo method = type.GetMethod(methodName);

        if (method == null)
        {
            Console.WriteLine($"Method {methodName} not found.");
            return;
        }

        Stopwatch stopwatch = Stopwatch.StartNew();
        method.Invoke(obj, null);
        stopwatch.Stop();

        Console.WriteLine($"Execution Time for {methodName}: {stopwatch.ElapsedMilliseconds} ms");
    }
}

// Test Execution Timing
class TimeExecutionDemo
{
    public static void Print()
    {
        SampleOperations operations = new SampleOperations();

        MethodTimer.MeasureExecutionTime(operations, "FastMethod");
        MethodTimer.MeasureExecutionTime(operations, "SlowMethod");
    }
}
