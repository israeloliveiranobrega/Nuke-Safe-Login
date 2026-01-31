using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nuke_Safe_Login.Domain.Models;
using Nuke_Safe_Login.Infra.MapSettings.Base;

namespace Nuke_Safe_Login.Infra.MapSettings.DomainMap.AccessControl
{
    public class UserMap : BaseMap<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.ToTable("users");

            #region Ignores

            builder.Ignore(x => x.Person);
            builder.Ignore(x => x.Address);
            builder.Ignore(x => x.Email);
            builder.Ignore(x => x.Phone);

            #endregion
            builder.Property(x => x.Password)
                .IsRequired()
                .HasColumnName("password_hash");

            //person
            builder.Property(x => x.Address);

        }
    }
}
