using UneCont.Domain.Entities;

namespace UneCont.Application.Interfaces
{
    public interface IInvoiceRepository
    {
        Task AddAsync(Invoice invoice);
        Task<IEnumerable<Invoice>> GetAllAsync();
    }
}
