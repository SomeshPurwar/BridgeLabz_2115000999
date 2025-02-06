using System;
using System.Collections.Generic;

namespace HospitalSystemAssociation
{
    class Patient
    {
        public string name;
        public List<string> consultationHistory;

        public Patient(string name)
        {
            this.name = name;
            consultationHistory = new List<string>();
        }

        public void showConsultationHistory()
        {
            Console.WriteLine($"Patient: {name}'s Consultation History:");
            foreach (var consultation in consultationHistory)
            {
                Console.WriteLine($"  {consultation}");
            }
        }

    }

    



    
}
