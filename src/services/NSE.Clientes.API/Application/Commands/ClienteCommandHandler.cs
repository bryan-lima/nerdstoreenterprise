using FluentValidation.Results;
using MediatR;
using NSE.Clientes.API.Models;
using NSE.Core.Messages;

namespace NSE.Clientes.API.Application.Commands
{
    public class ClienteCommandHandler : CommandHandler, IRequestHandler<RegistrarClienteCommand, ValidationResult>
    {
        public async Task<ValidationResult> Handle(RegistrarClienteCommand message, CancellationToken cancellationToken)
        {
            if (!message.EhValido())
                return message.ValidationResult;

            var cliente = new Cliente(message.Id, message.Nome, message.Email, message.Cpf);

            // Validações de negócio

            // Persistir no banco de dados
            // Exemplo:
            if (true) // Já existe cliente com CPF informado
            {
                AdicionarErro("Este CPF já está em uso");
                return ValidationResult;
            }

            return message.ValidationResult;
        }
    }
}
