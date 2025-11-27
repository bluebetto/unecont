using Microsoft.EntityFrameworkCore;
using UneCont.Application.Interfaces;
using UneCont.Domain.Entities;
using UneCont.Infra.Context;

namespace UneCont.Infra.Repositories
{
    public class InvoiceRepository(UneContDbContext _context) : IInvoiceRepository
    {
        public async Task AddAsync(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Invoice>> GetAllAsync()
        {
            return await _context.Invoices.AsNoTracking().ToListAsync();
        }
    }
}
