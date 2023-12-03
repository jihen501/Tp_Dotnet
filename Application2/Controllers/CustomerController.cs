using Microsoft.AspNetCore.Mvc;

namespace Application2.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
