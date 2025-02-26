using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JSON
{
    public class Students
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Subjects { get; set; }
    }

    public class ListToJSONList
    {
        public static void Print()
        {
            
            List<Student> students = new List<Student>
            {
                new Student { Name = "Somesh", Age = 21, Subjects = new List<string> { "Math", "Physics", "Computer Science" } },
                new Student { Name = "Shubham", Age = 21, Subjects = new List<string> { "Chemistry", "Biology" } },
                new Student { Name = "Bengali", Age = 22, Subjects = new List<string> { "Computer Science", "English" } }
            };

            
            string jsonArray = JsonConvert.SerializeObject(students, Formatting.Indented);


            Console.WriteLine(jsonArray);
        }
    }
}
