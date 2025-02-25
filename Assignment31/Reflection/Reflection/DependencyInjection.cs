using System;
using System.Collections.Generic;
using System.Reflection;

// Step 1: Define the [Inject] Attribute
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Property)]
public class InjectAttribute : Attribute { }

// Step 2: Create a Simple DI Container
public class SimpleContainer
{
    private readonly Dictionary<Type, Type> _typeMappings = new();

    // Register Interface to Implementation
    public void Register<TInterface, TImplementation>()
        where TImplementation : TInterface
    {
        _typeMappings[typeof(TInterface)] = typeof(TImplementation);
    }

    // Resolve Dependencies and Create an Instance
    public T Resolve<T>()
    {
        return (T)Resolve(typeof(T));
    }

    private object Resolve(Type type)
    {
        if (!_typeMappings.ContainsKey(type))
            throw new Exception($"Type {type.Name} not registered in DI container");

        Type implementationType = _typeMappings[type];
        ConstructorInfo constructor = implementationType
            .GetConstructors()
            .FirstOrDefault(ctor => ctor.GetCustomAttribute<InjectAttribute>() != null);

        if (constructor != null)
        {
            // Get constructor parameters and resolve them recursively
            object[] parameters = constructor.GetParameters()
                .Select(param => Resolve(param.ParameterType))
                .ToArray();

            return Activator.CreateInstance(implementationType, parameters);
        }

        return Activator.CreateInstance(implementationType);
    }
}

// Step 3: Define Some Services
public interface ILogger
{
    void Log(string message);
}

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[LOG]: {message}");
    }
}

// Step 4: Define a Service That Needs Dependency Injection
public class UserService
{
    private readonly ILogger _logger;

    [Inject]
    public UserService(ILogger logger)
    {
        _logger = logger;
    }

    public void ProcessUser()
    {
        _logger.Log("Processing user data...");
    }
}

// Step 5: Test the DI Container
class DependencyInjectionDemo
{
    public static void Print()
    {
        // Create and configure the DI container
        SimpleContainer container = new();
        container.Register<ILogger, ConsoleLogger>();
        container.Register<UserService, UserService>();

        // Resolve dependencies and create an instance
        UserService userService = container.Resolve<UserService>();

        // Call a method to test dependency injection
        userService.ProcessUser();
    }
}
