using System;
using System.Reflection;

// Define the BugReport attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class BugReportAttribute : Attribute
{
    public string Description { get; }

    public BugReportAttribute(string description)
    {
        Description = description;
    }
}

// Apply the attribute multiple times on a method
public class SampleClass
{
    [BugReport("NullReferenceException occurs when input is null.")]
    [BugReport("Performance issue when processing large data sets.")]
    public void SampleMethod()
    {
        Console.WriteLine("Executing SampleMethod...");
    }
}

public class Test4
{
    public static void Print()
    {
        Type type = typeof(SampleClass);
        MethodInfo methodInfo = type.GetMethod("SampleMethod");

        if (methodInfo != null)
        {
            object[] attributes = methodInfo.GetCustomAttributes(typeof(BugReportAttribute), false);

            Console.WriteLine("Bug Reports for SampleMethod:");
            foreach (BugReportAttribute attr in attributes)
            {
                Console.WriteLine($"- {attr.Description}");
            }
        }
    }
}
