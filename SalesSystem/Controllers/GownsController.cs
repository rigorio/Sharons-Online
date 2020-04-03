using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SalesSystem.Data;
using SalesSystem.Enumerations;
using SalesSystem.Models;
using SalesSystem.Views.Gowns;

namespace SalesSystem.Controllers
{
    public class GownsController : Controller
    {
        private readonly SalesSystemContext _context;

        public GownsController(SalesSystemContext context)
        {
            _context = context;
        }

        // GET: Gowns
        public async Task<IActionResult> Index(string query, string status)
        {
            var gowns = from g in _context.Gowns
                        select g;
            if (!String.IsNullOrEmpty(query))
            {
                gowns = gowns.Where(g => g.orNumber.Contains(query) || g.name.Contains(query));
            }

            if (!String.IsNullOrEmpty(status))
            {
                gowns = gowns.Where(g => g.status.Equals(status));
            }
            IndexFilterModel model = new IndexFilterModel();
            var dog = await gowns.ToListAsync();
            model.gowns = dog;
            model.statusOptions = new SelectList(Enum.GetNames(typeof(Status)).ToList());
            return View(model);
        }

        // GET: Gowns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gown = await _context.Gowns
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gown == null)
            {
                return NotFound();
            }

            return View(gown);
        }

        // GET: Gowns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gowns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,name,description,price,status,dateRented,dueDate,dateReturned,pickupDate,contact,orNumber,address,partialPayment,balance,securityDeposit")] Gown gown)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gown);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gown);
        }

        // GET: Gowns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gown = await _context.Gowns.FindAsync(id);
            if (gown == null)
            {
                return NotFound();
            }
            return View(gown);
        }

        // POST: Gowns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,name,description,price,status,dateRented,dueDate,dateReturned,pickupDate,contact,orNumber,address,partialPayment,balance,securityDeposit")] Gown gown)
        {
            if (id != gown.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gown);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GownExists(gown.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(gown);
        }

        // GET: Gowns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gown = await _context.Gowns
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gown == null)
            {
                return NotFound();
            }

            return View(gown);
        }

        // POST: Gowns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gown = await _context.Gowns.FindAsync(id);
            _context.Gowns.Remove(gown);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GownExists(int id)
        {
            return _context.Gowns.Any(e => e.Id == id);
        }
    }
}
