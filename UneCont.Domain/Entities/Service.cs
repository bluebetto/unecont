using UneCont.Domain.Exceptions;

namespace UneCont.Domain.Entities
{
    public class Service : BaseEntity
    {
        public string Description { get; set; }
        public decimal Value { get; set; }

        public Guid InvoiceId { set; get; }

        public Invoice Invoice { get; set; }

        public Service(string description, decimal value)
        {
            DomainValidationException.When(
                string.IsNullOrWhiteSpace(description),
                "Descrição é obrigatoria"
            );

            DomainValidationException.When(value < 0, "Valor deve ser maior que zero");

            Description = description;
            Value = value;
        }

        public Service() { }
    }
}
