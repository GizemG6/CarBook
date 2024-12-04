using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    public class AdminAboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
