using System;
using System.Collections.Generic;

namespace UniversityManagementSystem
{
    class Professor
    {
        public string name;

        public Professor(string name)
        { 
            this.name = name;
        }

        public void assignCourse(Course course)
        {
            course.assignProfessor(this);
        }
    }
}
