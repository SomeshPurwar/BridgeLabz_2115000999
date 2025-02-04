using System;
class Test
{
	
	// Main method to test the class
	static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Circle circle = new Circle(radius);
        circle.display();
    }
	
}
class Circle
{
    // Attribute
    public double Radius;

    // Constructor
    public Circle(double radius)
    {
        Radius = radius;
    }

    // Method to calculate area
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    // Method to calculate circumference
    public double CalculateCircumference()
    {
        return 2 * Math.PI * Radius;
    }

    // Method to display details
    public void display()
    {
        Console.WriteLine("Radius: " + Radius);
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine("Circumference: " + CalculateCircumference());
    }
    
}
