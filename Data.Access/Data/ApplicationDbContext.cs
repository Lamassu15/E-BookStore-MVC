using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Web.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Web.Data.Access
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Biography", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Horror", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Romance", DisplayOrder = 6 }
                );


            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "The Shining",
                    Description = "The Shining is a horror novel by American author Stephen King. Published in 1977, it is King's third published novel and first hardback bestseller: the success of the book firmly established King as a preeminent author in the horror genre.",
                    ISBN = "978-0-385-12167-5",
                    Author = "Stephen King",
                    Price = 9.99,
                    CategoryId = 5
                },
                new Product
                {
                    Id = 2,
                    Title = "The lord of the rings",
                    Description = "The Lord....",
                    ISBN = "978-0-395-19395-7",
                    Author = "J.R.R. Tolkien",
                    Price = 19.99,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 3,
                    Title = "The Hobbit",
                    Description = "The Hobbit, or There and Back Again is a children's fantasy novel by English author J. R. R. Tolkien. It was published on 21 September 1937 to wide critical acclaim, being nominated for the Carnegie Medal and awarded a prize from the New York Herald Tribune for best juvenile fiction.",
                    ISBN = "978-0-395-19395-7",
                    Author = "J.R.R. Tolkien",
                    Price = 14.99,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 4,
                    Title = "The Stand",
                    Description = "The Stand is a post-apocalyptic dark fantasy novel written by American author Stephen King and first published in 1978 by Doubleday. The plot centers on a pandemic of a weaponized strain of influenza that kills almost the entire world population.",
                    ISBN = "978-0-385-12167-5",
                    Author = "Stephen King",
                    Price = 9.99,
                    CategoryId = 5
                },
                new Product
                {
                    Id = 5,
                    Title = "It",
                    Description = "It is a 1986 horror novel by American author Stephen King. It was his 22nd book and 18th novel written under his own name. The story follows the experiences of seven children as they are terrorized by an evil entity that exploits the fears of its victims to disguise itself while hunting its prey.",
                    ISBN = "978-0-670-81302-8",
                    Author = "Stephen King",
                    Price = 9.99,
                    CategoryId = 5
                }
                );
        }
    }
}
