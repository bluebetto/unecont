using MediatR;
using UneCont.Application.Invoices.Commands;
using UneCont.Application.Invoices.Results;

namespace UneCont.Application.Invoices.Handlers
{
    public class CreateInvoiceCommandHandler
        : IRequestHandler<CreateInvoiceCommand, CreateInvoiceCommandResult>
    {
        public Task<CreateInvoiceCommandResult> Handle(
            CreateInvoiceCommand request,
            CancellationToken cancellationToken
        )
        {
            Console.WriteLine(request);
            throw new NotImplementedException();
        }
    }
}
