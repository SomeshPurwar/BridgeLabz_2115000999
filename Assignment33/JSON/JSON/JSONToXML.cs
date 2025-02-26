using System;
using System.Xml;
using Newtonsoft.Json;

namespace JSON
{
    public class JSONtoXML
    {
        public static void Print()
        {
            
            string json = @"{
                'Person': {
                    'Name': 'Somesh',
                    'Age': 21,
                    'Email': 'somesh@gmail.com'
                }
            }";

            
            XmlDocument xmlDoc = JsonConvert.DeserializeXmlNode(json, "Root");

            
            Console.WriteLine("Converted XML:");
            Console.WriteLine(xmlDoc.OuterXml);
        }
    }
}
