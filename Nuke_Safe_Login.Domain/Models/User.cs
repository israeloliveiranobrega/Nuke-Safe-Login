using Nuke_Safe_Login.Domain.Models.Base;
using Nuke_Safe_Login.Domain.Models.Base.Enums;
using Nuke_Safe_Login.Domain.Models.Value_Objects;
using Nuke_Safe_Login.Domain.Models.Value_Objects.Base;

namespace Nuke_Safe_Login.Domain.Models
{
    public record User : BaseMetaData
    {
        public Person Person { get; init; }
        public Address Address { get; init; }
        public Email Email { get; init; }
        public Phone? Phone { get; init; }
        public Password Password { get; init; }
        public AccountStatus Status { get; init; }

        public User(Person person, Address address, Email email, Password password, 
            Phone? phone, AccountStatus status = AccountStatus.Pending)
        {
            Person = person;
            Address = address;
            Email = email;
            Phone = phone;
            Password = password;
            Status = status;
        }

        #region Person geters

        public string FirstName => Person.FirstName;
        public string LastName => Person.LastName;
        public string FullName => Person.FullName;

        public DateOnly BirthDate => Person.BirthDate;

        public ulong Numbers => Person.Cpf.Numbers;
        public ulong Validators => Person.Cpf.Validators;
        public ulong BruteCpf => Person.Cpf.BruteCpf;
        public string UnformattedCpf => $"{Numbers}{Validators}";
        public string FormattedCpf => BruteCpf.ToString(@"000\.000\.000\-00");
        public string MaskedCpf => $"{FormattedCpf.Split('.')[0]}.XXX.XXX-{FormattedCpf.Split('-')[1]}";

        #endregion

        #region Address geters

        public string AddressZipCode => Address.ZipCode;
        public string AddressRegion => Address.Region;
        public string AddressState => Address.State;
        public string AddressCity => Address.City;
        public string AddressNeighborhood => Address.Neighborhood;
        public string AddressStreet => Address.Street;
        public string AddressNumber => Address.Number;
        public string? AddressComplement => Address.Complement;
        public string AddressFullAddress => Address.FullAddress;

        #endregion

        #region Email geters

        public string EmailAddress => Email.Address;
        public string EmailDomain => Email.Domain;
        public string FullEmail => Email.FullEmail;
        public string MaskedEmail => Email.MaskedEmail;

        #endregion

        #region Phone geters

        public string? PhoneCountryCode => Phone?.CountryCode;
        public string? PhoneNumber => Phone?.Number;
        public string? FullPhone => Phone?.FullPhone;
        public string? FormattedPhone => Phone?.FormattedNumber;

        #endregion
    }
}
