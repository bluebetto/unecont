using System.Xml.Serialization;

namespace UneCont.Application.Dto
{
    public record ProviderDto
    {
        public Guid Id { get; set; }

        [XmlElement("CNPJ")]
        public string Cnpj { get; set; }
    }
}
