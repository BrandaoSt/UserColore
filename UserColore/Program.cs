using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UserColore.Areas.Identity.Data;
using UserColore.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("UserColoreContextConnection");builder.Services.AddDbContext<UserColoreContext>(options =>
    options.UseSqlServer(connectionString));builder.Services.AddDefaultIdentity<UserColoreUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<UserColoreContext>();
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapRazorPages();
});

app.Run();
