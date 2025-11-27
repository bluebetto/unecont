using Microsoft.Extensions.DependencyInjection;
using UneCont.Application.Interfaces;
using UneCont.Infra.Repositories;

namespace UneCont.Infra
{
    public static class ServiceCollectionExtensios
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();

            return services;
        }
    }
}
