using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SolmBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolmBlog.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Article> Article { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "4da1e94d-1b1e-4f3c-bf46-d2529f3d0ec3",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "8ed7c16a-5c20-4d3c-8203-13e9eddbae34",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "mygmail@gmail.com",
                NormalizedEmail = "MYGMAIL@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
                
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "4da1e94d-1b1e-4f3c-bf46-d2529f3d0ec3",
                UserId = "8ed7c16a-5c20-4d3c-8203-13e9eddbae34"
            });

            builder.Entity<Article>().HasData(new Article
            {
                Id = new Guid("06b87d12-35fc-4b09-bfe8-30f9af2826a2"),
                CodeWord = "PageIndex",
                Title = "Main"
            });

            builder.Entity<Article>().HasData(new Article
            {
                Id = new Guid("d72ad5d8-001c-4f70-9d9e-bdb01173d02f"),
                CodeWord = "PageVideos",
                Title = "Videos"
            });

            builder.Entity<Article>().HasData(new Article
            {
                Id = new Guid("65385c00-5510-4f84-a493-763dbb049d82"),
                CodeWord = "PageGames",
                Title = "Games"
            });
        }
    }
}
