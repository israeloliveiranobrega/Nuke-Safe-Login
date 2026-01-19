using Nuke_Safe_Login.Domain.DTO.Request.Value_Objects.Base;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Nuke_Safe_Login.Domain.DTO.Request.Value_Objects;
public record PersonDTO
{
    public NameDTO LegalName { get; set; }
    public NameDTO PreferredName { get; set; }
    public DateOnly BirthDate { get; set; } 
    public string Cpf { get; set; }
    public string Rg { get; set; }
}