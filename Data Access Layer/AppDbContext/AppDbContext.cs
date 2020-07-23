using Data_Access_Layer.Models;
using Microsoft.EntityFrameworkCore;

namespace Data_Access_Layer
{
    public class AppDbContext : DbContext
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
                Price = 12.95M,
                DescriptionOfGuitar = "Good model for start",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                IsGuitarOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg"
            }) ;
        }
    }
}
