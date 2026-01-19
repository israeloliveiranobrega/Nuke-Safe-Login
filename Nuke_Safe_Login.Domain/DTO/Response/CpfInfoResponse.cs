namespace Nuke_Safe_Login.Domain.DTO.Response
{
    public record CpfInfoResponse(NameResponse Name, string Status, bool Exist);
}
