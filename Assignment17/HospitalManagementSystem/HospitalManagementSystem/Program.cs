using HospitalManagementSystem;

class Program
{
    static void Main()
    {
        Patient[] patients = new Patient[10];
        int patientCount = 0;

        Console.WriteLine($"Welcome to {Patient.HospitalName}!");

        while (true)
        {
            Console.WriteLine("\n1. Admit Patient");
            Console.WriteLine("2. Display Patient Details");
            Console.WriteLine("3. Get Total Patients");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Admit a new patient
                    if (patientCount >= patients.Length)
                    {
                        // Double the array size when full
                        Console.WriteLine("Limit Exceed!!");
                    }

                    Console.Write("Enter Patient Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Age: ");
                    int age = int.Parse(Console.ReadLine());

                    Console.Write("Enter Ailment: ");
                    string ailment = Console.ReadLine();

                    // Creating new patient object
                    patients[patientCount] = new Patient(name, age, ailment);
                    Console.WriteLine($"Patient admitted successfully with ID: {patients[patientCount].PatientID}");
                    patientCount++;
                    break;

                case 2:
                    // Display patient details
                    Console.Write("Enter Patient ID: ");
                    int searchID = int.Parse(Console.ReadLine());

                    bool found = false;
                    foreach (var patient in patients)
                    {
                        if (patient != null && patient.PatientID == searchID)
                        {
                            Patient.DisplayPatientDetails(patient);
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Patient not found.");
                    }
                    break;

                case 3:
                    // Get total number of patients
                    Patient.GetTotalPatients();
                    break;

                case 4:
                    // Exit program
                    Console.WriteLine("Exiting... Thank you!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}