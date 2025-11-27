using System.Text.RegularExpressions;
using UneCont.Domain.Exceptions;

namespace UneCont.Domain.Entities
{
    public partial class BaseCnpjEntity : BaseEntity
    {
        public string Cnpj { get; set; } = string.Empty;

        protected void Validate(string cnpj)
        {
            cnpj = OnlyNumbers().Replace(cnpj, "");
            DomainValidationException.When(cnpj.Length < 14, "Cnpj deve conter 14 digitos");
        }

        [GeneratedRegex("[^0-9]")]
        protected static partial Regex OnlyNumbers();
    }
}
