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
                    Description = "The Lord of the Rings is an epic fantasy novel written by J.R.R. Tolkien. Set in the fictional world of Middle-earth, it follows the journey of a young hobbit named Frodo Baggins who is entrusted with the task of destroying the powerful and evil One Ring. Accompanied by his friends and allies, Frodo forms a diverse fellowship consisting of men, elves, dwarves, and other hobbits. Together, they must overcome numerous dangers and obstacles along the way. The story is rich with themes of friendship, courage, the corrupting nature of power, and the battle between good and evil.",
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
                },
                new Product
                {
                    Id = 6,
                    Title = "The Green Mile",
                    Description = "The Green Mile is a 1996 serial novel by American writer Stephen King. It tells the story of death row supervisor Paul Edgecombe's encounter with John Coffey, an unusual inmate who displays inexplicable healing and empathetic abilities.",
                    ISBN = "978-0-671-79378-1",
                    Author = "Stephen King",
                    Price = 9.99,
                    CategoryId = 5
                },
                new Product
                {
                    Id = 7,
                    Title = "Pride and Prejudice",
                    Description = "A romantic novel that charts the emotional development of the protagonist, Elizabeth Bennet, who learns the error of making hasty judgments and comes to appreciate the difference between the superficial and the essential.",
                    ISBN = "978-0-19-953556-9",
                    Author = "Jane Austen",
                    Price = 7.99,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 8,
                    Title = "Test2",
                    Description = "Test2",
                    ISBN = "978-0-671-79378-1",
                    Author = "Test Author",
                    Price = 15.99,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 9,
                    Title = "Moby-Dick",
                    Description = "An epic tale of the voyage of the whaling ship Pequod, commanded by Captain Ahab who is obsessed with revenge against Moby Dick, the giant white sperm whale that on a previous voyage destroyed Ahab's ship and severed his leg.",
                    ISBN = "978-0-14-243724-7",
                    Author = "Herman Melville",
                    Price = 11.99,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 10,
                    Title = "To Kill a Mockingbird",
                    Description = "A novel set in the American South during the 1930s, focusing on the Finch family and the moral growth of the children as their father, Atticus, defends a black man falsely accused of raping a white woman.",
                    ISBN = "978-0-06-112008-4",
                    Author = "Harper Lee",
                    Price = 10.99,
                    CategoryId = 2
                }
                );
        }
    }
}
