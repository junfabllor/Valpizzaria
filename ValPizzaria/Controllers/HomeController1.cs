using Microsoft.AspNetCore.Mvc;

namespace ValPizzaria.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
