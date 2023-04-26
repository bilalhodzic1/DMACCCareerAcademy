namespace EmployeeScheduler.Models
{
    public class ScheduleUnit : IScheduleUnit
    {
        private ScheduleContext context { get; set; }
        public ScheduleUnit(ScheduleContext ctx) => context = ctx;

        private Repository<Days> dayData;
        public Repository<Days> Days
        {
            get
            {
                if (dayData == null)
                    dayData = new Repository<Days>(context);
                return dayData;
            }
        }
        private Repository<Shifts> shiftData;
        public Repository<Shifts> Shifts
        {
            get
            {
                if (shiftData == null)
                    shiftData = new Repository<Shifts>(context);
                return shiftData;
            }
        }
        private Repository<UserLogon> userData;
        public Repository<UserLogon> Users
        {
            get
            {
                if (userData == null)
                    userData = new Repository<UserLogon>(context);
                return userData;
            }
        }

        public void Save() => context.SaveChanges();
    }
}
