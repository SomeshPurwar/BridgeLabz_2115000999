using System;
using UniversityManagementSystem;

class Program
{
    static void Main()
    {
        // Create Professors
        Professor professor1 = new Professor("Dr. Asheesh Tiwari");
        Professor professor2 = new Professor("Dr. Rakesh Galav");

        // Create Courses
        Course course1 = new Course("Mathematics");
        Course course2 = new Course("Computer Science");

        // Assign Professors to Courses
        professor1.assignCourse(course1);
        professor2.assignCourse(course2);

        // Create Students
        Student student1 = new Student("Shyam");
        Student student2 = new Student("Sundar");

        // Students Enroll in Courses
        course1.enrollStudent(student1);
        course2.enrollStudent(student2);
        course1.enrollStudent(student2);

        // Show Course Details and Enrolled Students
        course1.showEnrolledStudents();
        course2.showEnrolledStudents();

        // Show Student's Enrolled Courses
        student1.showCourses();
        student2.showCourses();
    }
}