namespace EmployeeScheduler.Models
{
    public interface IScheduleUnit
    {
        public Repository<Days> Days { get; }
        public Repository<Shifts> Shifts { get; }
        public Repository<UserLogon> Users { get; }

        public void Save();
    }
}
