using Nuke_Safe_Login.Domain.DTO.Request.Value_Objects;
using Nuke_Safe_Login.Domain.DTO.Request.Value_Objects.Base;

namespace Nuke_Safe_Login.Domain.DTO.Request;
public record RegisterUserRequest
{
    public PersonDTO Person { get; set; }
    public AdressDTO Adress { get; set; }
    public EmailDTO Email { get; set; }
    public string Password { get; set; }
}
