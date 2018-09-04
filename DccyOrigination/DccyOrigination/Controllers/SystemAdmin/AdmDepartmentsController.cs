using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DccyOrigination.EF;
using DccyOrigination.Models.SysManagement;
using Microsoft.AspNetCore.Http;

namespace DccyOrigination.Controllers.SystemAdmin
{
    public class AdmDepartmentsController : Controller
    {
        private readonly DccyDbContext _context;
       

        public AdmDepartmentsController(DccyDbContext context)
        {
            _context = context;
        }
     
      
        // GET: AdmDepartments
        public async Task<IActionResult> Index()
        {
           
            return View(await _context.AdmDepartment.ToListAsync());
        }

        // GET: AdmDepartments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admDepartment = await _context.AdmDepartment
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admDepartment == null)
            {
                return NotFound();
            }

            return View(admDepartment);
        }

        // GET: AdmDepartments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdmDepartments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DepName,Pid,Guid,PGuid,Id,CreateTime,IsDelete,Description,TimestampV")] AdmDepartment admDepartment)
        {
            if (ModelState.IsValid)
            {
                admDepartment.CreateTime = DateTime.Now;
                admDepartment.Guid = Guid.NewGuid().ToString().ToUpper();
                _context.Add(admDepartment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(admDepartment);
        }

        // GET: AdmDepartments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admDepartment = await _context.AdmDepartment.FindAsync(id);
            if (admDepartment == null)
            {
                return NotFound();
            }
            return View(admDepartment);
        }

        // POST: AdmDepartments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DepName,Pid,Guid,PGuid,Id,CreateTime,IsDelete,Description,TimestampV")] AdmDepartment admDepartment)
        {
            if (id != admDepartment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(admDepartment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdmDepartmentExists(admDepartment.Id))
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
            return View(admDepartment);
        }

        // GET: AdmDepartments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admDepartment = await _context.AdmDepartment
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admDepartment == null)
            {
                return NotFound();
            }

            return View(admDepartment);
        }

        // POST: AdmDepartments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admDepartment = await _context.AdmDepartment.FindAsync(id);
            _context.AdmDepartment.Remove(admDepartment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdmDepartmentExists(int id)
        {
            return _context.AdmDepartment.Any(e => e.Id == id);
        }
    }
}
