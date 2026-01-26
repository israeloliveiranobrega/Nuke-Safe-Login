using MediatR;
using Nuke_Safe_Login.Application.Core.AccessControl.DTOs;
using Nuke_Safe_Login.Application.Core.AccessControl.DTOs.Base;
using Nuke_Safe_Login.Application.Core.DTOs.Base;
using System.ComponentModel.DataAnnotations;

namespace Nuke_Safe_Login.Application.Core.AccessControl.Command.Register
{
    public record RegisterUserCommand(PersonDTO Person, AdressDTO Adress,PhoneDTO Phone, EmailDTO Email, string Password) : IRequest<RegisterUserResponse>;
}
