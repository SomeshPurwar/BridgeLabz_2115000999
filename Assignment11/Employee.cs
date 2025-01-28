using System;

public class Employee
{
    public static void print()
    {
        double[,] employees = GenerateEmployeesData(10);
        double[,] updatedData = CalculateNewSalaryAndBonus(employees);
        DisplaySummary(employees, updatedData);
    }

    static double[,] GenerateEmployeesData(int numberOfEmployees)
    {
        Random random = new Random();
        double[,] data = new double[numberOfEmployees, 2];
        for (int i = 0; i < numberOfEmployees; i++)
        {
            data[i, 0] = random.Next(30000, 100000); // Salary (5 digits)
            data[i, 1] = random.Next(1, 11); // Years of service (1 to 10)
        }
        return data;
    }

    static double[,] CalculateNewSalaryAndBonus(double[,] employees)
    {
        int numberOfEmployees = employees.GetLength(0);
        double[,] updatedData = new double[numberOfEmployees, 2];
        for (int i = 0; i < numberOfEmployees; i++)
        {
            double salary = employees[i, 0];
            double yearsOfService = employees[i, 1];
            double bonusPercentage = yearsOfService > 5 ? 0.05 : 0.02;
            double bonus = salary * bonusPercentage;
            double newSalary = salary + bonus;
            updatedData[i, 0] = newSalary;
            updatedData[i, 1] = bonus;
        }
        return updatedData;
    }

    static void DisplaySummary(double[,] oldData, double[,] updatedData)
    {
        int numberOfEmployees = oldData.GetLength(0);
        double totalOldSalary = 0, totalNewSalary = 0, totalBonus = 0;

        Console.WriteLine("Employee\tOld Salary\tYears of Service\tBonus\t\tNew Salary");
        Console.WriteLine("---------------------------------------------------------------------------------");

        for (int i = 0; i < numberOfEmployees; i++)
        {
            double oldSalary = oldData[i, 0];
            double yearsOfService = oldData[i, 1];
            double bonus = updatedData[i, 1];
            double newSalary = updatedData[i, 0];

            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;

            Console.WriteLine($"{i + 1}\t\t{oldSalary:F2}\t\t{yearsOfService}\t\t{bonus:F2}\t\t{newSalary:F2}");
        }

        Console.WriteLine("---------------------------------------------------------------------------------");
        Console.WriteLine($"Total\t\t{totalOldSalary:F2}\t\t\t\t{totalBonus:F2}\t{totalNewSalary:F2}");
    }
}
