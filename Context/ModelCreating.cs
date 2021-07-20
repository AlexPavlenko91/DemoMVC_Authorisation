using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Context
{
    public partial class AppDbContext : IdentityDbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Group>()
                .HasOne(g => g.Faculty)
                .WithMany(f => f.Groups)
                .HasForeignKey(g => g.FacultyId);

            builder.Entity<Student>()
                .HasOne(s => s.Group)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.GroupId);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Administrators",
                NormalizedName = "ADMINISTRATORS",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            },
            new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Moderators",
                NormalizedName = "MODERATORS",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            });
            base.OnModelCreating(builder);
        }
    }
}
