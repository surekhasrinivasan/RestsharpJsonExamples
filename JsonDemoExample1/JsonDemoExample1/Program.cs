using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JsonDemoExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parsing a JSON Object from string
            string json = @"{
                CPU: 'Intel',
                Drives: [
                    'DVD read/writer',
                    '500 gigabyte hard drive'
                ]
            }";

            JObject obj = JObject.Parse(json);
            Console.WriteLine(obj);

            // Parsing a JSON array from string
            string str = @"[
                'Small',
                'Medium',
                'Large'
            ]";

            JArray jarray = JArray.Parse(str);
            Console.WriteLine(jarray);
        }
    }
}
