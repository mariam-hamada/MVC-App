using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_App.Entities;

namespace MVC_App.Context.Configurations
{
    public class MembershipConfiguration : IEntityTypeConfiguration<Membership>
    {
        public void Configure(EntityTypeBuilder<Membership> builder)
        {
            builder.HasKey(E => E.Id);

            builder.Property(X => X.CreatedAt)
                   .HasDefaultValueSql("GETDATE()");
        }
    }
}
