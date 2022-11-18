using Microsoft.EntityFrameworkCore;
using TemplateRestAPI.DBContext;
using TemplateRestAPI.DI;

var builder = WebApplication.CreateBuilder(args);

var builderForConfig = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true);

IConfiguration _configuration = builderForConfig.Build();

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
string connectionString = _configuration.GetConnectionString("local");

builder.Services.ConfigServiceDI();

// Add services to the container.
builder.Services.AddDbContext<DemoDbContext>(options =>
{
    options.UseNpgsql(connectionString);
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(x => x
       .AllowAnyOrigin()
       .AllowAnyMethod()
       .AllowAnyHeader());

app.Run();
