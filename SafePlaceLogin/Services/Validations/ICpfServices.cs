using Nuke_Safe_Login.Domain.Services.Validations;

namespace Nuke_Safe_Login.Services.Validations
{
    public interface ICpfServices
    {
        Task<CpfInfoResponse> ConsultCpf(string cpf);
    }
}
