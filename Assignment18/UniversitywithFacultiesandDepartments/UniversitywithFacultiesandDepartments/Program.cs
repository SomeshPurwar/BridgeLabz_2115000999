using System;
using UniversitywithFacultiesandDepartments;

class Program
{
    static void Main()
    {
        // Create Faculty Members (Aggregation: Faculty can exist independently)
        Faculty faculty1 = new Faculty("Mr. Shubham Mishra");
        Faculty faculty2 = new Faculty("Mr. Asheesh Tiwari");
        Faculty faculty3 = new Faculty("Mr. Rakesh Galav ");

        // Create Departments (Composition: Deleting University deletes departments)
        Department department1 = new Department("Computer Science");
        department1.addFaculty(faculty1);
        department1.addFaculty(faculty2);

        Department department2 = new Department("Physics");
        department2.addFaculty(faculty3);

        // Create University (University holds references to departments)
        University university = new University("GLA University");
        university.addDepartment(department1);
        university.addDepartment(department2);

        // Display University and Departments before deletion
        university.showDepartments();

        // Now, delete the university (This deletes the departments as well due to composition)
        university.deleteUniversity();

        // The faculty members still exist independently (because of aggregation)
        Console.WriteLine("\nAfter Deleting University:");
        Console.WriteLine($"Faculty: {faculty1.name}");
        Console.WriteLine($"Faculty: {faculty2.name}");
        Console.WriteLine($"Faculty: {faculty3.name}");

        // Try to display departments (they are deleted after the university is deleted)
        university.showDepartments(); // No departments should exist now.
    }
}