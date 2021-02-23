using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data_Access_Layer
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Guitar> Guitars { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Electric Guitars" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Acoustic Guitars" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Bass Guitars" });

            //seed guitars

            modelBuilder.Entity<Guitar>().HasData(new Guitar
            {
                GuitarId = 1,
                Brand = "Ibanez",
                Price = 140.95M,
                DescriptionOfGuitar = "Good model for start",
                CategoryId = 1,
                ImageUrl = "Images/Guitars/ibanez 121.JPG",
                InStock = true,
                IsGuitarOfTheWeek = true,
                ImageThumbnailUrl = "Images/Guitars/ibanez 121.JPG"
            });
        }
    }
}
