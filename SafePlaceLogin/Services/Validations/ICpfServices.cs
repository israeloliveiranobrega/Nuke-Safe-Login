using Nuke_Safe_Login.DTO.Response;

namespace Nuke_Safe_Login.Services.Validations
{
    public interface ICpfServices
    {
        Task<CpfInfoResponse> ConsultCpf(string cpf);
    }
}
