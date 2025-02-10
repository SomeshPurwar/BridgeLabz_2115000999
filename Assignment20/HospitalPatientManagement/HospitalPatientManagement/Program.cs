using System;
namespace HospitalPatientManagement 
{

    // Abstract class Patient
    abstract class Patient
    {
        private string patientId;
        private string name;
        private int age;
        protected string diagnosis;
        protected string medicalHistory;

        public Patient(string patientId, string name, int age, string diagnosis, string medicalHistory)
        {
            this.patientId = patientId;
            this.name = name;
            this.age = age;
            this.diagnosis = diagnosis;
            this.medicalHistory = medicalHistory;
        }

        public string PatientId { get { return patientId; } }
        public string Name { get { return name; } }
        public int Age { get { return age; } }

        public abstract double CalculateBill();

        public virtual void GetPatientDetails()
        {
            Console.WriteLine($"Patient ID: {patientId}, Name: {name}, Age: {age}");
        }
    }

    // Interface IMedicalRecord
    interface IMedicalRecord
    {
        void AddRecord(string record);
        void ViewRecords();
    }

    // InPatient class
    class InPatient : Patient, IMedicalRecord
    {
        private double dailyCharge;
        private int daysAdmitted;
        private List<string> medicalRecords = new List<string>();

        public InPatient(string patientId, string name, int age, string diagnosis, string medicalHistory, double dailyCharge, int daysAdmitted)
            : base(patientId, name, age, diagnosis, medicalHistory)
        {
            this.dailyCharge = dailyCharge;
            this.daysAdmitted = daysAdmitted;
        }

        public override double CalculateBill()
        {
            return dailyCharge * daysAdmitted;
        }

        public void AddRecord(string record)
        {
            medicalRecords.Add(record);
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical Records:");
            foreach (var record in medicalRecords)
            {
                Console.WriteLine(record);
            }
        }
    }

    // OutPatient class
    class OutPatient : Patient, IMedicalRecord
    {
        private double consultationFee;
        private List<string> medicalRecords = new List<string>();

        public OutPatient(string patientId, string name, int age, string diagnosis, string medicalHistory, double consultationFee)
            : base(patientId, name, age, diagnosis, medicalHistory)
        {
            this.consultationFee = consultationFee;
        }

        public override double CalculateBill()
        {
            return consultationFee;
        }

        public void AddRecord(string record)
        {
            medicalRecords.Add(record);
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical Records:");
            foreach (var record in medicalRecords)
            {
                Console.WriteLine(record);
            }
        }
    }

    // Main class
    class Program
    {
        static void Main()
        {
            List<Patient> patients = new List<Patient>
        {
            new InPatient("P001", "ABC", 45, "Pneumonia", "No history", 500, 5),
            new OutPatient("P002", "XYZ", 30, "Flu", "No history", 100)
        };

            foreach (var patient in patients)
            {
                patient.GetPatientDetails();
                Console.WriteLine($"Total Bill: Rs.{patient.CalculateBill()}");
                if (patient is IMedicalRecord recordable)
                {
                    recordable.AddRecord("Initial Diagnosis: Stable condition");
                    recordable.ViewRecords();
                }
                Console.WriteLine();
            }
        }
    }

}