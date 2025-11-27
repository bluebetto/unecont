using UneCont.Application.Dto;

namespace UneCont.Application.Interfaces
{
    public interface IInvoiceService
    {
        Task AddAsync(InvoiceDto invoice);
        Task<IEnumerable<InvoiceDto>> GetAllAsync();
    }
}
