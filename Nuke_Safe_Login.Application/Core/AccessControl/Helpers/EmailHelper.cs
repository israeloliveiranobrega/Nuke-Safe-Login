using Nuke_Safe_Login.Application.Core.AccessControl.DTOs.Base;

namespace Nuke_Safe_Login.Application.Core.AccessControl.Helpers;

public static class EmailHelper
{
    public static string Censure(this EmailDTO email)
    {
        var asterisks = string.Empty;

        for (int i = 0; i < (email.Address.Length -1 ); i++)
            asterisks += '*';

        return $"{email.Address[0]}{asterisks}@{email.Domain}";
    }
    public static string GerateValidationToken() => Random.Shared.Next(100000, 999999).ToString();
}
