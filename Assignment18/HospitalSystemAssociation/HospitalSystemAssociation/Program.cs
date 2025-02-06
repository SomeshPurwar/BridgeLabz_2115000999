using System;
using HospitalSystemAssociation;

class Program
{
    static void Main()
    {
        // Create Hospital
        Hospital hospital = new Hospital("Nayati Hospital");

        // Create Doctors
        Doctor doctor1 = new Doctor("OP Sharma");
        Doctor doctor2 = new Doctor("Pawan Sharma");

        // Add Doctors to Hospital
        hospital.addDoctor(doctor1);
        hospital.addDoctor(doctor2);

        // Create Patients
        Patient patient1 = new Patient("Ayush");
        Patient patient2 = new Patient("Nikhil");

        // Doctors consulting with Patients
        doctor1.consult(patient1);
        doctor1.consult(patient2);

        doctor2.consult(patient1);

        // Show Doctors and their Consultations
        hospital.showDoctors();
        doctor1.showConsultations();
        doctor2.showConsultations();

        // Show Patient Consultation History
        patient1.showConsultationHistory();
        patient2.showConsultationHistory();
    }
}