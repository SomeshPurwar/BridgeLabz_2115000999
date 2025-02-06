using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace HospitalSystemAssociation
{
    class Hospital
    {
        public string name;
        private List<Doctor> doctors;
        public Hospital(string name) 
        {
            this.name = name;
            doctors = new List<Doctor>();
        }

        public void addDoctor(Doctor doctor)
        {
            doctors.Add(doctor);
        }

        public void showDoctors()
        {
            Console.WriteLine($"Hospital: {name} has the following doctors:");
            foreach (var doctor in doctors)
            {
                Console.WriteLine($"  Dr. {doctor.name}");
            }
        }
    }
}
