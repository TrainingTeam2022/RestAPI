using TemplateRestAPI.DBContext;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

var builderForConfig = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true);

IConfiguration _configuration = builderForConfig.Build();
string connectionString = _configuration.GetConnectionString("local");


// Add services to the container.
/*builder.Services.AddDbContext<DemoDbContext>(options =>
{
    options.(connectionString));
});*/
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

app.Run();
