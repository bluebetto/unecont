using MediatR;
using UneCont.Application.Invoices.Results;

namespace UneCont.Application.Invoices.Queries
{
    public class GetInvoicesQuery : IRequest<GetInvoicesQueryResult>;
}
