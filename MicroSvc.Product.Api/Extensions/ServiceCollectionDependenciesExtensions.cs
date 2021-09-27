namespace Buma.Op.Services.Notification.Api.Extensions
{
    using System.Diagnostics.Contracts;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    using MicroSvc.Product.ApplicationService.Implementations;
    using MicroSvc.Product.ApplicationService.Interfaces;
    using MicroSvc.Product.Domain.Repositories;
    using MicroSvc.Product.Infrastructure.Repositories;

    /// <summary>
    /// Service collection extension to configure dependency container.
    /// </summary>
    public static class ServiceCollectionDependenciesExtensions
    {
        /// <summary>
        /// Configures the IOC container
        /// </summary>
        /// <param name="serviceCollection">Service collection</param>
        /// <param name="configuration">The configuration.</param>
        /// <returns>Returns the same service collection</returns>
        public static IServiceCollection ConfigureDependencies(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            Contract.Assert(serviceCollection != null);
            Contract.Assert(configuration != null);

            serviceCollection.AddScoped<IProductService, ProductService>();
            serviceCollection.AddScoped<IProductRepository, ProductRepository>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            return serviceCollection;
        }
    }
}
