using System;
using System.Collections.Generic;
using System.Reflection;

// Define the CacheResult attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class CacheResultAttribute : Attribute { }

// Implement a caching mechanism
public static class CacheManager
{
    private static readonly Dictionary<string, object> cache = new Dictionary<string, object>();

    public static object InvokeWithCache(object instance, string methodName, params object[] parameters)
    {
        Type type = instance.GetType();
        MethodInfo method = type.GetMethod(methodName);

        if (method == null)
            throw new InvalidOperationException("Method not found");

        // Check if the method has the CacheResult attribute
        CacheResultAttribute cacheAttr = method.GetCustomAttribute<CacheResultAttribute>();
        if (cacheAttr == null)
        {
            // If no caching, invoke method directly
            return method.Invoke(instance, parameters);
        }

        // Generate a unique cache key
        string cacheKey = $"{methodName}({string.Join(",", parameters)})";

        // Check cache before computing
        if (cache.ContainsKey(cacheKey))
        {
            Console.WriteLine($"[Cache Hit] Returning cached result for {cacheKey}");
            return cache[cacheKey];
        }

        // Compute result and store in cache
        object result = method.Invoke(instance, parameters);
        cache[cacheKey] = result;

        Console.WriteLine($"[Cache Miss] Computed and stored result for {cacheKey}");
        return result;
    }
}

//  Apply the caching system to an expensive method
public class ExpensiveOperations
{
    [CacheResult]
    public int ComputeFactorial(int n)
    {
        Console.WriteLine($"Computing factorial of {n}...");
        return (n <= 1) ? 1 : n * ComputeFactorial(n - 1);
    }
}

// Test the caching system
class Test11
{
    public static void Print()
    {
        ExpensiveOperations operations = new ExpensiveOperations();

        Console.WriteLine("First call (should compute):");
        Console.WriteLine($"Factorial(5) = {CacheManager.InvokeWithCache(operations, "ComputeFactorial", 5)}");

        Console.WriteLine("\nSecond call (should use cache):");
        Console.WriteLine($"Factorial(5) = {CacheManager.InvokeWithCache(operations, "ComputeFactorial", 5)}");

        Console.WriteLine("\nNew call with different input:");
        Console.WriteLine($"Factorial(6) = {CacheManager.InvokeWithCache(operations, "ComputeFactorial", 6)}");
    }
}
