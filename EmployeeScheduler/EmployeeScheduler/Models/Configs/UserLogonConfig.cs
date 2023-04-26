using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeScheduler.Models
{
    internal class UserLogonConfig : IEntityTypeConfiguration<UserLogon>
    {
        public void Configure(EntityTypeBuilder<UserLogon> entity)
        {
            entity.HasData(
                new UserLogon { UserLogonId = 1, FirstName = "Bilal" , LastName = "Hodzic"},
                new UserLogon { UserLogonId = 2, FirstName = "Noah", LastName = "Arterburn" },
                new UserLogon { UserLogonId = 3, FirstName = "Gage", LastName = "Payton" }
                );
        }
    }
}
