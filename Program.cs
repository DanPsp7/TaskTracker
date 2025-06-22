using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using TaskTracker.BLL;
using TaskTracker.BLL.Interfaces;
using TaskTracker.BLL.Services;
using TaskTracker.Data;
using TaskTracker.Repository.Interfaces;
using TaskTracker.Repository.Logic;

var builder = WebApplication.CreateBuilder(args);




builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TaskTrackerContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("TaskTracker") ?? throw new InvalidOperationException("Connection string 'TaskTracker' not found.")));

builder.Services.AddScoped<ITeamRepository, TeamRepository>();
builder.Services.AddScoped<ITeamService, TeamService>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<IProjectService, ProjectService>();

builder.Services.AddScoped<IProjectTaskRepository, ProjectTaskRepository>();
builder.Services.AddScoped<IProjectTaskService, ProjectTaskService>();

builder.Services.AddAutoMapper(typeof(TaskTrackerProfile));

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




var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => 
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

