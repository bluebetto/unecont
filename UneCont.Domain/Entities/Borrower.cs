namespace UneCont.Domain.Entities
{
    public class Borrower : BaseCnpjEntity
    {
        public Invoice Invoice { get; set; }
        public Guid InvoiceId { get; set; }
        public Borrower() { }

        public Borrower(Guid id, string cnpj)
        {
            Validate(cnpj);

            Id = id;
            Cnpj = cnpj;
        }
    }
}
