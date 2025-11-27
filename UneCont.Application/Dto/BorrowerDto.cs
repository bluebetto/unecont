using System.Xml.Serialization;

namespace UneCont.Application.Dto
{
    public record BorrowerDto
    {
        public Guid Id { get; set; }

        [XmlElement("CNPJ")]
        public string Cnpj { get; set; }
    }
}
