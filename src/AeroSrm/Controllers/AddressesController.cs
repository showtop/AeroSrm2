using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using AeroSrm.Models;

namespace AeroSrm.Controllers
{
    public class AddressesController : Controller
    {
        private ApplicationDbContext _context;

        public AddressesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Addresses
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Address.Include(a => a.Supplier);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Addresses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Address address = await _context.Address.SingleAsync(m => m.AddressID == id);
            if (address == null)
            {
                return HttpNotFound();
            }

            return View(address);
        }

        // GET: Addresses/Create
        public IActionResult Create(int id)
        {
            ViewBag.SupplierName = _context.Supplier.Single(m => m.SupplierID == id).SupplierName;
            return View();
        }

        // POST: Addresses/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AddressType, AddressLine1, AddressLine2, AddressLine3, Town, City, Region, Country, PostalCode, ModifiedDate, SupplierID")]Address address)
        {
            if (ModelState.IsValid)
            {
                _context.Address.Add(address);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            
            return View(address);
        }

        // GET: Addresses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Address address = await _context.Address.SingleAsync(m => m.AddressID == id);
            if (address == null)
            {
                return HttpNotFound();
            }
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "Id", "Supplier", address.SupplierID);
            return View(address);
        }

        // POST: Addresses/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Address address)
        {
            if (ModelState.IsValid)
            {
                _context.Update(address);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "Id", "Supplier", address.SupplierID);
            return View(address);
        }

        // GET: Addresses/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Address address = await _context.Address.SingleAsync(m => m.AddressID == id);
            if (address == null)
            {
                return HttpNotFound();
            }

            return View(address);
        }

        // POST: Addresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Address address = await _context.Address.SingleAsync(m => m.AddressID == id);
            _context.Address.Remove(address);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
