using Amazon.DynamoDBv2.Model;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace AWS.BOOL.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var streamReader = new StreamReader("example.json"))
            {
                string reader = streamReader.ReadToEnd();
                Console.WriteLine("AttributeValue before being de-serialized");
                Console.WriteLine(reader);

                var result = JsonConvert.DeserializeObject<AttributeValue>(reader);

                Console.WriteLine("AttributeValue after being de-serialized");
                Console.WriteLine($@"Bool Value: {result.BOOL}");
            }
        }
    }
}

