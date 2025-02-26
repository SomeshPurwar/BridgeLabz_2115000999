using System.Collections.Generic;
using Newtonsoft.Json;
namespace JSON
{

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IList<string> Subjects { get; set; }
    }

    public class Test1
    {
        public static void Print()
        {
            Student student = new Student
            {
                Name = "Somesh Purwar",
                Age = 21,
                Subjects = new List<string> { "Cryptography", "Mobile Computing" }
            };

            string json = JsonConvert.SerializeObject(student,Formatting.Indented);
            Console.WriteLine(json);

        }
    }

}
