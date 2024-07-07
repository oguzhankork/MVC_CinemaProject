using MVC_CodeFirst.Repositories.Abstracts;
using MVC_CodeFirst.Repositories.Concretes;

var builder = WebApplication.CreateBuilder(args);
//MVC
builder.Services.AddControllersWithViews();

//Services
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IDirectorService,DirectorService>();


var app = builder.Build();

//staticfiles
app.UseStaticFiles();
//route
app.UseRouting();
//maproute

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "default",
      pattern: "{controller=Home}/{action=Index}/{id?}"
    );


    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();
