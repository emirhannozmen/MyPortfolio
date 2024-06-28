using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
