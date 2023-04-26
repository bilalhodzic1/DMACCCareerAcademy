using Microsoft.AspNetCore.Mvc;
using EmployeeScheduler.Models;

namespace EmployeeScheduler.Controllers
{
    public class ScheduleController : Controller
    {
        private ScheduleUnit data { get; set; }
        public ScheduleController(ScheduleContext ctx) => data = new ScheduleUnit(ctx);
        public RedirectToActionResult Index() => RedirectToAction("Index", "Home");
        [HttpGet]
        public ViewResult Add()
        {
            this.LoadViewBag("Add");
            return View();
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            this.LoadViewBag("Edit");
            var c = this.GetShifts(id);
            return View("Add", c);
        }

        [HttpPost]
        public IActionResult Add(Shifts c)
        {
            if (ModelState.IsValid)
            {
                if (c.ShiftsID == 0)
                    data.Shifts.Insert(c);
                else
                    data.Shifts.Update(c);
                data.Shifts.Save();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                string operation = (c.ShiftsID == 0) ? "Add" : "Edit";
                this.LoadViewBag(operation);
                return View();
            }
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var c = this.GetShifts(id);
            return View(c);
        }

        [HttpPost]
        public RedirectToActionResult Delete(Shifts c)
        {
            data.Shifts.Delete(c);
            data.Shifts.Save();
            return RedirectToAction("Index", "Home");
        }
        private Shifts GetShifts(int id)
        {
            var shiftOptions = new QueryOptions<Shifts>
            {
                Includes = "User, Days",
                Where = c => c.ShiftsID == id
            };
            return data.Shifts.Get(shiftOptions);
        }
        private void LoadViewBag(string operation)
        {
            ViewBag.Days = data.Days.List(new QueryOptions<Days>
            {
                OrderBy = d => d.DaysId
            });
            ViewBag.Users = data.Users.List(new QueryOptions<UserLogon>
            {
                OrderBy = t => t.LastName
            });
            ViewBag.Operation = operation;
        }
    }
}
