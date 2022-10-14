using MediatR;
using NSE.Core.Mediator;
using NSE.Pedidos.Domain.Vouchers;
using NSE.Pedidos.Infra.Data.Repository;
using NSE.Pedidos.Infra.Data;
using NSE.WebAPI.Core.Usuario;
using NSE.Pedidos.API.Application.Queries;

namespace NSE.Pedidos.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // API
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();

            // Application
            services.AddScoped<IMediatorHandler, MediatorHandler>();
            services.AddScoped<IVoucherQueries, VoucherQueries>();

            // Data
            services.AddScoped<PedidosContext>();
            services.AddScoped<IVoucherRepository, VoucherRepository>();
        }
    }
}
