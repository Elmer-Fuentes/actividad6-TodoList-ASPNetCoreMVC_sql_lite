using Microsoft.EntityFrameworkCore;
using TodoListMvc.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var cs = builder.Configuration.GetConnectionString("DefaultConnection") ?? "Data Source=todolist.db";
builder.Services.AddDbContext<ApplicationDbContext>(o => o.UseSqlite(cs));
var app = builder.Build();
if (!app.Environment.IsDevelopment()) { app.UseExceptionHandler("/Home/Error"); app.UseHsts(); }
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(name:"default", pattern:"{controller=Todo}/{action=Index}/{id?}");
using (var scope = app.Services.CreateScope()) { var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>(); db.Database.EnsureCreated(); }
app.Run();
