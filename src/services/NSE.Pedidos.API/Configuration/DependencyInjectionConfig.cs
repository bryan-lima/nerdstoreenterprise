using MediatR;
using NSE.Core.Mediator;
using NSE.Pedidos.Domain.Vouchers;
using NSE.Pedidos.Infra.Data.Repository;
using NSE.Pedidos.Infra.Data;
using NSE.WebAPI.Core.Usuario;
using NSE.Pedidos.API.Application.Queries;
using NSE.Pedidos.Domain.Pedidos;
using NSE.Pedidos.API.Application.Commands;
using NSE.Pedidos.API.Application.Events;
using FluentValidation.Results;

namespace NSE.Pedidos.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // API
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();

            // Commands
            services.AddScoped<IRequestHandler<AdicionarPedidoCommand, ValidationResult>, PedidoCommandHandler>();

            // Events
            services.AddScoped<INotificationHandler<PedidoRealizadoEvent>, PedidoEventHandler>();

            // Application
            services.AddScoped<IMediatorHandler, MediatorHandler>();
            services.AddScoped<IPedidoQueries, PedidoQueries>();
            services.AddScoped<IVoucherQueries, VoucherQueries>();

            // Data
            services.AddScoped<PedidosContext>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IVoucherRepository, VoucherRepository>();
        }
    }
}
