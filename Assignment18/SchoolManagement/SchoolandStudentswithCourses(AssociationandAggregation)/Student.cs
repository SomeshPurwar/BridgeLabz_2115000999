using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace SchoolandStudentswithCourses_AssociationandAggregation_
{
    class Student
    {
        public string name;
        private List<Course> courses;

        public Student(string name)
        {
            this.name = name;
            courses = new List<Course>();
        }

        public void enrollCourse(Course course)
        {
            courses.Add(course);
            course.addStudent(this);
        }

        public void viewCourses()
        {
            Console.WriteLine($"Student: {name} is enrolled in:");
            foreach (var course in courses)
            {
                Console.WriteLine($"  Course: {course.name}");
            }
        }
    }
}
