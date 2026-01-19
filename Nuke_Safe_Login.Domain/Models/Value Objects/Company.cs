using Nuke_Safe_Login.Domain.Models.Value_Objects.Base;

namespace Nuke_Safe_Login.Domain.Models.Value_Objects
{
    public class Company
    {
        public Name Name { get; set; }
        public CNPJ Cnpj { get; set; }
    }
}
