using System;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace ДЗ_12
{
    public class JSONSerializer
    {
        public string Serializer(Apple apple)
        {
            string json = JsonSerializer.Serialize(apple);
            Console.WriteLine(json);
            return json;
        }
        public Apple Deserialize(string json)
        {
            Apple deserializedApple = JsonSerializer.Deserialize<Apple>(json);
            return deserializedApple;
        }
    }
}
