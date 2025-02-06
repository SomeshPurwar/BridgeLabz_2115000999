using System;
using System.Collections.Generic;

namespace HospitalSystemAssociation
{
    class Doctor
    {
        public string name;
        private List<Patient> patients;

        public Doctor(string name)
        {
            this.name = name;
            patients = new List<Patient>();
        }

        public void consult(Patient patient)
        {
            Console.WriteLine($"Doctor {name} is consulting with Patient {patient.name}. \nConsultation details:");
            patient.consultationHistory.Add($"Consultation with Dr. {name}");
            patients.Add(patient);
        }

        public void showConsultations()
        {
            Console.WriteLine($"Dr. {name}'s Consultation History:");
            foreach (var patient in patients)
            {
                Console.WriteLine($"  Patient: {patient.name}");
            }
        }
    }
}
