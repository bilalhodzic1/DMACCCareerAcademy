using Microsoft.AspNetCore.Mvc;
using EmployeeScheduler.Models;

namespace EmployeeScheduler.Controllers
{
    public class UserController : Controller
    {
        private Repository<UserLogon> users { get; set; }
        public UserController(ScheduleContext ctx) => users = new Repository<UserLogon>(ctx);
        public ViewResult Index()
        {
            var options = new QueryOptions<UserLogon>
            {
                OrderBy = u => u.LastName
            };
            return View(users.List(options));
        }
        [HttpGet]
        public ViewResult Add() => View();
        [HttpPost]
        public IActionResult Add(UserLogon user)
        {
            if (ModelState.IsValid)
            {
                users.Insert(user);
                users.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(user);
            }
        }
        [HttpGet]
        public ViewResult Delete(int id)
        {
            return View(users.Get(id));
        }
        [HttpPost]
        public RedirectToActionResult Delete(UserLogon user)
        {
            users.Delete(user);
            users.Save();
            return RedirectToAction("Index");
        }  
    }
}
