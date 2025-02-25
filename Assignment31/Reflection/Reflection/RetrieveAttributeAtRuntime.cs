using System;
using System.Reflection;

// Step 1: Define the custom attribute
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class AuthorAttribute : Attribute
{
    public string Name { get; }

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

// Step 2: Apply the attribute to a class
[Author("Somesh Purwar")]
public class SampleClas
{
    public void Display()
    {
        Console.WriteLine("This is a sample class with an Author attribute.");
    }
}

class RetrieveAttributeDemo
{
    public static void Print()
    {
        // Step 3: Get the Type object of SampleClass
        Type type = typeof(SampleClas);

        // Step 4: Retrieve the custom attribute
        AuthorAttribute authorAttribute = (AuthorAttribute)Attribute.GetCustomAttribute(type, typeof(AuthorAttribute));

        // Step 5: Display the retrieved attribute value
        if (authorAttribute != null)
        {
            Console.WriteLine($"Author of {type.Name}: {authorAttribute.Name}");
        }
        else
        {
            Console.WriteLine("No Author attribute found.");
        }
    }
}
