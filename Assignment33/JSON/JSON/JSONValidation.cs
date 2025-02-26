using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace JSON
{
    public class JSONValidation
    {
        public static void Print()
        {
            // Define JSON schema
            string schemaJson = @"{
                'type': 'object',
                'properties': {
                    'name': { 'type': 'string' },
                    'email': { 'type': 'string', 'format': 'email' },
                    'age': { 'type': 'integer', 'minimum': 18 }
                },
                'required': ['name', 'email', 'age']
            }";

           
            string validJson = @"{
                'name': 'Somesh Purwar',
                'email': 'somesh.purwar@gmail.com',
                'age': 21
            }";

            string invalidJson = @"{
                'name': 'Shubham',
                'email': 'shubhamgmail.com',
                'age': 16
            }";

           
            JSchema schema = JSchema.Parse(schemaJson);

            
            ValidateJson(validJson, schema);
            ValidateJson(invalidJson, schema);
        }

        public static void ValidateJson(string jsonData, JSchema schema)
        {
            JObject jsonObject = JObject.Parse(jsonData);
            IList<string> validationErrors = new List<string>();

            if (jsonObject.IsValid(schema, out validationErrors))
            {
                Console.WriteLine(" JSON is valid.");
            }
            else
            {
                Console.WriteLine(" JSON is invalid. Errors:");
                foreach (string error in validationErrors)
                {
                    Console.WriteLine($"- {error}");
                }
            }
        }
    }
}
