using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // for Swagger
builder.Services.AddSwaggerGen(); // enable Swagger generator

var app = builder.Build();

// Enable Swagger only in Development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // generate the JSON endpoint
    app.UseSwaggerUI(); // enable Swagger UI page
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
