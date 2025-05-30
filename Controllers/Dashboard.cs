using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Dashboard : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
