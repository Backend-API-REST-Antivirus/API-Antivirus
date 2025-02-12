using Api_Antivirus.Data;
using Api_Antivirus.Services;
using DotNetEnv;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using Microsoft.EntityFrameworkCore;
using Api_Antivirus.Models;

Env.Load(); //Carga las variables de .env

var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Development";

var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    Args = args,
    EnvironmentName = environment
    
});

// Habilitar los Static Web Assets en todos los entornos, incluyendo "Local"
StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

if (environment == "Development")
{
    String conectionString = $"Host={Environment.GetEnvironmentVariable("HOST")};" +
        $"Port={Environment.GetEnvironmentVariable("PORT")};" +
        $"Database={Environment.GetEnvironmentVariable("DATABASE")};" +
        $"Username={Environment.GetEnvironmentVariable("USERNAME")};" +
        $"Password={Environment.GetEnvironmentVariable("PASSWORD")};" +
        $"SslMode={Environment.GetEnvironmentVariable("SSLMODE")};";

    //sobreescribir valores de appsettings.json con variables de entorno
    builder.Configuration["ConnectionStrings:DefaultConnection"] = conectionString;

}
else
{
    Console.WriteLine("Entorno Local");
}

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsProduction())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
