using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Query.Internal;
using MVC_App.Entities;

namespace MVC_App.Context.Configurations
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure (EntityTypeBuilder<Session> builder)
        {
            builder.Property(X => X.CreatedAt)
                   .HasDefaultValueSql("GETDATE()");

            builder.HasOne(X => X.Trainer)
                   .WithMany(X => X.Sessions)
                   .HasForeignKey(X => X.TrainerId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable(T =>
            {
                T.HasCheckConstraint("SessionCapacityCheck", "Capacity Between 1 AND 25");
                T.HasCheckConstraint("SessionEndDateAfterStartDate", "EndDate > StartDate");
            });
        }
    }
}
