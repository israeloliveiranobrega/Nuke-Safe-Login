namespace Nuke_Safe_Login.Domain.Services.Validations
{
    public interface ICpfServices
    {
        Task<CpfInfoResponse> ConsultCpf(string cpf);
    }
}
