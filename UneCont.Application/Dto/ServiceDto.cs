using System.Xml.Serialization;

namespace UneCont.Application.Dto
{
    public record ServiceDto
    {
        [XmlElement("Descricao")]
        public string Description { get; set; }

        [XmlElement("Valor")]
        public decimal Value { get; set; }
    }
}
