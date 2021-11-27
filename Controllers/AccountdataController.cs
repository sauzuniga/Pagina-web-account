using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Apps.Models;

namespace Apps.Controllers
{
    public class AccountdataController : Controller
    {
        private readonly AccountContext _context;

        public AccountdataController(AccountContext context)
        {
            _context = context;
        }

        // GET: Accountdata
        public async Task<IActionResult> Index()
        {
            return View(await _context.Accountdata.ToListAsync());
        }

        // GET: Accountdata/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountdata = await _context.Accountdata
                .FirstOrDefaultAsync(m => m.accountID == id);
            if (accountdata == null)
            {
                return NotFound();
            }

            return View(accountdata);
        }

        // GET: Accountdata/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Accountdata/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("accountID,email,password,birthdate,owner,address")] Accountdata accountdata)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accountdata);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(accountdata);
        }

        // GET: Accountdata/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountdata = await _context.Accountdata.FindAsync(id);
            if (accountdata == null)
            {
                return NotFound();
            }
            return View(accountdata);
        }

        // POST: Accountdata/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("accountID,email,password,birthdate,owner,address")] Accountdata accountdata)
        {
            if (id != accountdata.accountID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accountdata);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountdataExists(accountdata.accountID))
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
            return View(accountdata);
        }

        // GET: Accountdata/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountdata = await _context.Accountdata
                .FirstOrDefaultAsync(m => m.accountID == id);
            if (accountdata == null)
            {
                return NotFound();
            }

            return View(accountdata);
        }

        // POST: Accountdata/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accountdata = await _context.Accountdata.FindAsync(id);
            _context.Accountdata.Remove(accountdata);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountdataExists(int id)
        {
            return _context.Accountdata.Any(e => e.accountID == id);
        }
    }
}
