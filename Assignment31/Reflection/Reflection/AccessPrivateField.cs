using System;
using System.Reflection;

// Define a class with a private field
class Person
{
    private int age = 25; // Default value

    public void DisplayAge()
    {
        Console.WriteLine($"Age: {age}");
    }
}

class ReflectionExample
{
    public static void Print()
    {
        //  Create an instance of the Person class
        Person person = new Person();

        Console.WriteLine("Before modifying:");
        person.DisplayAge();

        // Get the Type object
        Type type = typeof(Person);

        //  Get the private field using Reflection
        FieldInfo ageField = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

        if (ageField != null)
        {
            // Modify the private field value
            ageField.SetValue(person, 30);

            //  Retrieve the modified value
            int modifiedAge = (int)ageField.GetValue(person);
            Console.WriteLine($"\nAfter modifying, Retrieved Age: {modifiedAge}");
        }
        else
        {
            Console.WriteLine("Field 'age' not found.");
        }

        // Display updated value using a method
        person.DisplayAge();
    }
}
