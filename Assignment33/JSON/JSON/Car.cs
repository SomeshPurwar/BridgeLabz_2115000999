using System;
using Newtonsoft.Json;

namespace JSON
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }

    public class Test2
    {
        public static void Print()
        {
            
            Car myCar = new Car
            {
                Brand = "Tesla",
                Model = "Model S",
                Year = 2023
            };

            
            string json = JsonConvert.SerializeObject(myCar, Formatting.Indented);

            Console.WriteLine(json);
        }
    }
}
