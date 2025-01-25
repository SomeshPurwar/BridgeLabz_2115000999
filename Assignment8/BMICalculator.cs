using System;

class BMICalculator
{
    public static void print()
    {
        Console.Write("Enter the number of persons: ");
        int numberOfPersons = Convert.ToInt32(Console.ReadLine());

        double[] weights = new double[numberOfPersons];
        double[] heights = new double[numberOfPersons];
        double[] bmis = new double[numberOfPersons];
        string[] statuses = new string[numberOfPersons];

        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.Write($"Enter weight (kg) for person {i + 1}: ");
            weights[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter height (m) for person {i + 1}: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        for (int i = 0; i < numberOfPersons; i++)
        {
            bmis[i] = weights[i] / (heights[i] * heights[i]);
            if (bmis[i] <= 18.4)
            {
                statuses[i] = "Underweight";
            }
            else if (bmis[i] >= 18.5 && bmis[i] <= 24.9)
            {
                statuses[i] = "Normal";
            }
            else if (bmis[i] >= 25.0 && bmis[i] <= 39.9)
            {
                statuses[i] = "Overweight";
            }
            else
            {
                statuses[i] = "Obese";
            }
        }

        Console.WriteLine("\nPerson Details:");
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"Person {i + 1}: Height = {heights[i]:F2}m, Weight = {weights[i]:F2}kg, BMI = {bmis[i]:F2}, Status = {statuses[i]}");
        }
    }
}
