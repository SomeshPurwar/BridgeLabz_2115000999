using System;

namespace HospitalManagementSystem
{
    public class Patient
    {
        // Static variable shared among all patients
        public static string HospitalName = "Global Health Hospital";

        // Static variable to count total patients
        private static int totalPatients = 0;

        // Readonly variable for unique Patient ID
        public readonly int PatientID;

        // Instance variables
        private string name;
        private int age;
        private string ailment;

        // Constructor using 'this' to initialize Name, Age, and Ailment
        public Patient(string name, int age, string ailment)
        {
            this.name = name;
            this.age = age;
            this.ailment = ailment;
            this.PatientID = ++totalPatients; // Auto-incremented unique Patient ID
        }

        // Static method to get total patients admitted
        public static void GetTotalPatients()
        {
            Console.WriteLine($"Total Patients Admitted: {totalPatients}");
        }

        // Method to get patient details
        public string GetPatientDetails()
        {
            return $"Hospital Name: {HospitalName}\nPatient ID: {PatientID}\nName: {name}\nAge: {age}\nAilment: {ailment}";
        }

        // Method to check if an object is an instance of Patient before displaying details
        public static void DisplayPatientDetails(object obj)
        {
            if (obj is Patient patient)
            {
                Console.WriteLine(patient.GetPatientDetails());
            }
            else
            {
                Console.WriteLine("Invalid object. Not a Patient instance.");
            }
        }
    }
}
