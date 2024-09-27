using Data.Data;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Service.Servicios;

var builder = WebApplication.CreateBuilder(args);

// se agrega el dbcontext
builder.Services.AddDbContext<TareaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TareaDBConecction")));

// se agregan el repositorio y los servicios 
builder.Services.AddScoped<ITareaRepositorio, TareaRepositorio>();

builder.Services.AddScoped<ITareaServicio, TareaServicio>();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

// pagina inicio
app.MapGet("/", () =>
    Results.Redirect("/Tareas/Index"));

app.Run();
