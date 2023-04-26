using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeScheduler.Models
{
    internal class DaysConfig : IEntityTypeConfiguration<Days>
    {
        public void Configure(EntityTypeBuilder<Days> entity)
        {
            entity.HasData(
               new Days { DaysId = 1, Name = "Monday" },
               new Days { DaysId = 2, Name = "Tuesday" },
               new Days { DaysId = 3, Name = "Wednesday" },
               new Days { DaysId = 4, Name = "Thursday" },
               new Days { DaysId = 5, Name = "Friday" },
               new Days { DaysId = 6, Name = "Saturday" },
               new Days { DaysId = 7, Name = "Sunday" }
            );
        }
    }
}
