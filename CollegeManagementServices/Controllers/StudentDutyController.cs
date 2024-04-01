using CollegeManagementServices.Data;
using CollegeManagementServices.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementServices.Controllers
{

    [Authorize(Roles = Roles.Role_Student)]
    public class StudentDutyController : Controller
    {
        private readonly CollegeDbContext _context;

        public StudentDutyController(CollegeDbContext context)
        {
            _context = context;
        }

        // GET: Student
        public async Task<IActionResult> Index()
        {
            var duties = await _context.StudentDuties.ToListAsync();
            return View(duties);
        }

        // GET: Student/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentDuty = await _context.StudentDuties
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentDuty == null)
            {
                return NotFound();
            }

            return View(studentDuty);
        }

        // GET: Student/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Code,Description,Status")] StudentDuty studentDuty)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentDuty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentDuty);
        }

        // GET: Student/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentDuty = await _context.StudentDuties.FindAsync(id);
            if (studentDuty == null)
            {
                return NotFound();
            }
            return View(studentDuty);
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Code,Description,Status")] StudentDuty studentDuty)
        {
            if (id != studentDuty.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentDuty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentDutyExists(studentDuty.Id))
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
            return View(studentDuty);
        }

        // GET: Student/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentDuty = await _context.StudentDuties
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentDuty == null)
            {
                return NotFound();
            }

            return View(studentDuty);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentDuty = await _context.StudentDuties.FindAsync(id);
            _context.StudentDuties.Remove(studentDuty);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentDutyExists(int id)
        {
            return _context.StudentDuties.Any(e => e.Id == id);
        }
    }
}
