using Nuke_Safe_Login.Domain.Models.Base.Enums;
using Nuke_Safe_Login.Domain.Models.Value_Objects;
using Nuke_Safe_Login.Domain.Models.Value_Objects.Base;
using System.Globalization;

namespace Nuke_Safe_Login.Domain.Models
{
    public class User
    {
        public Person person { get; set; }
        public Adress Adress { get; set; }
        public Email Email { get; set; }
        public Phone Phone { get; set; }
        public string PasswordHash { get; set; }
        public AccountStatus Status { get; set; }

        private User()
        {
            
        }
        
    }
}
