using System;

class SalaryBonus
{
    public static void print()
    {
        int numEmployees = 10;
        double[] salaries = new double[numEmployees];
        double[] yearsOfService = new double[numEmployees];
        double[] bonuses = new double[numEmployees];
        double[] newSalaries = new double[numEmployees];
        double totalBonus = 0.0;
        double totalOldSalary = 0.0;
        double totalNewSalary = 0.0;

        Console.WriteLine("Enter details for 10 employees:");

        for (int i = 0; i < numEmployees; i++)
        {
            double salary;
            do
            {
                Console.Write($"Enter salary for employee {i + 1}: ");
                salary = Convert.ToDouble(Console.ReadLine());
				if(salary<0){Console.Error.WriteLine($"Invalid Salary!! Enter again");}
            } while (salary < 0.0);

            double years;
            do
            {
                Console.Write($"Enter years of service for employee {i + 1}: ");
                years = Convert.ToDouble(Console.ReadLine());
				if(years<0){Console.Error.WriteLine($"Invalid years!! Enter again");}
            } while (years < 0.0);

            salaries[i] = salary;
            yearsOfService[i] = years;
        }

        for (int i = 0; i < numEmployees; i++)
        {
            bonuses[i] = yearsOfService[i] > 5 ? 0.05 * salaries[i] : 0.02 * salaries[i];
            newSalaries[i] = salaries[i] + bonuses[i];
            totalBonus += bonuses[i];
            totalOldSalary += salaries[i];
            totalNewSalary += newSalaries[i];
        }

        Console.WriteLine("\nEmployee Details:");
        for (int i = 0; i < numEmployees; i++)
        {
            Console.WriteLine($"Employee {i + 1}: Old Salary = {salaries[i]:F2}, Bonus = {bonuses[i]:F2}, New Salary = {newSalaries[i]:F2}");
        }

      
        Console.WriteLine($"Total Bonus Payout: {totalBonus:F2}");
        Console.WriteLine($"Total Old Salary: {totalOldSalary:F2}");
        Console.WriteLine($"Total New Salary: {totalNewSalary:F2}");
    }
}
