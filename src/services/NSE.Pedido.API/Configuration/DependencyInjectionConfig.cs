using MediatR;
using NSE.Core.Mediator;
using NSE.Pedidos.Domain.Vouchers;
using NSE.Pedidos.Infra.Data.Repository;
using NSE.Pedidos.Infra.Data;
using NSE.WebAPI.Core.Usuario;

namespace NSE.Pedido.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<PedidosContext>();
            services.AddScoped<IMediatorHandler, MediatorHandler>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();
        }
    }
}
