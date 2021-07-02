using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using AppService.Data;

namespace KnowYourCustomer.Framework.Configuration
{
    public static class IocConfiguration
    {
        public static void Init(IConfiguration configuration, IServiceCollection services)
        {
            services.AddScoped<KnowYourCustomerDbContext, KnowYourCustomerDbContext>();

            services.Scan(x => x.FromAssemblyOf<KnowYourCustomerDbContext>()
                .AddClasses()
                .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                .AsMatchingInterface()
                .WithScopedLifetime());
        }
    }
}
