using System;
using System.Collections.Generic;
using System.Text;

namespace Nuke_Safe_Login.Domain.DTO.Request.Value_Objects.Base;
public record AdressDTO
{
    public string PostalCode { get; set; }
    public string Street { get; set; }
    public string Number { get; set; }
    public string Complement { get; set; }
    public string City { get; set; }
    public string State { get; set; }
}

