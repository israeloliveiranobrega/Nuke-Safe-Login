using Nuke_Safe_Login.Domain.Helpers.Extension;
using Nuke_Safe_Login.Domain.Models.Value_Objects.Base.Exceptions;
using System.Net;
using System.Text.RegularExpressions;
using static Nuke_Safe_Login.Domain.Helpers.Extension.StringExtensionHelper;

namespace Nuke_Safe_Login.Domain.Models.Value_Objects.Base
{
    public record Phone
    {
        public string CountryCode { get; init; }
        public string Number { get; init; }
        public string FullPhone => $"{CountryCode} {Number}";
        public string FormattedNumber => $"({CountryCode}){Number[0..5]}-{Number[5..9]}";

        public Phone(string countryCode, string number)
        { 
            ValidCountryCode(countryCode);
            ValidNumber(number);

            CountryCode = countryCode;
            Number = number;
        }

        private void ValidCountryCode(string countryCode)
        {
            if(!countryCode.HasContent())
                throw new ArgumentNullException(nameof(countryCode));

            if (!countryCode.IsOnlyLettersOrNumbers(CheckType.OnlyNumbers))
                throw new InvalidPhoneCountryCodeFormatExceptions();

            if(!countryCode.HasLength(2))
                throw new InvalidPhoneCountryCodeLengthExceptions();
        }
        private void ValidNumber(string number)
        {
            if (!number.HasContent())
                throw new ArgumentNullException(nameof(number));

            if (!number.IsOnlyLettersOrNumbers(CheckType.OnlyNumbers))
                throw new InvalidPhoneCountryCodeFormatExceptions();

            if (!number.HasLength(9))
                throw new InvalidPhoneCountryCodeLengthExceptions();
        }
    }
}
