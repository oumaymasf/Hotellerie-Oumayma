using Microsoft.EntityFrameworkCore;
using Hotellerie_Oumayma.Models.HotellerieModel;

var builder = WebApplication.CreateBuilder(args);

// Ajouter DbContext
builder.Services.AddDbContext<HotellerieDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HotellerieConnection")));

// Services MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configuration pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

// Fichiers statiques
app.MapStaticAssets();

//  MODIFIÉ : Hotels à la place de Home
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Hotels}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();