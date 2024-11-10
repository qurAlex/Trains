using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Trains.Server.Data;
using Trains.Server.Data.SeedData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddDbContext<TrainsDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("TrainsConnectionString")
    )
);

builder.Services.AddScoped<TrainsDbContext>();

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
    options.JsonSerializerOptions.WriteIndented = true;
});

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();