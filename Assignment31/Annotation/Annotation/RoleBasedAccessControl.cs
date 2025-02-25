using System;
using System.Reflection;

// Define the RoleAllowed attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class RoleAllowedAttribute : Attribute
{
    public string Role { get; }

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

//  Create a class with restricted methods
public class SecureOperations
{
    [RoleAllowed("ADMIN")]
    public void AdminTask()
    {
        Console.WriteLine("Admin task executed successfully.");
    }

    [RoleAllowed("USER")]
    public void UserTask()
    {
        Console.WriteLine("User task executed successfully.");
    }
}

//  Simulate user roles and validate access
class Test9
{
    static void ExecuteMethodWithRole(object instance, string methodName, string userRole)
    {
        Type type = instance.GetType();
        MethodInfo method = type.GetMethod(methodName);

        if (method != null)
        {
            RoleAllowedAttribute roleAttr = method.GetCustomAttribute<RoleAllowedAttribute>();

            if (roleAttr == null || roleAttr.Role == userRole)
            {
                method.Invoke(instance, null);
            }
            else
            {
                Console.WriteLine("Access Denied!");
            }
        }
    }

    public static void Print()
    {
        SecureOperations secureOps = new SecureOperations();

        Console.WriteLine("Trying to execute AdminTask as ADMIN:");
        ExecuteMethodWithRole(secureOps, "AdminTask", "ADMIN");

        Console.WriteLine("\nTrying to execute AdminTask as USER:");
        ExecuteMethodWithRole(secureOps, "AdminTask", "USER");

        Console.WriteLine("\nTrying to execute UserTask as USER:");
        ExecuteMethodWithRole(secureOps, "UserTask", "USER");

        Console.WriteLine("\nTrying to execute UserTask as ADMIN:");
        ExecuteMethodWithRole(secureOps, "UserTask", "ADMIN");
    }
}
