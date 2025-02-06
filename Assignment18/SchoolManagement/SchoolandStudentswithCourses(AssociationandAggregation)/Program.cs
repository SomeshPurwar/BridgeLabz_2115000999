using System;
using SchoolandStudentswithCourses_AssociationandAggregation_;

class Program
{
    static void Main()
    {
        School school = new School("Vidyasagar School");

        Student somesh = new Student("Somesh");
        Student krishna = new Student("Krishna");

        Course math = new Course("Mathematics");
        Course science = new Course("Science");

        somesh.enrollCourse(math);
        somesh.enrollCourse(science);
        krishna.enrollCourse(math);

        school.addStudent(somesh);
        school.addStudent(krishna);

        school.showStudents();

        math.showStudents();
        science.showStudents();
    }
}