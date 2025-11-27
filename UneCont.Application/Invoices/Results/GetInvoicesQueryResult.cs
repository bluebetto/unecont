using UneCont.Application.Dto;

namespace UneCont.Application.Invoices.Results
{
    public record GetInvoicesQueryResult(IEnumerable<InvoiceDto> Data);
}
