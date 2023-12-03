using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplicationTp3.Models;

namespace WebApplicationTp3.Controllers
{
    public class MembershiptypeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MembershiptypeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
       /*public IActionResult Create()
        {
            var members = _db.Membershiptypes.ToList();
            ViewBag.member = members.Select(members => new SelectListItem()
            {
                Text = members.Name,
                Value = members.Id.ToString()
            });
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer c)
        {
            if (!ModelState.IsValid)
            {
                var members = _db.Membershiptypes.ToList();
                ViewBag.member = members.Select(members => new SelectListItem()
                {
                    Text = members.Name,
                    Value = members.Id.ToString()
                });
                return View();
            }
            c.CustomerId = new Guid();
            _db.customers.Add(c);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }*/
    }
}
