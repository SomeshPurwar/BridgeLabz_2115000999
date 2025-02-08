using System;

namespace AnimalHierarchy
{
    class Animal
    {
        public string name;
        public int age;

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine($"{name} is a Animal");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes Sound.");

        }

    }

    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{name} is a Dog makes Barking Sound.");
        }

    }

    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{name} is a Cat makes Meow Sound.");
        }

    }

    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{name} is a Cat makes Chirping Sound.");
        }

    }

    class Program
    {
        static void Main()
        {
            Animal animal = new Animal("Amnimal",2);
            animal.MakeSound();
            Animal dog = new Dog("Shera", 2);
            dog.MakeSound();
            Animal cat = new Cat("Cash", 1);
            cat.MakeSound();
            Animal bird = new Bird("uddd", 3);
            bird.MakeSound();

        }
    }


}