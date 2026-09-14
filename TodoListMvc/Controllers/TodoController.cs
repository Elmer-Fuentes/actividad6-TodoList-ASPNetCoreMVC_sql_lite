using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoListMvc.Data;
using TodoListMvc.Models;
namespace TodoListMvc.Controllers;
public class TodoController : Controller
{
    private readonly ApplicationDbContext _context;
    public TodoController(ApplicationDbContext context)=>_context=context;
    public async Task<IActionResult> Index(string? search, TodoStatus? status){ var q=_context.TodoItems.AsNoTracking().AsQueryable(); if(!string.IsNullOrWhiteSpace(search)){ var t=search.Trim(); q=q.Where(x=>x.Title.Contains(t)||(x.Description!=null&&x.Description.Contains(t))); } if(status.HasValue) q=q.Where(x=>x.Status==status.Value); var items=await q.OrderByDescending(x=>x.CreatedAt).ToListAsync(); return View(new TodoListViewModel{Items=items,Search=search,Status=status}); }
    [HttpGet] public IActionResult Create()=>View(new TodoItem());
    [HttpPost][ValidateAntiForgeryToken] public async Task<IActionResult> Create(TodoItem item){ if(!ModelState.IsValid)return View(item); item.CreatedAt=DateTime.UtcNow; _context.Add(item); await _context.SaveChangesAsync(); TempData["Success"]="Tarea creada correctamente."; return RedirectToAction(nameof(Index)); }
    [HttpGet] public async Task<IActionResult> Edit(int id){ var item=await _context.TodoItems.FindAsync(id); return item is null?NotFound():View(item); }
    [HttpPost][ValidateAntiForgeryToken] public async Task<IActionResult> Edit(int id, TodoItem item){ if(id!=item.Id)return BadRequest(); if(!ModelState.IsValid)return View(item); var e=await _context.TodoItems.FindAsync(id); if(e is null)return NotFound(); e.Title=item.Title; e.Description=item.Description; e.Status=item.Status; await _context.SaveChangesAsync(); TempData["Success"]="Tarea actualizada correctamente."; return RedirectToAction(nameof(Index)); }
    [HttpGet] public async Task<IActionResult> Delete(int id){ var item=await _context.TodoItems.FirstOrDefaultAsync(x=>x.Id==id); return item is null?NotFound():View(item); }
    [HttpPost,ActionName("Delete")][ValidateAntiForgeryToken] public async Task<IActionResult> DeleteConfirmed(int id){ var item=await _context.TodoItems.FindAsync(id); if(item is null)return NotFound(); _context.Remove(item); await _context.SaveChangesAsync(); TempData["Success"]="Tarea eliminada correctamente."; return RedirectToAction(nameof(Index)); }
}
