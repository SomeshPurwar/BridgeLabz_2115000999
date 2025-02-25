using System;
using System.Reflection;

//  Define the Student class
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student()
    {
        Name = "Default Name";
        Age = 18;
    }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Student Name: {Name}, Age: {Age}");
    }
}

class ReflectionCreateObject
{
    public static void Print()
    {
        //  Get the Type object for the Student class
        Type studentType = typeof(Student);

        //  Create an instance using Reflection (Default Constructor)
        object studentInstance1 = Activator.CreateInstance(studentType);
        Console.WriteLine("Created Student Instance (Default Constructor):");
        ((Student)studentInstance1).DisplayInfo();

        //  Create an instance using Reflection (Parameterized Constructor)
        object studentInstance2 = Activator.CreateInstance(studentType, new object[] { "Somesh", 21 });
        Console.WriteLine("\nCreated Student Instance (Parameterized Constructor):");
        ((Student)studentInstance2).DisplayInfo();
    }
}
