using System;
using System.Reflection;

// Step 1: Define the Configuration class with a private static field
class Configuration
{
    private static string API_KEY = "DEFAULT_KEY";

    // Public method to get the current API_KEY value
    public static string GetApiKey()
    {
        return API_KEY;
    }
}

class ModifyStaticFieldDemo
{
    public static void Print()
    {
        // Step 2: Get the Type object of Configuration
        Type type = typeof(Configuration);

        // Step 3: Get the private static field info
        FieldInfo fieldInfo = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

        if (fieldInfo != null)
        {
            Console.WriteLine("Before Modification: " + Configuration.GetApiKey());

            // Step 4: Modify the private static field value
            fieldInfo.SetValue(null, "NEW_SECRET_KEY");

            Console.WriteLine("After Modification: " + Configuration.GetApiKey());
        }
        else
        {
            Console.WriteLine("Field not found.");
        }
    }
}
