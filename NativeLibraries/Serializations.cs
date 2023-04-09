using CursoCSharp.ObjectOrientedProgramming;
using System.Text.Json;

namespace CursoCSharp.NativeLibraries
{
    public class Serializations
    {
        public static void ObjectToJsonSerializationExample()
        {
            Dog dog = new Dog { Name = "Manchas" };
            string json = JsonSerializer.Serialize(dog);
            Console.WriteLine(json);
        }

        public static void JsonToObjectSerializationExample()
        {
            string json = "{\"Name\": \"Manchas\"}";
            Dog dog = JsonSerializer.Deserialize<Dog>(json);
            Console.WriteLine(dog.ToString());
        }
    }
}
