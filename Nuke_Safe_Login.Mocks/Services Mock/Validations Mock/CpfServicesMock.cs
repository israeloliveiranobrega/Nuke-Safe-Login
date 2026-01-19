using Nuke_Safe_Login.Domain.DTO.Response;
using Nuke_Safe_Login.Domain.Services.Validations;

namespace Nuke_Safe_Login.Mocks.Services_Mock.Validations_Mock
{
    internal class CpfServicesMock : ICpfServices
    {
        public static readonly Dictionary<string, CpfInfoResponse> CpfDatabase = new()
        {
            ["18217296090"] = new CpfInfoResponse(
            new NameResponse("Lucas", "Ferreira"),
            "Regular",
            true
        ),
            ["10667961062"] = new CpfInfoResponse(
            new NameResponse("Ana", "Costa"),
            "Regular",
            true
        ),
            ["43907469011"] = new CpfInfoResponse(
            new NameResponse("Marcos", "Oliveira"),
            "Pendente",
            true
        ),
            ["70949827045"] = new CpfInfoResponse(
            new NameResponse("Beatriz", "Santos"),
            "Regular",
            true
        ),
            ["59215853006"] = new CpfInfoResponse(
            new NameResponse("Rafael", "Souza"),
            "Suspenso",
            true
        ),
            ["32113297060"] = new CpfInfoResponse(
            new NameResponse("Fernanda", "Lima"),
            "Regular",
            true
        ),
            ["78669130050"] = new CpfInfoResponse(
            new NameResponse("Gabriel", "Pereira"),
            "Regular",
            true
        ),
            ["02061606075"] = new CpfInfoResponse(
            new NameResponse("Juliana", "Alves"),
            "Cancelado",
            true // Existe no cadastro, mas está cancelado
        ),
            ["60821453050"] = new CpfInfoResponse(
            new NameResponse("Bruno", "Rocha"),
            "Regular",
            true
        ),
            ["53295639094"] = new CpfInfoResponse(
            new NameResponse("Camila", "Martins"),
            "Nulo",
            false // Simulando um cenário onde o CPF é matematicamente válido mas não existe na base
        )
        };

        public async Task<CpfInfoResponse> ConsultCpf(string cpf)
        {
            var result = CpfDatabase.Where(c => c.Key == cpf).Select(c => c.Value).FirstOrDefault();

            return await Task.FromResult(result!);
        }
    }
}
