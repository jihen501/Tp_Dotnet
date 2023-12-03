using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplicationTp3.Models;

namespace WebApplicationTp3.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CustomerController(ApplicationDbContext db) { 
            _db = db;
        
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            var c=_db.Customer.ToList();
            return View(c);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create

        // GET: Customers/Create
        public IActionResult Create()
        {
            ViewData["memebrshiptypesId"] = new SelectList(_db.Membershiptype, "id", "id");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,memebrshiptypesId")] Customer customers)
        {
            if (ModelState.IsValid)
            {
                _db.Add(customers);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["memebrshiptypesId"] = new SelectList(_db.Membershiptype, "id", "id", customers.MembershiptypeId);
            if (!ModelState.IsValid)
            {
                ViewBag.Errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();
            }
            return View(customers);
        }


        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
           
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer c)
        {
            try
            {
                _db.Customer.Update(c);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            Customer c =_db.Customer.Find(id);
            return View(c);
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Customer c)
        {
            try
            {
                _db.Customer.Remove(c);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
