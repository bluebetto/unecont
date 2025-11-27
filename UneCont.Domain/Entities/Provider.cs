namespace UneCont.Domain.Entities
{
    public class Provider : BaseCnpjEntity
    {
        public Guid InvoiceId { get; set; }

        public ICollection<Invoice> Invoices { get; set; }

        public Provider(Guid id, string cnpj)
        {
            Validate(cnpj);
            Id = id;
            Cnpj = cnpj;
        }
    }
}
