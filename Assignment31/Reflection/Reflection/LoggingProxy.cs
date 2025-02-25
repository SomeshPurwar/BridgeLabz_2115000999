using System;
using System.Reflection;
using System.Reflection.Emit;

public interface IGreeting
{
    void SayHello(string name);
    void SayGoodbye(string name);
}

// Step 1: Implement the actual class
public class Greeting : IGreeting
{
    public void SayHello(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    public void SayGoodbye(string name)
    {
        Console.WriteLine($"Goodbye, {name}!");
    }
}

// Step 2: Create a Dynamic Proxy for Logging
public class LoggingProxy<T> : DispatchProxy where T : class
{
    private T _instance;

    public static T Create(T instance)
    {
        object proxy = Create<T, LoggingProxy<T>>();
        ((LoggingProxy<T>)proxy)._instance = instance;
        return (T)proxy;
    }

    protected override object Invoke(MethodInfo targetMethod, object[] args)
    {
        Console.WriteLine($"[LOG] Calling method: {targetMethod.Name}");
        return targetMethod.Invoke(_instance, args);
    }
}

// Step 3: Test the Logging Proxy
class ProxyDemo
{
    public static void Print()
    {
        IGreeting greeting = new Greeting();
        IGreeting proxyGreeting = LoggingProxy<IGreeting>.Create(greeting);

        proxyGreeting.SayHello("Somesh");
        proxyGreeting.SayGoodbye("Somesh");
    }
}
