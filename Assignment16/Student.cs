using System;

class Test10{
    public static void Print(){
        Console.WriteLine("Enter Roll Number:");
        int rollNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter CGPA:");
        double cgpa = Convert.ToDouble(Console.ReadLine());


        Student student = new Student(rollNumber, name, cgpa);
        Console.WriteLine("\nStudent Details:");
        student.DisplayStudentDetails();
        Console.ReadKey();
        Console.WriteLine("Enter specialization for PG:");
        string specialization = Console.ReadLine();
        PostgraduateStudent pgStudent = new PostgraduateStudent(rollNumber, name, cgpa, specialization);


        Console.WriteLine("\nPostgraduate Student Details:");
        pgStudent.DisplayPostgraduateDetails();

        Console.ReadKey();
        Console.WriteLine("Enter new CGPA:");
        double newCGPA = Convert.ToDouble(Console.ReadLine());
        student.SetCGPA(newCGPA);

        Console.WriteLine("\nUpdated Student Details:");
        student.DisplayStudentDetails();
    }
}

public class Student{
    public int rollNumber;
    protected string name;
    private double CGPA;
    public Student(int rollNumber, string name, double CGPA){
        this.rollNumber = rollNumber;
        this.name = name;
        this.CGPA = CGPA;
    }
    public double GetCGPA(){
        return CGPA;
    }
    public void SetCGPA(double newCGPA){
        CGPA = newCGPA;
    }
    public void DisplayStudentDetails(){
        Console.WriteLine("Roll Number: "+rollNumber);
        Console.WriteLine("Name: "+name);
        Console.WriteLine("CGPA: "+CGPA+"\n");
    }
}

public class PostgraduateStudent : Student{
    private string specialization;
    public PostgraduateStudent(int rollNumber, string name, double CGPA, string specialization)
        : base(rollNumber, name, CGPA){
        this.specialization = specialization;
    }

    public void DisplayPostgraduateDetails(){
        Console.WriteLine("Roll Number: "+rollNumber);
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Specialization: "+specialization);
        Console.WriteLine("CGPA: "+GetCGPA()+"\n");
    }
}
