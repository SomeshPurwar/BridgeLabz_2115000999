using System;
public class QuadraticEquationSolver
{
	public static void print(){
		Console.Write("\nEnter coefficient a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter coefficient b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter coefficient c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double[] roots = QuadraticEquationSolver.FindRoots(a, b, c);

        if (roots.Length == 0)
        {
            Console.WriteLine("No real roots exist.");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine($"One real root: {roots[0]}");
        }
        else
        {
            Console.WriteLine($"Two real roots: {roots[0]} and {roots[1]}");
        }
	}
	
    public static double[] FindRoots(double a, double b, double c)
    {
		
        double delta = (b * b) - (4 * a * c);
        if (delta < 0)
        {
            return new double[0]; // No real roots
        }
        else if (delta == 0)
        {
            return new double[] { -b / (2 * a) }; // One real root
        }
        else
        {
            double sqrtDelta = Math.Sqrt(delta);
            return new double[] { (-b + sqrtDelta) / (2 * a), (-b - sqrtDelta) / (2 * a) };
        }
    }
}