namespace UneCont.Domain.Entities
{
    public class Borrower : BaseCnpjEntity
    {
        public Borrower() { }

        public Borrower(Guid id, string cnpj)
        {
            Validate(cnpj);

            Id = id;
            Cnpj = cnpj;
        }

        public Guid InvoiceId { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
    }
}
