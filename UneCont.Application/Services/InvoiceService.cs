using AutoMapper;
using UneCont.Application.Dto;
using UneCont.Application.Interfaces;
using UneCont.Domain.Entities;

namespace UneCont.Application.Services
{
    public class InvoiceService(IInvoiceRepository repository, IMapper mapper) : IInvoiceService
    {
        public async Task AddAsync(InvoiceDto invoice)
        {
            await repository.AddAsync(mapper.Map<Invoice>(invoice));
        }

        public async Task<IEnumerable<InvoiceDto>> GetAllAsync()
        {
            var result = await repository.GetAllAsync();
            return mapper.Map<IEnumerable<InvoiceDto>>(result);
        }
    }
}
