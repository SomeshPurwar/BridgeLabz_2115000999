using System;

public class BMIAnalysis
{
	public static void print()
    {
        double[,] personData = new double[10, 3];
        string[] bmiStatus = new string[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter weight (kg) for person {i + 1}: ");
            personData[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter height (cm) for person {i + 1}: ");
            personData[i, 1] = Convert.ToDouble(Console.ReadLine());

            personData[i, 2] = CalculateBMI(personData[i, 0], personData[i, 1]);
            bmiStatus[i] = GetBMIStatus(personData[i, 2]);
        }

        Console.WriteLine("\nBMI Analysis:");
        Console.WriteLine("Weight (kg) | Height (cm) | BMI | Status");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{personData[i, 0],10} | {personData[i, 1],10} | {personData[i, 2]:F2} | {bmiStatus[i]}");
        }
    }
	
    public static double CalculateBMI(double weight, double heightCm)
    {
        double heightM = heightCm / 100;
        return weight / (heightM * heightM);
    }

    public static string GetBMIStatus(double bmi)
    {
        if (bmi <= 18.4) return "Underweight";
        if (bmi >= 18.5 && bmi <= 24.9) return "Normal";
        if (bmi >= 25.0 && bmi <= 39.9) return "Overweight";
        return "Obese";
    }

    
}
