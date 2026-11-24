using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_App.Entities;

namespace MVC_App.Context.Configurations
{
    public class TrainerConfiguration : GymUserConfiguration<Trainer> , IEntityTypeConfiguration<Trainer>
    {
        public new void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(X => X.CreatedAt)
                   .HasColumnName("HireDate")
                   .HasDefaultValueSql("GETDATE()");

            base.Configure(builder);
        }
    }
}
