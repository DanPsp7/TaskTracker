using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using TaskTracker.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


var app = builder.Build();



builder.Services.AddDbContext<TaskTrackerContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("TaskTracker") ?? throw new InvalidOperationException("Connection string 'TaskTracker' not found.")));

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "My API",
        Version = "v1",
        Description = "API для управления данными",
        Contact = new OpenApiContact { Name = "Dev", Email = "dev@example.com" }
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => 
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });
}

app.UseHttpsRedirection();



app.Run();

