using MediatR;

namespace Nuke_Safe_Login.Application.Core.AccessControl.Command.Login
{
    public record LoginUserCommand (string Cpf, string Password): IRequest<LoginUserResponse>;
}
