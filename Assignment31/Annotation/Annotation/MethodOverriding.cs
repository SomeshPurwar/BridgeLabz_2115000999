using System;

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks: Woof! Woof!");
    }
}

public class Test1
{
    public static void Print()
    {
        Animal myDog = new Dog();  // Polymorphism
        myDog.MakeSound();         // Calls the overridden method in Dog class
    }
}
