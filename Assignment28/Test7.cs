using System;
using System.IO;

class Test7 {
    private static string filePath = "students.dat";

    public static void Print() {
        StoreStudentData();
        RetrieveStudentData();
    }

    private static void StoreStudentData() {
        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        using (BinaryWriter writer = new BinaryWriter(fs)) {
            writer.Write(1);
            writer.Write("Alice");
            writer.Write(3.8);

            writer.Write(2);
            writer.Write("Bob");
            writer.Write(3.6);

            Console.WriteLine("Student data stored successfully.");
        }
    }

    private static void RetrieveStudentData() {
        if (!File.Exists(filePath)) {
            Console.WriteLine("No student data found.");
            return;
        }

        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        using (BinaryReader reader = new BinaryReader(fs)) {
            Console.WriteLine("Student Data Retrieved:");
            while (fs.Position < fs.Length) {
                int rollNumber = reader.ReadInt32();
                string name = reader.ReadString();
                double gpa = reader.ReadDouble();
                Console.WriteLine($"Roll No: {rollNumber}, Name: {name}, GPA: {gpa}");
            }
        }
    }
}
