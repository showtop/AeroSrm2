using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using AeroSrm.Models;

namespace AeroSrm.Controllers
{
    public class SuppliersController : Controller
    {
        private ApplicationDbContext _context;

        public SuppliersController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Suppliers
        public IActionResult Index()
        {
            return View(_context.Supplier.ToList());
        }

        // GET: Suppliers/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Supplier supplier = _context.Supplier.Single(m => m.SupplierID == id);
            if (supplier == null)
            {
                return HttpNotFound();
            }

            return View(supplier);
        }

        // GET: Suppliers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Suppliers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                _context.Supplier.Add(supplier);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(supplier);
        }

        // GET: Suppliers/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Supplier supplier = _context.Supplier.Single(m => m.SupplierID == id);
            if (supplier == null)
            {
                return HttpNotFound();
            }
            return View(supplier);
        }

        // POST: Suppliers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                _context.Update(supplier);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(supplier);
        }

        // GET: Suppliers/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Supplier supplier = _context.Supplier.Single(m => m.SupplierID == id);
            if (supplier == null)
            {
                return HttpNotFound();
            }

            return View(supplier);
        }

        // POST: Suppliers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Supplier supplier = _context.Supplier.Single(m => m.SupplierID == id);
            _context.Supplier.Remove(supplier);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
