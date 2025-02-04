using EmployeeManagementSystem;

class Program
{
    static void Main()
    {
        Employee[] employees = new Employee[2];
        int employeeCount = 0;

        while (true)
        {
            Console.WriteLine("\nEmployee Management System");
            Console.WriteLine("1. Add a New Employee");
            Console.WriteLine("2. Display Employee Details");
            Console.WriteLine("3. Display Total Employees");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Add a new employee
                    if (employeeCount >= employees.Length)
                    {
                        // Double the size of the array if it's full
                        Console.WriteLine("Limit Exceed!");
                    }

                    Console.Write("Enter Employee Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Employee ID: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Enter Employee Designation: ");
                    string designation = Console.ReadLine();

                    // Creating a new employee object
                    employees[employeeCount] = new Employee(name, id, designation);
                    employeeCount++;
                    Console.WriteLine("Employee added successfully!");
                    break;

                case 2:
                    // Display employee details
                    Console.Write("Enter Employee ID to display details: ");
                    int searchId = int.Parse(Console.ReadLine());

                    bool found = false;
                    foreach (var employee in employees)
                    {
                        if (employee != null && employee.Id == searchId)
                        {
                            Employee.DisplayEmployeeDetails(employee);
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Employee with the given ID not found.");
                    }
                    break;

                case 3:
                    // Display total employees
                    Employee.DisplayTotalEmployees();
                    break;

                case 4:
                    // Exit the program
                    Console.WriteLine("Exiting... Thank you for using the Employee Management System.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}