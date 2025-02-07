using System;
using Project2;
namespace CSharp
{
    class Program //: Class2/:Class1
    {
        private int Id = 101;
        protected string password = "asdfghj321";
        internal bool isValid=false;
        protected internal int secret = 1234567;
        static void Main(string[] args)
        {
            // public access specifier
            Console.WriteLine("Public Access Specifier");
            Class1 class1 = new Class1();
            Console.WriteLine($"Class1: {class1.number}");

            Class2 class2 = new Class2();
            Console.WriteLine($"Class2: {class2.Name}");
            Console.ReadKey();

            // Private access specifier
            Console.WriteLine("Private Access Specifier");
            //Console.WriteLine($"Class 1: {class1.Id}");  'Class1.Id' is inaccessible due to its protection level
            //Console.WriteLine($"Class 2: {class2.Id}"); 'Class2.Id' is inaccessible due to its protection level
            Program program = new Program();
            Console.WriteLine(program.Id); // Within class scope
            Console.WriteLine(class1.getId()); //Accessing using getter from Same project
            Console.WriteLine(class2.getId()); //Accessing using getter from different project
            Console.ReadKey();

            // Protected Access Specifier
            Console.WriteLine("Protected Access Specifier");
            Console.WriteLine(program.password); // Within class
            //Console.WriteLine(class1.password1); 'Class1.password1' is inaccessible due to its protection level
            //Console.WriteLine(class2.password2); 'Class2.password2' is inaccessible due to its protection level
            //Console.WriteLine(program.password1); // From Derived Class1
            //Console.WriteLine(program.password2); // From Derived Class1
            Console.ReadKey();

            // Internal Access Specifier
            Console.WriteLine("Internal Access Specifier");
            Console.WriteLine(program.isValid); //Within Same Assembly
            Console.WriteLine(class1.isValid); //Within Same Assembly
            //Console.WriteLine(class2.isValid); 'Class2.isValid' is inaccessible due to its protection level
            Console.ReadKey();

            // Protected Internal Access Specifier
            Console.WriteLine("Protected Internal Access Specifier");
            Console.WriteLine(program.secret);
            Console.WriteLine(class1.secret);
            //Console.WriteLine(class2.secret); 'Class2.secret' is inaccessible due to its protection level
            //Console.WriteLine(program.secret1); // Accessed from different assembly using deriver class









        }
    }

}
