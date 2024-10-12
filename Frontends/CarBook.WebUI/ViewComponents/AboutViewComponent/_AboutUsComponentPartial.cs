using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.AboutViewComponent
{
    public class _AboutUsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View(); 
        }
    }
}
