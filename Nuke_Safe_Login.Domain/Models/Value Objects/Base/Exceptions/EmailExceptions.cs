using Nuke_Safe_Login.Models.Base.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nuke_Safe_Login.Domain.Models.Value_Objects.Base.Exceptions
{
    public class InvalidEmailFormatExceptions : DomainException
    {
        public InvalidEmailFormatExceptions() : base("O formato do email é inválido.") { }
    }
}
