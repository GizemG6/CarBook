using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class AdminFeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
