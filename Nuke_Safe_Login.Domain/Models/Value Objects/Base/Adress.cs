

namespace Nuke_Safe_Login.Domain.Models.Value_Objects.Base
{
    public class Adress
    {
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Adress()
        {
            
        }
    }
}
