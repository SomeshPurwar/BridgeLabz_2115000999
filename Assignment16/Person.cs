using System;
class Test3{
        public static void Print(){
        Console.WriteLine("Enter Name");
        string name=Console.ReadLine();
        Console.WriteLine("Enter Age");
        int age=Convert.ToInt32(Console.ReadLine());
        Person person1 = new Person(name,age);
        Person person2 = new Person(person1);
        Console.WriteLine("Person 1 details:");
        person1.PrintDetail();
        Console.WriteLine("Person 2 details by copy cosntrutor:");
        person2.PrintDetail();
    }
}

public class Person{
    private string Name;
    private int Age;
    //  constructor
    public Person(string name, int age){
        Name = name;
        Age = age;
    }
    // Copy constructor
    public Person(Person Object){
        Name = Object.Name;
        Age = Object.Age;
    }
    // to display 
    public void PrintDetail(){
        Console.WriteLine("Name:  "+ Name +"\nAge: "+Age);
    }
}
