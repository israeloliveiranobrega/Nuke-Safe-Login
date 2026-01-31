using Nuke_Safe_Login.Domain.Models.Value_Objects.Base;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Nuke_Safe_Login.Domain.Helpers.Extension
{
    public static class StringExtensionHelper
    {
        public enum CheckType
        {
            OnlyLetters,
            OnlyNumbers,
            LettersOrNumbers
        }
        public static bool IsOnlyLettersOrNumbers(this string str, CheckType check)
        {
            switch (check)
            {
                case CheckType.OnlyLetters:
                    return str.All(char.IsLetter);
                    break;
                case CheckType.OnlyNumbers:
                    return str.All(char.IsDigit);
                    break;
                case CheckType.LettersOrNumbers:
                    return str.All(char.IsLetterOrDigit);
                    break;
            }
            return false;
        }

        public static bool HasContent(this string str)
        {
            if(string.IsNullOrEmpty(str))
                return false;
            
            return true;
        }

        public static bool HasLength(this string str, int length)
        {
            if(str.Length != length)
                return false;

            return true;
        }
        public static bool HasMinLength(this string str, int minLength)
        {
            if(str.Length < minLength)
                return false;

            return true;
        }
        public static bool InLengthRange(this string str, int min, int max)
        {
            if(str.Length < min || str.Length > max)
                return false;

            return true;
        }

        public static CPF ToCpf(this string str)
        {
            CPF result = new CPF(str);

            return result;
        }

    }
}
