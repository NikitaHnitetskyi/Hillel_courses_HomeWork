using System.Xml.Serialization;
using System.Data.SqlTypes;

namespace ДЗ_12
{
    public class XMLSerializer
    {
        private XmlSerializer serializer = new XmlSerializer(typeof(Apple));

        public string Serialize(Apple apple)
        {
            var writer = new StringWriter();

            serializer.Serialize(writer, apple);
            var xmlString = writer.ToString();

            Console.WriteLine(xmlString);
            return xmlString;
        }
        public Apple Deserialize(string data)
        {
            var reader = new StringReader(data);
            var deserializerApple = (Apple)serializer.Deserialize(reader);
            return deserializerApple;
        }
    }
}
