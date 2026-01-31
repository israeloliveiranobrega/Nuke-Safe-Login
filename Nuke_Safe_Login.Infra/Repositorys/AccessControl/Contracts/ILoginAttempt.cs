using Nuke_Safe_Login.Domain.Models;

namespace Nuke_Safe_Login.Infra.Repositorys.AccessControl.Contracts
{
    public interface ILoginAttempt
    {
        Task<Guid> CreateAsync(LoginAttempt user);
    }
}
