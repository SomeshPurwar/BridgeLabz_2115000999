using System;
using System.Collections.Generic;

// Abstract course type class
public abstract class CourseType { }
public class ExamCourse : CourseType { }
public class AssignmentCourse : CourseType { }

// Base Course class for all courses
public abstract class CourseBase
{
    public string CourseName;
    public string Department;

    protected CourseBase(string courseName, string department)
    {
        CourseName = courseName;
        Department = department;
    }

    public abstract void DisplayCourseInfo();
}

// Generic Course class restricted to specific course types
public class Course<T> : CourseBase where T : CourseType
{
    public T CourseEvaluationType;

    public Course(string courseName, string department, T evaluationType) : base(courseName, department)
    {
        CourseEvaluationType = evaluationType;
    }

    public override void DisplayCourseInfo()
    {
        Console.WriteLine($"Course: {CourseName}, Department: {Department}, Evaluation Type: {CourseEvaluationType.GetType().Name}");
    }
}

// University class to manage multiple courses
public class University
{
    private List<CourseBase> courses = new List<CourseBase>();

    public void AddCourse(CourseBase course)
    {
        if (course == null)
            throw new ArgumentNullException(nameof(course), "Course cannot be null");

        courses.Add(course);
    }

    public void DisplayAllCourses()
    {
        foreach (var course in courses)
        {
            course.DisplayCourseInfo();
        }
    }
}

// Main execution
class Program
{
    static void Main()
    {
        var university = new University();
        var mathCourse = new Course<ExamCourse>("Advanced Mathematics", "Science", new ExamCourse());
        var literatureCourse = new Course<AssignmentCourse>("World Literature", "Arts", new AssignmentCourse());

        
        university.AddCourse(mathCourse);
        university.AddCourse(literatureCourse);

 
        university.DisplayAllCourses();
    }
}
