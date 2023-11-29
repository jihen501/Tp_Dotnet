using Microsoft.AspNetCore.Mvc;

namespace ASPCoreApplication2023.Controllers
{
    public class Movie1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
