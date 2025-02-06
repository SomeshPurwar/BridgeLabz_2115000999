using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace UniversityManagementSystem
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
        }

        public void showCourses()
        {
            Console.WriteLine($"Student: {name} is enrolled in the following courses:");
            foreach (var course in courses)
            {
                Console.WriteLine($"  Course: {course.name}");
            }
        }
    }
}
