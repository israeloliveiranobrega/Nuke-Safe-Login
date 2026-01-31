using Nuke_Safe_Login.Domain.Models.Value_Objects.Base.Exceptions;
using System.Text.RegularExpressions;

namespace Nuke_Safe_Login.Domain.Models.Value_Objects.Base;
public readonly struct Email
{
    public string Address { get; init; }
    public string Domain { get; init; }

    public string FullEmail => $"{Address}@{Domain}";
    public string MaskedEmail
    {
        get
        {
            var asterisks = string.Empty;

            for (int i = 0; i < (Address.Length - 1); i++)
                asterisks += '*';

            return $"{Address[0]}{asterisks}@{Domain}";
        }
    }

    public Email(string address, string domain)
    {
        ValidEmail(address, domain);

        Address = address;
        Domain = domain;
    }

    private void ValidEmail(string address, string domain)
    {
        string regexPattern = @"^[\w%+-]+(\.[\w%+-]+)*@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        if (!Regex.IsMatch($"{address}@{domain}", regexPattern))
            throw new InvalidEmailFormatExceptions();
    }
}
