using AutoMapper;
using UneCont.Application.Dto;
using UneCont.Domain.Entities;

namespace UneCont.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<InvoiceDto, Invoice>().ReverseMap();
            CreateMap<BorrowerDto, Borrower>().ReverseMap();
            CreateMap<ProviderDto, Provider>().ReverseMap();
            CreateMap<ServiceDto, Service>().ReverseMap();
        }
    }
}
