namespace Nuke_Safe_Login.Domain.Models.Value_Objects.Base
{
    public class Email
    {
        string Address { get; set; }
        string Domain { get; set; }

        public Email(string address, string domain)
        {
            
        }

        bool ValidEmail(string address, string domain)
        {
            return default;
        }

        public string GetFullEmail() => $"{Address}@{Domain}";
        public string GetDomain() => $"{Domain}";
        public string GetAddress() => $"{Address}";
    }
}
