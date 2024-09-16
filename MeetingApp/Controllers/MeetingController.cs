using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            if (ModelState.IsValid)
            {
                Repository.CreateUser(model); 
                ViewBag.UserCount = Repository.Users.Where(x => x.WillAttend == true).Count();
                return View("Thanks", model);
            }
            return View(model);

            
        }
        public IActionResult List()
        {
            var users = Repository.Users;
            return View(users);
        }
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }
    }
}
