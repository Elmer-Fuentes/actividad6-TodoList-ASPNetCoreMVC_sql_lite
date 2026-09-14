using Microsoft.EntityFrameworkCore;
using TodoListMvc.Models;
namespace TodoListMvc.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
    public DbSet<TodoItem> TodoItems => Set<TodoItem>();
}
