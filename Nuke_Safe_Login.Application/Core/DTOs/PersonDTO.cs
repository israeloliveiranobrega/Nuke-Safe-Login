using Nuke_Safe_Login.Application.Core.AccessControl.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Nuke_Safe_Login.Application.Core.AccessControl.DTOs;
public record PersonDTO
{
    public NameDTO Name { get; set; }
    public DateOnly BirthDate { get; set; } 
    public string Cpf { get; set; }
    public string Rg { get; set; }
}