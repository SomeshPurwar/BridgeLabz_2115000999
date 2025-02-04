using System;
class Test8{
    public static void Print(){
        Console.WriteLine("Enter course name:");
        string courseName = Console.ReadLine();
        Console.WriteLine("Enter duration (in months):");
        int duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter fee:INR ");
        double fee = Convert.ToDouble(Console.ReadLine());
        Course course = new Course(courseName, duration, fee);
        Console.WriteLine("\nCourse Detail:");
        course.DisplayCourseDetails();
        Course.UpdateInstituteName();
        course.DisplayCourseDetails();
    }
}

public class Course{
    private string courseName;
    private int duration;
    private double fee;
    private static string instituteName = "GLA UNIVERSITY";
    public Course(string courseName, int duration, double fee){
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    public void DisplayCourseDetails(){
        Console.WriteLine("Institute Name: "+instituteName);
        Console.WriteLine("Course Name: "+courseName);
        Console.WriteLine("Duration: Inmonths "+duration);
        Console.WriteLine("Fee: INR "+fee+"\n");
    }
    public static void UpdateInstituteName(){
        
        Console.WriteLine("Enter new institute name:");
        instituteName = Console.ReadLine();
        Console.WriteLine();
     
        }
}
