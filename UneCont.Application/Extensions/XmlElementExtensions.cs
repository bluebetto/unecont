using System.Xml;
using System.Xml.Serialization;

namespace UneCont.Application.Extensions
{
    public static class XmlElementExtensions
    {
        public static T ConvertToDto<T>(this XmlElement xmlElement)
            where T : class
        {
            var serializer = new XmlSerializer(typeof(T));

            // Converte XmlElement para XmlReader
            using var xmlReader = new XmlNodeReader(xmlElement);
            return (T)serializer.Deserialize(xmlReader)!;
        }
    }
}
