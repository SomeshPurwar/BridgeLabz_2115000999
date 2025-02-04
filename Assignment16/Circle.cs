using System;
class Test2{
    public static void Print(){
        Console.WriteLine("Enter Radius :");
        double radius = Convert.ToDouble(Console.ReadLine());

        Circle circle1 = new Circle();
        Circle circle2 = new Circle(radius);

        Console.WriteLine("Radius  By chaning:");
        circle1.PrintRadius();
        Console.WriteLine("Enter Radius Parameter :");
        circle2.PrintRadius();
    }
}
class Circle{
    private double radius;
    public Circle() : this(1.0) // Constructor chaining
    {
        Console.WriteLine("Constructor Chaining :");
    }

    public Circle(double radius){
        this.radius = radius;
    }

    public void PrintRadius() { 
        Console.WriteLine("Radius Is :"+radius);

    }
    public void SetRadius(double radius) {
         this.radius = radius; 
    }
}

