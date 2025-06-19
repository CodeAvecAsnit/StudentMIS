using Test.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Dependency Injection
builder.Services.AddScoped<CsvOperations>();
builder.Services.AddScoped<EmployeeService>();

var app = builder.Build();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();