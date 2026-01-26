namespace Nuke_Safe_Login.Application.Core.AccessControl.Command.Register
{
    public record RegisterUserResponse(Guid UserId, string Name, string EmailSecret);
}
