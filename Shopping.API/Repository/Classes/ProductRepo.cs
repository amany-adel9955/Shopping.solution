using Microsoft.EntityFrameworkCore;
using Shopping.API.Data;
using Shopping.API.Entities;
using Shopping.API.Repository.Contracts;

namespace Shopping.API.Repository.Classes
{
    public class ProductRepo : IProductRepo
    {
        private readonly ApplicationDbContext _context;

        public ProductRepo(ApplicationDbContext context)
        {
            _context = context;  
        }
      public async  Task<IEnumerable<ProductCategory>>GetAllCategories()
        {
            var categories = await _context.Category.ToListAsync();
            return categories;
        }

      public async Task<IEnumerable<Product>>GetAllProducts()
        {
            var products = await _context.Product.ToListAsync();
            return products;
        }

     public async Task<Product> GetProduct(int id)
        {
            throw new NotImplementedException();
        }

       public async Task<ProductCategory> GetProductCategory(int id)
        {
            throw new NotImplementedException();
        }
    }
}
