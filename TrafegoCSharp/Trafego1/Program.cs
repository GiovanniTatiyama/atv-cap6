using Microsoft.EntityFrameworkCore;
using Trafego1.Data.Contexts;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("DatabaseConnection")));

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "trafego",
    pattern: "Trafego",
    defaults: new { controller = "Trafego", action = "Index" });

app.MapControllerRoute(
    name: "create_trafego",
    pattern: "Trafego/Create",
    defaults: new { controller = "Trafego", action = "Create" });

app.MapControllerRoute(
    name: "edit_trafego",
    pattern: "Trafego/Edit/{id?}",
    defaults: new { controller = "Trafego", action = "Edit" });

app.MapControllerRoute(
    name: "delete_trafego",
    pattern: "Trafego/Delete/{id?}",
    defaults: new { controller = "Trafego", action = "Delete" });


app.MapControllerRoute(
    name: "semaforos",
    pattern: "Semaforos",
    defaults: new { controller = "Semaforos", action = "Index" });

app.MapControllerRoute(
    name: "create_semaforos",
    pattern: "Semaforos/Create",
    defaults: new { controller = "Semaforos", action = "Create" });

app.MapControllerRoute(
    name: "edit_semaforos",
    pattern: "Semaforos/Edit/{id?}",
    defaults: new { controller = "Semaforos", action = "Edit" });

app.MapControllerRoute(
    name: "delete_semaforos",
    pattern: "Semaforos/Delete/{id?}",
    defaults: new { controller = "Semaforos", action = "Delete" });


app.MapControllerRoute(
    name: "notificacoes",
    pattern: "Notificacoes",
    defaults: new { controller = "Notificacoes", action = "Index" });

app.MapControllerRoute(
    name: "create_notificacoes",
    pattern: "Notificacoes/Create",
    defaults: new { controller = "Notificacoes", action = "Create" });

app.MapControllerRoute(
    name: "edit_notificacoes",
    pattern: "Notificacoes/Edit/{id?}",
    defaults: new { controller = "Notificacoes", action = "Edit" });

app.MapControllerRoute(
    name: "delete_notificacoes",
    pattern: "Notificacoes/Delete/{id?}",
    defaults: new { controller = "Notificacoes", action = "Delete" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
