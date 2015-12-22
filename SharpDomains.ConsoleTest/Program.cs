using NJsonSchema;
using NJsonSchema.CodeGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDomains.IdentityDomain.Events;
using System.IO;
using System.Diagnostics;
using NJsonSchema.CodeGeneration.CSharp;

namespace SharpDomains.ConsoleTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            //GenerateJsonSchema(typeof(IdentityClaimIssuedEvent));
            GenerateCSharpFromJsonSchema(typeof(IdentityClaimIssuedEvent));
        }

        private static void GenerateCSharpFromJsonSchema(Type type)
        {
            Console.WriteLine($"Generating C# classes for schema {type.FullName}.json");
            string jsonFileName = type.FullName + ".json";
            string csharpFileName = type.FullName + ".cs";
            JsonSchema4 schema = JsonSchema4.FromJson(File.ReadAllText(jsonFileName));

            var generator = new CSharpGenerator(schema);
            var content = generator.GenerateFile();

            Console.WriteLine(content);
            File.WriteAllText(csharpFileName, content);
            Console.WriteLine($"Saved as {csharpFileName}");

            Process.Start(".");
        }

        private static void GenerateJsonSchema(Type type)
        {
            Console.WriteLine($"Generating schema for type {type.FullName}");
            JsonSchema4 schema = JsonSchema4.FromType(type);

            string schemaJson = schema.ToJson();
            Console.WriteLine(schemaJson);

            string fileName = type.FullName + ".json";
            File.WriteAllText(fileName, schemaJson);
            Console.WriteLine($"Saved as {fileName}");

            Process.Start(".");
        }
    }
}
