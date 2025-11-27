namespace UneCont.Domain.Entities
{
    public class Provider : BaseCnpjEntity
    {
        public Invoice Invoice { get; set; }
        public Guid InvoiceId { get; set; }

        public Provider(Guid id, string cnpj)
        {
            Validate(cnpj);
            Id = id;
            Cnpj = cnpj;
        }
    }
}
