using System;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace ДЗ_12
{
    [Serializable]
    public class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple(10, "Red", "Pinova", 5, "Hard", 98.34);

            ////XML

            var xmlSerializer = new XMLSerializer();
            var data = xmlSerializer.Serialize(apple);
            var deserialization = xmlSerializer.Deserialize(data);



            #region JSON
            //сериализация в JSON

            //string json = JsonSerializer.Serialize(apple);
            //Console.WriteLine(json);

            ////десериализация из JSON
            //Apple deserializedApple = JsonSerializer.Deserialize<Apple>(json);
            //Console.WriteLine($"Number of pips: {deserializedApple.Numberofpips}, " +
            //    $"Color: {deserializedApple.Color}, Grade: {deserializedApple.Grade}, " +
            //    $"Size: {deserializedApple.Size}, Peel: {deserializedApple.Peel}, " +
            //    $"Weight: {deserializedApple.Weight}");
            #endregion

            #region XML
            //создание экземпляра XmlSerializer
            XmlSerializer serializer = new XmlSerializer(typeof(Apple));

            using (FileStream fs = new FileStream("apple.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, apple);

                Console.WriteLine("Object has been serialized");
            }

            #endregion
            Console.ReadKey();
        }
    }
}
