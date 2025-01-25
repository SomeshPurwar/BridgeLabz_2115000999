using System;

class BMICalculator2DArray
{
    public static void print()
    {
        Console.Write("Enter the number of persons: ");
        int numberOfPersons = Convert.ToInt32(Console.ReadLine());

        double[][] personData = new double[numberOfPersons][];
        for (int i = 0; i < numberOfPersons; i++)
        {
            personData[i] = new double[3]; 
        }

        string[] weightStatus = new string[numberOfPersons];

        for (int i = 0; i < numberOfPersons; i++)
        {
            double weight;
            do
            {
                Console.Write($"Enter weight (kg) for person {i + 1}: ");
                weight = Convert.ToDouble(Console.ReadLine());
                if (weight < 0)
                {
                    Console.WriteLine("Weight must be a positive value. Please re-enter.");
                }
            } while (weight < 0);

            double height;
            do
            {
                Console.Write($"Enter height (m) for person {i + 1}: ");
                height = Convert.ToDouble(Console.ReadLine());
                if (height <= 0)
                {
                    Console.WriteLine("Height must be a positive value. Please re-enter.");
                }
            } while (height <= 0);

            personData[i][0] = weight;
            personData[i][1] = height;
        }

        for (int i = 0; i < numberOfPersons; i++)
        {
            double weight = personData[i][0];
            double height = personData[i][1];
            double bmi = weight / (height * height);

            personData[i][2] = bmi;

            if (bmi <= 18.4)
            {
                weightStatus[i] = "Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                weightStatus[i] = "Normal";
            }
            else if (bmi >= 25.0 && bmi <= 39.9)
            {
                weightStatus[i] = "Overweight";
            }
            else
            {
                weightStatus[i] = "Obese";
            }
        }

        Console.WriteLine("\nPerson Details:");
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine($"Person {i + 1}: Height = {personData[i][1]:F2}m, Weight = {personData[i][0]:F2}kg, BMI = {personData[i][2]:F2}, Status = {weightStatus[i]}");
        }
    }
}
