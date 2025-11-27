using MediatR;
using UneCont.Application.Interfaces;
using UneCont.Application.Invoices.Queries;
using UneCont.Application.Invoices.Results;

namespace UneCont.Application.Invoices.Handlers
{
    public class GetInvoicesQueryHandler(IInvoiceService service)
        : IRequestHandler<GetInvoicesQuery, GetInvoicesQueryResult>
    {
        public async Task<GetInvoicesQueryResult> Handle(
            GetInvoicesQuery request,
            CancellationToken cancellationToken
        )
        {
            var result = await service.GetAllAsync();
            return new GetInvoicesQueryResult(result);
        }
    }
}
