
using Microsoft.EntityFrameworkCore;


namespace EmployeeScheduler.Models
{
    public class ScheduleContext : DbContext
    {
        public ScheduleContext(DbContextOptions<ScheduleContext> options)
            : base(options)
        { }
        public DbSet<UserLogon> userLogons { get; set; }

        public DbSet<Shifts> shifts { get; set; }

        public DbSet<Days> days { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DaysConfig());
            modelBuilder.ApplyConfiguration(new UserLogonConfig());
        }
    }
}

