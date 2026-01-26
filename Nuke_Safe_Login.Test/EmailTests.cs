using System;
using System.Collections.Generic;
using System.Text;
using Nuke_Safe_Login.Application.Core.AccessControl.DTOs.Base;
using Nuke_Safe_Login.Application.Core.AccessControl.Helpers;

namespace Nuke_Safe_Login.Test
{
    public class EmailTests
    {
        public static TheoryData<string,string,string> EmailTestData => new()
        {
            { "admin", "nukesafe.com", "a****" },
            { "john.doe", "gmail.com", "j*******" },
            { "support_sys", "helpdesk.io", "s**********" },
            { "dev.ops+alert", "internal.net", "d************" },
            { "contact", "store-front.com.br", "c******" },
            { "user123", "legacy-system.org", "u******" },
            { "marketing.dept", "enterprise.co.uk", "m*************" },
            { "security", "gov.us", "s*******" },
            { "noreply", "automations.cloud", "n******" },
            { "ceo", "startup.vc", "c**" }
        };

        [Theory]
        [MemberData(nameof(EmailTestData))]
        public void Censure_ReturnFirstLatterAndAsteristksWithDomain_WhenInputIsCorect(string address, string domain, string expected)
        {
            var email = new EmailDTO(address, domain);
            var censuredEmail = email.Censure();

            Assert.Equal($"{expected}@{email.Domain}", censuredEmail);
        }
    }
}
