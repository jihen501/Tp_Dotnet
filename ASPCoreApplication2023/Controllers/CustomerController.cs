using ASPCoreApplication2023.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreApplication2023.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            Movie m = new Movie() { Id = 1, Name = "titanic" };
            List<Customer> Customers = new List<Customer>()
            { new Customer(){Id=1,Name="jiji"},
              new Customer() { Id=2,Name="jihen"}
            };

            return View(Customers);
        }
    }
}
