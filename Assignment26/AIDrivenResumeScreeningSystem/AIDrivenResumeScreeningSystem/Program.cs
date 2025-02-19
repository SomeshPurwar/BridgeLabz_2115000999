using System;
using System.Collections.Generic;

// Abstract JobRole class
public abstract class JobRole
{
    public abstract string GetRoleName();
}

// Specific job roles
public class SoftwareEngineer : JobRole
{
    public override string GetRoleName() => "Software Engineer";
}

public class DataScientist : JobRole
{
    public override string GetRoleName() => "Data Scientist";
}

// Generic Resume class
public class Resume<T> where T : JobRole, new()
{
    public T Job;
    public string CandidateName;
    public string Skills;

    public Resume(string candidateName, string skills)
    {
        Job = new T();
        CandidateName = candidateName;
        Skills = skills;
    }

    public void DisplayResume()
    {
        Console.WriteLine($"Candidate: {CandidateName}, Role: {Job.GetRoleName()}, Skills: {Skills}");
    }
}

// Resume Screening System
public static class ResumeScreeningSystem
{
    private static List<object> screenedResumes = new List<object>();

    public static void ProcessResume<T>(Resume<T> resume) where T : JobRole, new()
    {
        screenedResumes.Add(resume);
        Console.WriteLine("Resume successfully screened.");
    }

    public static void DisplayAllResumes()
    {
        foreach (var resume in screenedResumes)
        {
            ((dynamic)resume).DisplayResume();
        }
    }
}

// Main execution
class Program
{
    static void Main()
    {
        var resume1 = new Resume<SoftwareEngineer>("SP", "C#, .NET, SQL");
        var resume2 = new Resume<DataScientist>("KP", "Python, Machine Learning, SQL");

        ResumeScreeningSystem.ProcessResume(resume1);
        ResumeScreeningSystem.ProcessResume(resume2);

        Console.WriteLine("\nAll Screened Resumes:");
        ResumeScreeningSystem.DisplayAllResumes();
    }
}
