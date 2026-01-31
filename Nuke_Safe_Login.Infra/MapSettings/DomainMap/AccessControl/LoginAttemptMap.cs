using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nuke_Safe_Login.Domain.Models;
using Nuke_Safe_Login.Domain.Models.Value_Objects;
using Nuke_Safe_Login.Domain.Models.Value_Objects.Base;
using Nuke_Safe_Login.Infra.MapSettings.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nuke_Safe_Login.Infra.MapSettings.DomainMap.AccessControl
{
    public class LoginAttemptMap : IEntityTypeConfiguration<LoginAttempt>
    {
        public void Configure(EntityTypeBuilder<LoginAttempt> builder)
        {
            throw new NotImplementedException();
        }
    }
}
