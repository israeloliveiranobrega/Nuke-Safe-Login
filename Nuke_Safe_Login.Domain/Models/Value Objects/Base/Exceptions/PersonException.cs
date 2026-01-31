using Nuke_Safe_Login.Models.Base.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nuke_Safe_Login.Domain.Models.Value_Objects.Base.Exceptions
{
    public class UnderageException : DomainException
    {
        public UnderageException() : base("O usuário deve ser maior de idade.") { }
    }
    public class OveragedException : DomainException
    {
        public OveragedException() : base("A idade do usuário é inválida.") { }
    }
}
