using UneCont.Domain.Exceptions;

namespace UneCont.Domain.Entities
{
    public class Invoice : BaseEntity
    {
        public int Number { get; set; }
        public Provider Provider { get; set; }
        public Borrower Borrower { get; set; }
        public DateTime EmissionDate { get; set; }
        public Service Service { get; set; }

        public Invoice() { }

        public Invoice(
            Guid id,
            Provider provider,
            Borrower borrower,
            DateTime emissionDate,
            Service service
        )
            : base(id)
        {
            DomainValidationException.When(provider == null, "Prestador não informado");
            DomainValidationException.When(borrower == null, "Tomador não informado");
            DomainValidationException.When(emissionDate == default, "Data emissão não informada");
            DomainValidationException.When(service == null, "Serviço não informado");

            Provider = provider;
            Borrower = borrower;
            EmissionDate = emissionDate;
            Service = service;
        }
    }
}
