using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    public static class Serializer
    {
        public static string ToXml<T>(this T @object)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            var stringBuilder = new StringBuilder();
            using (var stringWriter = new StringWriter(stringBuilder))
                xmlSerializer.Serialize(stringWriter, @object);
            return stringBuilder.ToString();
        }
    }
}