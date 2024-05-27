using Microsoft.EntityFrameworkCore;
using Shopping.API.Entities;

namespace Shopping.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Shopping;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Glossier - Beauty Kit",
                Description = "A kit provided by Glossier, containing skin care, hair care and makeup products",
                ImageURL = "/Images/Beauty/image1.jpg",
                Price = 100,
                Qty = 100,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Curology - Skin Care Kit",
                Description = "A kit provided by Curology, containing skin care products",
                ImageURL = "/Images/Beauty/image2.jpg",
                Price = 50,
                Qty = 45,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Cocooil - Organic Coconut Oil",
                Description = "A kit provided by Curology, containing skin care products",
                ImageURL = "/Images/Beauty/image3.jpg",
                Price = 20,
                Qty = 30,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Schwarzkopf - Hair Care and Skin Care Kit",
                Description = "A kit provided by Schwarzkopf, containing skin care and hair care products",
                ImageURL = "/Images/Beauty/image4.jpg",
                Price = 50,
                Qty = 60,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Skin Care Kit",
                Description = "Skin Care Kit, containing skin care and hair care products",
                ImageURL = "/Images/Beauty/image5.jpg",
                Price = 30,
                Qty = 85,
                CategoryId = 1

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Meskara",
                Description = "Eye meskara, containing skin care and hair care products",
                ImageURL = "/Images/Beauty/image6.jpg",
                Price = 30,
                Qty = 75,
                CategoryId = 1

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Skin Care Kit",
                Description = "Skin Care Kit, containing skin care and hair care products",
                ImageURL = "/Images/Beauty/image7.jpg",
                Price = 30,
                Qty = 85,
                CategoryId = 1

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "lip gloss",
                Description = "Skin Care Kit, containing skin care and hair care products",
                ImageURL = "/Images/Beauty/image8.jpg",
                Price = 30,
                Qty = 85,
                CategoryId = 1

            });
            //Electronics Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Air Pods",
                Description = "Air Pods - in-ear wireless headphones",
                ImageURL = "/Images/Electronics/image1.jpg",
                Price = 100,
                Qty = 120,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "On-ear Golden Headphones",
                Description = "On-ear Golden Headphones - these headphones are not wireless",
                ImageURL = "/Images/Electronics/image2.jpg",
                Price = 40,
                Qty = 200,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "On-ear Black Headphones",
                Description = "On-ear Black Headphones - these headphones are not wireless",
                ImageURL = "/Images/Electronics/image3.jpg",
                Price = 40,
                Qty = 300,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Sennheiser Digital Camera with Tripod",
                Description = "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod",
                ImageURL = "/Images/Electronics/image4.jpg",
                Price = 600,
                Qty = 20,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Canon Digital Camera",
                Description = "Canon Digital Camera - High quality digital camera provided by Canon",
                ImageURL = "/Images/Electronics/image5.jpg",
                Price = 500,
                Qty = 15,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Nintendo Gameboy",
                Description = "Gameboy - Provided by Nintendo",
                ImageURL = "/Images/Electronics/image6.jpg",
                Price = 100,
                Qty = 60,
                CategoryId = 3
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Nintendo Gameboy",
                Description = "Gameboy - Provided by Nintendo",
                ImageURL = "/Images/Electronics/image7.jpg",
                Price = 160,
                Qty = 60,
                CategoryId = 3
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Nintendo Gameboy",
                Description = "Gameboy - Provided by Nintendo",
                ImageURL = "/Images/Electronics/image8.jpg",
                Price = 500,
                Qty = 60,
                CategoryId = 3
            });
            //Furniture Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "Black Leather Office Chair",
                Description = "Very comfortable black leather office chair",
                ImageURL = "/Images/Furniture/image1.jpg",
                Price = 50,
                Qty = 212,
                CategoryId = 2
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "Pink Leather Office Chair",
                Description = "Very comfortable pink leather office chair",
                ImageURL = "/Images/Furniture/image2.jpg",
                Price = 50,
                Qty = 112,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "Lounge Chair",
                Description = "Very comfortable lounge chair",
                ImageURL = "/Images/Furniture/image3.jpg",
                Price = 70,
                Qty = 90,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "Silver Lounge Chair",
                Description = "Very comfortable Silver lounge chair",
                ImageURL = "/Images/Furniture/image4.jpg",
                Price = 120,
                Qty = 95,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 21,
                Name = "Porcelain Table Lamp",
                Description = "White and blue Porcelain Table Lamp",
                ImageURL = "/Images/Furniture/image5.jpg",
                Price = 15,
                Qty = 100,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 22,
                Name = "Office Table Lamp",
                Description = "Office Table Lamp",
                ImageURL = "/Images/Furniture/image6.jpg",
                Price = 20,
                Qty = 73,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 23,
                Name = "Labtop",
                Description = "Office Table Lamp",
                ImageURL = "/Images/Furniture/image7.jpg",
                Price = 120,
                Qty = 73,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 24,
                Name = "Airpods",
                Description = "Office Table Lamp",
                ImageURL = "/Images/Furniture/image8.jpg",
                Price = 2000,
                Qty = 13,
                CategoryId = 2
            });
            //Shoes Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 25,
                Name = "Puma Sneakers",
                Description = "Comfortable Puma Sneakers in most sizes",
                ImageURL = "/Images/Shoes/image1.jpg",
                Price = 100,
                Qty = 50,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 26,
                Name = "Colorful Trainers",
                Description = "Colorful trainsers - available in most sizes",
                ImageURL = "/Images/Shoes/image2.jpg",
                Price = 150,
                Qty = 60,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 27,
                Name = "Blue Nike Trainers",
                Description = "Blue Nike Trainers - available in most sizes",
                ImageURL = "/Images/Shoes/image3.jpg",
                Price = 200,
                Qty = 70,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 28,
                Name = "Colorful Hummel Trainers",
                Description = "Colorful Hummel Trainers - available in most sizes",
                ImageURL = "/Images/Shoes/image4.jpg",
                Price = 120,
                Qty = 120,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 29,
                Name = "Red Nike Trainers",
                Description = "Red Nike Trainers - available in most sizes",
                ImageURL = "/Images/Shoes/image5.jpg",
                Price = 200,
                Qty = 100,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 30,
                Name = "Birkenstock Sandles",
                Description = "Birkenstock Sandles - available in most sizes",
                ImageURL = "/Images/Shoes/image6.jpg",
                Price = 50,
                Qty = 150,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 31,
                Name = "Sneakers",
                Description = "Birkenstock Sandles - available in most sizes",
                ImageURL = "/Images/Shoes/image7.jpg",
                Price = 150,
                Qty = 50,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 32,
                Name = "Sandles",
                Description = "Birkenstock Sandles - available in most sizes",
                ImageURL = "/Images/Shoes/image8.jpg",
                Price = 500,
                Qty = 50,
                CategoryId = 4
            });


            //Add users
            //modelBuilder.Entity<User>().HasData(new User
            //{
            //    Id = 1,
            //    UserName = "Amany"

            //});
            //modelBuilder.Entity<User>().HasData(new User
            //{
            //    Id = 2,
            //    UserName = "Mohamed"

            //});

            //Create Shopping Cart for Users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2

            });
            //Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Beauty"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Furniture"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Electronics"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Shoes"
            });
        }

        //public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> Category { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<CartItem> CartItem { get; set; }
    }
}
