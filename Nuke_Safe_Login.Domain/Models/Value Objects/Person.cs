using Nuke_Safe_Login.Domain.Models.Value_Objects.Base;

namespace Nuke_Safe_Login.Domain.Models.Value_Objects
{
    public class Person
    {
        public Name LegalName { get; set; }  
        public Name PreferredName { get; set; }
        public DateOnly BirthDate { get; set; }
        public CPF Cpf { get; set; }
        public RG Rg { get; set; }  
    }
}
