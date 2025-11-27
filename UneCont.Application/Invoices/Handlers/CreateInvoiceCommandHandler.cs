using MediatR;
using UneCont.Application.Interfaces;
using UneCont.Application.Invoices.Commands;
using UneCont.Application.Invoices.Results;


namespace UneCont.Application.Invoices.Handlers
{
    public class CreateInvoiceCommandHandler(IInvoiceService invoiceService)
        : IRequestHandler<CreateInvoiceCommand, CreateInvoiceCommandResult>
    {
        public async Task<CreateInvoiceCommandResult> Handle(
            CreateInvoiceCommand request,
            CancellationToken cancellationToken
        )
        {
            request.Invoice.Id = Guid.NewGuid();
            await invoiceService.AddAsync(request.Invoice);

            return new CreateInvoiceCommandResult();
        }
    }
}
