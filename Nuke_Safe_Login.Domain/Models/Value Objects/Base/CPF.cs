using Nuke_Safe_Login.Domain.Models.Value_Objects.Base.Exceptions;
using System.Text.RegularExpressions;

namespace Nuke_Safe_Login.Domain.Models.Value_Objects.Base;
public readonly struct CPF
{
    public ulong Numbers { get; init; }
    public ulong Validators { get; init; }  

    public ulong BruteCpf => ulong.Parse($"{Numbers}{Validators}");
    public string UnformattedCpf => $"{Numbers}{Validators}";
    public string FormattedCpf => BruteCpf.ToString(@"000\.000\.000\-00");
    public string MaskedCpf => $"{FormattedCpf.Split('.')[0]}.XXX.XXX-{FormattedCpf.Split('-')[1]}";

    public CPF(string cpf)
    {
        CheckCpfInput(cpf);
        ValidCpf(cpf);

        Numbers = ulong.Parse(cpf[..9]);
        Validators = ulong.Parse(cpf[^2..]);
    }

    private void CheckCpfInput(string cpf)
    {
        if (string.IsNullOrWhiteSpace(cpf))
            throw new ArgumentNullException("O Cpf não pode ser vazio.");

        if (!CheckIsNumbers(cpf) || !CheckLength(cpf))
            throw new InvalidCpfFormatException();

        if (CheckKnowWrongCpfs(cpf))
            throw new KnowInvalidCpfException();
    }

    private void ValidCpf(string cpf)
    {
        int[] firstValidation = ConvertCpfToIntArray(cpf[..9]);

        int firstResult = CalculeValidator(firstValidation);

        int[] secondValidation = ConvertCpfToIntArray($"{cpf[..9]}{firstResult}");

        int secondResult = CalculeValidator(secondValidation);

        string result = $"{firstResult}{secondResult}";

        if (!(result == cpf[^2..]))
            throw new InvalidCpfException();
    }

    private int[] ConvertCpfToIntArray(string cpf) => [.. cpf.Select(c => int.Parse(c.ToString()))];

    private int CalculeValidator(int[] numbers)
    {
        int sum = 0;

        int multiplier = numbers.Length + 1;

        for (int i = 0; i < numbers.Length; i++)
            sum += numbers[i] * (multiplier - i);

        var result = (sum * 10) % 11;

        if (result >= 10)
            return 0;

        return result;
    }

    private bool CheckKnowWrongCpfs(string cpf)
    {
        string regex = @"(\d)\1{10}";

        if (Regex.IsMatch(cpf, regex))
            return true;

        return false;
    }

    private bool CheckIsNumbers(string numbers) => numbers.All(char.IsAsciiDigit);
    private bool CheckLength(string numbers) => numbers.Length == 11;
}
