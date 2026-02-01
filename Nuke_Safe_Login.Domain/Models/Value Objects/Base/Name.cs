using Nuke_Safe_Login.Domain.Helpers.Extension;
using Nuke_Safe_Login.Domain.Models.Value_Objects.Base.Exceptions;
using static Nuke_Safe_Login.Domain.Helpers.Extension.StringExtensionHelper;

namespace Nuke_Safe_Login.Domain.Models.Value_Objects.Base;
public record Name
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

    public string FullName => $"{FirstName} {LastName}";

    public Name(string firstName, string lastName)
    {
        ValidateNamePart(firstName);
        ValidateNamePart(lastName);

        FirstName = firstName;
        LastName = lastName;
    }

    private void ValidateNamePart(string namePart)
    {
        if (!namePart.HasContent() || !namePart.HasMinLength(3))
            throw new InvalidNameLengthExceptions(nameof(namePart));

        if (!namePart.IsOnlyLettersOrNumbers(CheckType.OnlyLetters))
            throw new InvalidNameCharacterExceptions(nameof(namePart));
    }
}
