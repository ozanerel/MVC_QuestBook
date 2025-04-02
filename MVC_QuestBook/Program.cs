var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();



var app = builder.Build();


app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "contact",
        pattern: "contact-us",
        defaults: new { controller = "Home", action = "Contact" });
});

app.Run();
