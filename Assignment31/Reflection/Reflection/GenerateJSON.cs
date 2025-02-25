using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

class JsonConverterCustom
{
    // Method to convert an object to a JSON-like string using Reflection
    public static string ToJson(object obj)
    {
        if (obj == null) return "{}";

        Type type = obj.GetType();
        StringBuilder jsonBuilder = new StringBuilder();
        jsonBuilder.Append("{");

        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        List<string> fieldStrings = new List<string>();

        foreach (var field in fields)
        {
            object value = field.GetValue(obj);
            string formattedValue = value is string ? $"\"{value}\"" : value.ToString();
            fieldStrings.Add($"\"{field.Name}\": {formattedValue}");
        }

        jsonBuilder.Append(string.Join(", ", fieldStrings));
        jsonBuilder.Append("}");

        return jsonBuilder.ToString();
    }
}

// Sample class for testing
class Users
{
    public string Name;
    private int Age;

    public Users(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class TestJsonConverter
{
    public static void Print()
    {
        // Create a User object
        Users user = new Users("Somesh", 21);

        // Convert to JSON string
        string jsonString = JsonConverterCustom.ToJson(user);

        // Print the JSON representation
        Console.WriteLine("Generated JSON:");
        Console.WriteLine(jsonString);
    }
}
