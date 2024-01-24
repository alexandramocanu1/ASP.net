using Planner.Models;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDbContext<DefaultConnection>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddControllersWithViews();

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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    //var dbContext = services.GetRequiredService<DefaultConnection>();
   // dbContext.Database.Migrate();
}

app.Run();
//se pune singur?