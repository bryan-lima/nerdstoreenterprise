using FluentValidation.Results;
using MediatR;
using NSE.Core.Messages;
using NSE.Pedidos.API.Application.DTO;

namespace NSE.Pedidos.API.Application.Commands
{
    public class PedidoCommandHandler : CommandHandler, IRequestHandler<AdicionarPedidoCommand, ValidationResult>
    {
        public Task<ValidationResult> Handle(AdicionarPedidoCommand message, CancellationToken cancellationToken)
        {
            // Validação do comando

            // Mapear Pedido

            // Aplicar voucher, se houver

            // Validar pedido

            // Processar pagamento

            // Se pagamento tudo OK!

            // Adicionar Evento

            // Adicionar Pedido Repositório

            // Persistir dados de pedido e voucher

            throw new NotImplementedException();
        }
    }
}
