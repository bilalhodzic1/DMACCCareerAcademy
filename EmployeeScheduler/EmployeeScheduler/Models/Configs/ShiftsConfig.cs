using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeScheduler.Models
{
    internal class ShiftsConfig : IEntityTypeConfiguration<Shifts>
    {
        public void Configure(EntityTypeBuilder<Shifts> entity)
        {
            entity.HasOne(c => c.User)
                .WithMany(t => t.Shifts)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
