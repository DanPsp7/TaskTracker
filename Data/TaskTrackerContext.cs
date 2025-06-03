using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskTracker.Models;


namespace TaskTracker.Data
{
    public class TaskTrackerContext : DbContext
    {
        public TaskTrackerContext(DbContextOptions<TaskTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; } = null!;
        public DbSet<TaskTracker.Models.User> Users { get; set; } = null!;
        public DbSet<TaskTracker.Models.Team> Teams { get; set; } = null!;
        
        public DbSet<TaskTracker.Models.ProjectTask> ProjectTasks { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
            modelBuilder.Entity<ProjectTask>()
                .HasOne(u => u.User)
                .WithOne(t => t.ProjectTasks)
                .HasForeignKey<ProjectTask>(u => u.UserId)
                .IsRequired(false);


        }
    }
}