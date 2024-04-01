using CollegeManagementServices.Data;
using CollegeManagementServices.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

[Authorize(Roles = Roles.Role_Staff)]
public class StaffTaskController : Controller
{
    private readonly CollegeDbContext _context;

    public StaffTaskController(CollegeDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var tasks = _context.StaffTasks.ToList();
        return View(tasks);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(StaffTask task)
    {
        if (ModelState.IsValid)
        {
            _context.StaffTasks.Add(task);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(task);
    }

    public IActionResult Edit(int id)
    {
        var task = _context.StaffTasks.Find(id);
        if (task == null)
        {
            return NotFound();
        }
        return View(task);
    }

    [HttpPost]
    public IActionResult Edit(int id, StaffTask task)
    {
        if (id != task.TaskId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            _context.StaffTasks.Update(task);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(task);
    }

    public IActionResult Delete(int id)
    {
        var task = _context.StaffTasks.Find(id);
        if (task == null)
        {
            return NotFound();
        }
        return View(task);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        var task = _context.StaffTasks.Find(id);
        _context.StaffTasks.Remove(task);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}
