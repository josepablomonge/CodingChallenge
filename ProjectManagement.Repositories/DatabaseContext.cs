using Microsoft.EntityFrameworkCore;
using ProjectManagement.Common.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManagement.Repositories
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<UserProject> UserProjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FirstName).IsRequired();
                entity.Property(e => e.LastName).IsRequired();
                entity.HasMany(pu => pu.UserProjects).WithOne(pu => pu.User);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Project");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.StartDate).IsRequired();
                entity.Property(e => e.EndDate).IsRequired();
                entity.Property(e => e.Credits).IsRequired();
                entity.HasMany(pu => pu.UserProjects).WithOne(p => p.Project);
            });

            modelBuilder.Entity<UserProject>(entity =>
            {
                entity.ToTable("UserProject");
                entity.HasKey(e => new { e.UserId, e.ProjectId });
                entity.Property(e => e.IsActive).IsRequired();
                entity.Property(e => e.AssignedDate).IsRequired();
                entity.HasOne(p => p.Project).WithMany(pu => pu.UserProjects).HasForeignKey(x => x.ProjectId);
                entity.HasOne(u=> u.User).WithMany(pu => pu.UserProjects).HasForeignKey(x => x.UserId);
            });
        }
    }
}
