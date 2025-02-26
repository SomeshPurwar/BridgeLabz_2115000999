using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace JSON
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }

    public class JSONFilter
    {
        public static void Print()
        {
            
            string jsonData = @"[
                { 'Name': 'Somesh', 'Age': 21, 'Email': 'somesh@gmail.com' },
                { 'Name': 'Shubham', 'Age': 21, 'Email': 'shubham@gmail.com' },
                { 'Name': 'Nikhil', 'Age': 25, 'Email': 'nikhil@gmail.com' },
                { 'Name': 'Ayush', 'Age': 26, 'Email': 'ayush@gmail.com' }
            ]";

            
            List<Person> people = JsonConvert.DeserializeObject<List<Person>>(jsonData);

            
            var filteredPeople = people.Where(p => p.Age > 25).ToList();

            
            string filteredJson = JsonConvert.SerializeObject(filteredPeople, Formatting.Indented);

            
            Console.WriteLine(filteredJson);
        }
    }
}
