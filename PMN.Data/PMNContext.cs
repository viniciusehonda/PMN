using Microsoft.EntityFrameworkCore;
using PMN.Data.Mappings;
using PMN.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMN.Data
{
    public class PMNContext : DbContext
    {
        public PMNContext(DbContextOptions AOptions) : base(AOptions) { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#if DEBUG
            optionsBuilder.EnableSensitiveDataLogging();
#endif
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProjectMap());
            modelBuilder.ApplyConfiguration(new ProjectTaskMap());
        }
    }
}
