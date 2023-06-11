using CORE.PELUQUERIA.Interfaces;
using INFRAESTRUCTURE.PELUQUERIA.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace API.PELUQUERIA.Resolvers
{
    public static class ResolversPeluqueria
    {
        public static void ResolversPeluqueriaR(this IServiceCollection services)
        {
            services.AddTransient<IToken, TokenRepositorie>();
            services.AddTransient<INews, NewsRepositorie>();
        }
    }
}
