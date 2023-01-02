using Microsoft.AspNetCore.Mvc;

namespace clinic_our_team.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult login()
        {
            return View();
        }
    }
}
