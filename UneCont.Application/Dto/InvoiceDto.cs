using System.Xml.Serialization;

namespace UneCont.Application.Dto
{
    [XmlRoot("NotaFiscal")]
    public class InvoiceDto
    {
        public Guid Id { get; set; }

        [XmlElement("Numero")]
        public int Number { get; set; }

        [XmlElement("Prestador")]
        public ProviderDto Provider { get; set; }

        [XmlElement("Tomador")]
        public BorrowerDto Borrower { get; set; }

        [XmlElement("DataEmissao")]
        public DateTime EmissionDate { get; set; }

        [XmlElement("Servico")]
        public ServiceDto Service { get; set; }
    }
}
