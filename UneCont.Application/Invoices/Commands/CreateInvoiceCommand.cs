using MediatR;
using UneCont.Application.Dto;
using UneCont.Application.Invoices.Results;

namespace UneCont.Application.Invoices.Commands
{
    public class CreateInvoiceCommand : IRequest<CreateInvoiceCommandResult>
    {
        public InvoiceDto Invoice { get; set; }

        public CreateInvoiceCommand(InvoiceDto invoice)
        {
            Invoice = invoice;
        }
    }
}
