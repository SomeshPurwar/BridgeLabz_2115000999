using System;
using System.Collections.Generic;
using System.Reflection;

class ObjectMapper
{
    // Generic method to create an object and populate fields from a dictionary
    public static T ToObject<T>(Dictionary<string, object> properties) where T : new()
    {
        // Step 1: Create an instance of the given class type
        T obj = new T();
        Type type = typeof(T);

        // Step 2: Iterate through dictionary and set field values using Reflection
        foreach (var entry in properties)
        {
            FieldInfo fieldInfo = type.GetField(entry.Key, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            if (fieldInfo != null)
            {
                // Convert value to the appropriate type and assign it to the field
                fieldInfo.SetValue(obj, Convert.ChangeType(entry.Value, fieldInfo.FieldType));
            }
        }

        return obj;
    }
}

// Sample class for testing
class User
{
    public string Name;
    private int Age;

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class TestObjectMapper
{
    public static void Print()
    {
        // Step 3: Create a dictionary with property values
        var properties = new Dictionary<string, object>
        {
            { "Name", "Somesh" },
            { "Age", 21 }
        };

        // Step 4: Convert dictionary to an object
        User user = ObjectMapper.ToObject<User>(properties);

        // Step 5: Print the object's fields
        user.Display();
    }
}
