using Nuke_Safe_Login.Domain.Models.Value_Objects.Base;
using Nuke_Safe_Login.Domain.Models.Value_Objects.Base.Exceptions;
using System.ComponentModel;

namespace Nuke_Safe_Login.Test
{
    public class CpfTests
    {
        public static IEnumerable<object[]> ValidCpfNumbers => new List<object[]>
        {
            new object[] { "18217296090" },
            new object[] { "10667961062" },
            new object[] { "43907469011" },
            new object[] { "70949827045" },
            new object[] { "59215853006" },
            new object[] { "32113297060" },
            new object[] { "78669130050" },
            new object[] { "02061606075" },
            new object[] { "60821453050" },
            new object[] { "53295639094" }
        };
        public static IEnumerable<object[]> InvalidCpfNumbers => new List<object[]>
        {
            new object[] { "12345678912" },
            new object[] { "98765432198" },
            new object[] { "11122233399" },
            new object[] { "55566677700" },
            new object[] { "99988877711" },
            new object[] { "23456789012" },
            new object[] { "44455566677" },
            new object[] { "77788899900" },
            new object[] { "32165498700" },
            new object[] { "85274196300" }
        };
        public static IEnumerable<object[]> CpfsWithTypingError => new List<object[]>
        {
            new object[] { "1234567890a" },
            new object[] { "9876543210X" },
            new object[] { "abc12345678" },
            new object[] { "555666777!@" },
            new object[] { "000000000O0" }, 
            new object[] { "l2345678901" }, 
            new object[] { "12345-67890" },
            new object[] { "a1b2c3d4e5f" },
            new object[] { "cpfvalido0x" },
            new object[] { "***********" }
        };
        public static IEnumerable<object[]> CpfsOutOfLength => new List<object[]>
        {
            new object[] { "44" },                 
            new object[] { "1" },               
            new object[] { "12345" },            
            new object[] { "1234567890" },       
            new object[] { "123456789012" },      
            new object[] { "12345678901234" },   
            new object[] { "123" },               
            new object[] { "1122334455667788" },  
            new object[] { "98765432" },          
            new object[] { "12345678901234567890" } 
        };
        public static IEnumerable<object[]> KnowWrongCpfs => new List<object[]>
        {
            new object[] { "00000000000" },
            new object[] { "11111111111" },
            new object[] { "22222222222" },
            new object[] { "33333333333" },
            new object[] { "44444444444" },
            new object[] { "55555555555" },
            new object[] { "66666666666" },
            new object[] { "77777777777" },
            new object[] { "88888888888" },
            new object[] { "99999999999" }
        };

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("   ")]
        public void Constructor_ShouldThrowException_WhenCpfIsNull(string cpf)
        {
            var result = Assert.Throws<ArgumentNullException>(() => new CPF(cpf));
        }
        [Theory]
        [MemberData(nameof(CpfsWithTypingError))]
        public void Constructor_ShouldThrowException_WhenCpfIsMisspelled(string cpf)
        {
            var result = Assert.Throws<InvalidCpfFormatException>(() => new CPF(cpf));
        }

        [Theory]
        [MemberData(nameof(CpfsOutOfLength))]
        public void Constructor_ShouldThrowException_WhenTheCpfDoesNotHave11Digits(string cpf)
        {
            var result = Assert.Throws<InvalidCpfFormatException>(() => new CPF(cpf));
        }
        [Theory]
        [MemberData(nameof(KnowWrongCpfs))]
        public void Constructor_ShouldThrowException_WhenCpfIsKnownInvalid(string cpf)
        {
            var result = Assert.Throws<KnowInvalidCpfException>(() => new CPF(cpf));
        }
        [Theory]
        [MemberData(nameof(InvalidCpfNumbers))]
        public void Constructor_ShouldThrowException_WhenCpfIsMathematicallyInvalid(string cpf)
        {
            var result = Assert.Throws<InvalidCpfException>(() => new CPF(cpf));
        }

        [Theory]
        [MemberData(nameof(ValidCpfNumbers))]
        public void GetUnformattedCpf_ShouldReturnTheCompleteCpf_WhenCpfIsMathematicallyInvalid(string cpf)
        {
            var result = new CPF(cpf);

            Assert.Equal(cpf, result.GetUnformattedCpf());
        }
        [Theory]
        [MemberData(nameof(ValidCpfNumbers))]
        public void GetValidationCode_ShouldReturnTheCompleteFormatedCpf_WhenCpfIsMathematicallyInvalid(string cpf)
        {
            var result = new CPF(cpf);

            var formated = $"{cpf[0..3]}.{cpf[3..6]}.{cpf[6..9]}-{cpf[9..11]}";

            Assert.Equal(formated, result.GetFormattedCpf());
        }
        [Theory]
        [MemberData(nameof(ValidCpfNumbers))]
        public void GetValidationCode_ShouldReturnTheValidationNumbers_WhenCpfIsMathematicallyInvalid(string cpf)
        {
            var result = new CPF(cpf);

            var validators = cpf[^2..];

            Assert.Equal(validators, result.GetValidationCode());
        }
    }
}
