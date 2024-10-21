using Calculadora.Domain.CdbRoot.Interfaces;
using Calculadora.Domain.CdbRoot.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Calculadora.Infra.CrossCutting
{
    public static class DependencyInjection
    {                
        public static void AddDependencyInjectionConfig(this IServiceCollection services)
        {                
            services.AddScoped<ICdbService, CdbService>();                
        }
        
    }
}
