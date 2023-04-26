using Microsoft.AspNetCore.Mvc;
using EmployeeScheduler.Models;


namespace EmployeeScheduler.Controllers
{
    public class HomeController : Controller
    {
        private ScheduleUnit data { get; set; }
        public HomeController(ScheduleContext ctx) => data = new ScheduleUnit(ctx);
        public ViewResult Index(int id)
        {
            var dayOptions = new QueryOptions<Days>
            {
                OrderBy = d => d.DaysId
            };
            var shiftOption = new QueryOptions<Shifts>
            {
                Includes = "User , Days"
            };
            if  (id == 0)
            {
                shiftOption.OrderBy = s => s.DaysId;
                shiftOption.ThenOrderBy = s => s.StartingHour;
            }
            else
            {
                shiftOption.Where = s => s.DaysId == id;
                shiftOption.OrderBy = s => s.StartingHour;
            }
            ViewBag.Days = data.Days.List(dayOptions);
            return View(data.Shifts.List(shiftOption));
        }
    }
}
