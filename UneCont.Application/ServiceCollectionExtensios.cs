using Microsoft.Extensions.DependencyInjection;
using UneCont.Application.Interfaces;
using UneCont.Application.Invoices.Handlers;
using UneCont.Application.Profiles;
using UneCont.Application.Services;

namespace UneCont.Application
{
    public static class ServiceCollectionExtensios
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IInvoiceService, InvoiceService>();
            services.AddMediatR(options =>
                options.RegisterServicesFromAssemblyContaining<GetInvoicesQueryHandler>()
            );

            services.AddAutoMapper(options => options.AddProfile<MappingProfile>());

            return services;
        }
    }
}
