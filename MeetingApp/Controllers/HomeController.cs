using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            //var selamlama = saat > 12 ? "İyi Günler" : "Günaydın";
            ViewBag.Selamlama = saat > 12 ? "İyi Günler" : "Günaydın";
            int UserCount = Repository.Users.Where(x => x.WillAttend == true).Count();
            ViewBag.Username = "Emre Can TERKAN";

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "JUPİTER / BİLGİN E SPORT GAME CENTER",
                Date = new DateTime(2024, 01, 03, 20, 0, 0),
                NumberOfPeople = UserCount
            };
            return View(meetingInfo);
        }
    }
}
